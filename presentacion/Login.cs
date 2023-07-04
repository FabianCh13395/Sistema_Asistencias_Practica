using Asistencias.datos;
using Asistencias.logica;
using Asistencias.presentacion.AsistenteInstalacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asistencias.presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string usuario;
        int idUsuario;
        int contador;
        string indicador;
        private void Login_Load(object sender, EventArgs e)
        {
            validarConexion();
        }
        private void validarConexion()
        {
            verificarConexion();
            Console.WriteLine(indicador);
            if (indicador == "Correcto")
            {
                mostrarUsuarios();
                if (contador == 0)
                {
                    Dispose();
                    UsuarioPrincipal frm =new UsuarioPrincipal();
                    frm.ShowDialog();
                }
                else
                {
                    DibujarUsuarios();
                }
                
            }
            else
            {
                Dispose();
                MessageBox.Show("No se puede conectar");
                EleccionServidor frm = new EleccionServidor();
                frm.ShowDialog();
            }
        }
        private void verificarConexion()
        {
            DUsuario funcion =new DUsuario();
            funcion.verificarUsuarios(ref indicador);
        }
        private void DibujarUsuarios()
        {
            try
            {
                pnUsuario.Visible = true;
                pnUsuario.Dock = DockStyle.Fill;
                pnUsuario.BringToFront();
                DataTable dt = new DataTable();
                DUsuario funcion = new DUsuario();
                funcion.mostrarUsuarios(ref dt);
                foreach(DataRow dr in dt.Rows)
                {
                    //Dibujado del label para el usuario
                    Label b = new Label();
                    Panel p=new Panel();
                    PictureBox im=new PictureBox();
                    b.Text = dr["login"].ToString();
                    b.Name = dr["idUsuario"].ToString();
                    b.Size = new Size(175, 25);
                    b.Font = new Font("Microsoft Sans Serif",13);
                    b.BackColor = Color.Transparent;
                    b.ForeColor = Color.White;
                    b.Dock = DockStyle.Bottom;
                    b.TextAlign = ContentAlignment.MiddleCenter;
                    b.Cursor = Cursors.Hand;

                    //Dibijado para el panel de usuario
                    p.Size = new Size(200, 167);
                    p.BorderStyle = BorderStyle.None;
                    p.BackColor = Color.FromArgb(93,109, 126);

                    //Dibujado del pictureBox
                    im.Size = new Size(175, 132);
                    im.Dock=DockStyle.Top;
                    im.BackgroundImage = null;
                    byte[] bi = (Byte[])dr["icono"];
                    MemoryStream ms = new MemoryStream(bi);
                    im.Image=Image.FromStream(ms);
                    im.SizeMode = PictureBoxSizeMode.Zoom;
                    im.Tag = dr["login"].ToString() ;
                    im.Cursor= Cursors.Hand ;

                    //Asignacion de controles al panel
                    p.Controls.Add(b);
                    p.Controls.Add(im);
                    b.BringToFront();

                    flowLayoutPanelUsuarios.Controls.Add(p);

                    b.Click += mieventoLabel;
                    im.Click += miEventoImagen;


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void miEventoImagen(object sender, EventArgs e)
        {
            usuario = ((PictureBox)sender).Tag.ToString();
            MostrarPanelPassword();
        }

        private void mieventoLabel(object sender, EventArgs e)
        {
            usuario = ((Label)sender).Text;
            MostrarPanelPassword();
        }
        private void MostrarPanelPassword()
        {
            pnIngresoContrasenia.Visible = true;
            pnIngresoContrasenia.Location=new Point((Width-pnIngresoContrasenia.Width)/2,(Height-pnIngresoContrasenia.Height)/2);
            pnUsuario.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            validarUsuarios();
        }
        private void validarUsuarios()
        {
            LUsuario parametros = new LUsuario();
            DUsuario funcion=new DUsuario();
            parametros.password=txtPassword.Text;
            parametros.login = usuario;
            funcion.validarUsuarios(parametros, ref idUsuario);
            if (idUsuario > 0) 
            {
                Dispose();
                MenuPrincipal frm=new MenuPrincipal();
                frm.ShowDialog();
            }
        }
        private void mostrarUsuarios()
        {
                DataTable dt=new DataTable();
            DUsuario funcion= new DUsuario();
            funcion.mostrarUsuarios(ref dt);
            contador = dt.Rows.Count;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contraseña Erronea", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "9";
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "0";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        private void btnBorrarUno_Click(object sender, EventArgs e)
        {
            int contador;
            contador=txtPassword.Text.Length;
            if (contador > 0)
            {
                txtPassword.Text=txtPassword.Text.Substring(0,txtPassword.Text.Length-1);
            }
        }

        private void btnCambiarUsuario_Click(object sender, EventArgs e)
        {
            flowLayoutPanelUsuarios.Controls.Clear();
            DibujarUsuarios();
        }
    }
}
