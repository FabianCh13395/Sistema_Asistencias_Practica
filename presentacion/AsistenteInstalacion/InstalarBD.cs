using Asistencias.logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Asistencias.presentacion.AsistenteInstalacion
{
    public partial class InstalarBD : Form
    {
        public InstalarBD()
        {
            InitializeComponent();
        }
        private AES aes = new AES();
        string nombre_equipo_usuario;
        string ruta;
        public static int milisegundo;
        public static int segundos;

        private void InstalarBD_Load(object sender, EventArgs e)
        {
           centrarPaneles();
            remplazar();
            comprobar_si_hay_servidor_SQLEXPRESS();
        }
        private void centrarPaneles ()
        {
            pnInstalador.Location = new Point((Width - pnInstalador.Width) / 2, (Height - pnInstalador.Height) / 2);
            nombre_equipo_usuario=System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            Cursor = Cursors.WaitCursor;
            panel4.Visible= false;
            panel4.Dock = DockStyle.None;

        }
        private void remplazar()
        {
            txtCrear_procedimientos.Text = txtCrear_procedimientos.Text.Replace("AsistorBD", TXTbasededatos.Text);

            txtEliminarBase.Text = txtEliminarBase.Text.Replace("AsistorBD", TXTbasededatos.Text);
            txtCrearUsuarioDb.Text = txtCrearUsuarioDb.Text.Replace("raptor", txtusuario.Text);
            txtCrearUsuarioDb.Text = txtCrearUsuarioDb.Text.Replace("AsistorBD",TXTbasededatos.Text);
            txtCrearUsuarioDb.Text=txtCrearUsuarioDb.Text.Replace("13395",lblcontraseña.Text);
            txtCrear_procedimientos.Text = txtCrear_procedimientos.Text + Environment.NewLine + txtCrearUsuarioDb.Text;
        }
        private void comprobar_si_hay_servidor_SQLEXPRESS()
        {
            txtservidor.Text = @".\"+lblnombredeservicio.Text;
            eliminarBaseDatos();
            ejecutar_scrypt_CrearBase();
        }
        private void eliminarBaseDatos()
        {
            string str;
            SqlConnection myCon = new SqlConnection("Data source=" + txtservidor.Text + ";Initial Catalog=master;Integrated Security=true");
            str = txtEliminarBase.Text;
            MessageBox.Show(str);
            SqlCommand myCommand = new SqlCommand(str, myCon);
            try
            {
                myCon.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (myCon.State == ConnectionState.Open)
                {
                    myCon.Close();
                }
            }

        }
        private void ejecutar_scrypt_CrearBase()
        {
            var cnn = new SqlConnection("Server=" + txtservidor.Text + ";" + "database=master; Integrated Security=yes");
            string s = "CREATE DATABASE " + TXTbasededatos.Text;
            var cmd = new SqlCommand(s, cnn);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                SavetoXML(aes.Encrypt("Data Source="+txtservidor.Text+";Initial Catalog="+TXTbasededatos.Text+";Integrated Securiry=true",Desencryptacion.appPwdUnique,int.Parse("256")));
                EjecutarScript();
                btnInstalacion.Enabled = false;
                panel2.Visible = true;
                panel2.Dock = DockStyle.Fill;
                label2.Text = @"Instancia Encontrada....
                No Cierre esta ventana, se cerrara automaticamente cuando este todo listo.";
                panel4.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                tmr3.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha sucedido un error al crear el scrypt de la base de datos");
                MessageBox.Show(ex.Message);
            }
        }
        private void EjecutarScript()
        {
            ruta = Path.Combine(Directory.GetCurrentDirectory(), txtnombre_scrypt.Text + ".txt");
            //FileInfo fi=new FileInfo(ruta);
            StreamWriter sw;
            try
            {
                if (File.Exists(ruta) == false)
                {
                    sw=File.CreateText(ruta);
                    sw.WriteLine(txtCrear_procedimientos.Text);
                    sw.Flush();
                    sw.Close();
                }else if(File.Exists(ruta)==true){
                    File.Delete(ruta );
                    sw = File.CreateText(ruta);
                    sw.WriteLine(txtCrear_procedimientos.Text);
                    sw.Flush();
                    sw.Close();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Ha sucedido un error al momento de pasar el script al archivo txt");
            }
            try
            {
                Process pross = new Process();
                pross.StartInfo.FileName = "sqlcmd";
                pross.StartInfo.Arguments=" -S " + txtservidor.Text + " -i " + txtnombre_scrypt.Text + ".txt";
                pross.Start();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al abrir la consola ");
            }
        }
        private void SavetoXML(object dbcnString)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ConnectionString.xml");
            XmlElement root = doc.DocumentElement;
            root.Attributes[0].Value = Convert.ToString(dbcnString);
            XmlTextWriter writer = new XmlTextWriter("ConnectionString.xml", null);
            writer.Formatting = Formatting.Indented;
            doc.Save(writer);
            writer.Close();

        }

        private void btnInstalacion_Click(object sender, EventArgs e)
        {

        }

        private void tmr3_Tick(object sender, EventArgs e)
        {
            tmr1.Stop();
            tmr2.Stop();
            milisegundo += 1;
            lblMilisegundos.Text= milisegundo.ToString();
            if (milisegundo == 60)
            {
                segundos += 1;
                lblSegundos.Text= segundos.ToString();
                milisegundo= 0;
            }
            if (segundos == 15)
            {
                tmr3.Stop();
                try
                {
                    File.Delete(ruta);

                }
                catch (Exception)
                {

                    MessageBox.Show("Error al crear el tiempo ");
                }
                Dispose();
            }

        }
    }
}
