using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asistencias.presentacion.AsistenteInstalacion
{
    public partial class InstalarBD : Form
    {
        public InstalarBD()
        {
            InitializeComponent();
        }
        string nombre_equipo_usuario;

        private void InstalarBD_Load(object sender, EventArgs e)
        {
           centrarPaneles();
            remplazar();
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

            txtEliminarBase.Text = txtEliminarBase.Text.Replace("AsistorBD ", TXTbasededatos.Text);
            txtCrearUsuarioDb.Text = txtCrearUsuarioDb.Text.Replace("raptor", txtusuario.Text);
            txtCrearUsuarioDb.Text = txtCrearUsuarioDb.Text.Replace("AsistorBD",TXTbasededatos.Text);
            txtCrearUsuarioDb.Text=txtCrearUsuarioDb.Text.Replace("13395",lblcontraseña.Text);
            txtCrear_procedimientos.Text = txtCrear_procedimientos.Text + Environment.NewLine + txtCrearUsuarioDb.Text;
        }
        private void comprobar_si_hay_servidor_SQLEXPRESS()
        {
            txtservidor.Text = @".\"+lblnombredeservicio.Text;
            eliminarBaseDatos();
        }
        private void eliminarBaseDatos()
        {
            string str;
            SqlConnection myCon = new SqlConnection("Data source" + txtservidor.Text + ";Initial Catalog=master;Integrated Security=True");
            str = txtEliminarBase.Text;
            SqlCommand myCommand = new SqlCommand(str, myCon);
            try
            {
                myCon.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
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
            var cnn = new SqlConnection("Server=" + txtservidor.Text + "; " + "database=master; Integrated Security=yes");
            string s = "CREATE DATABASE " + TXTbasededatos.Text;
            var cmd = new SqlCommand(s, cnn);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();


            }
            catch (Exception)
            {

            }
        }
    }
}
