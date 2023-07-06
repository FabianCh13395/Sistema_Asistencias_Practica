using Asistencias.datos;
using Asistencias.logica;
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

namespace Asistencias.presentacion.AsistenteInstalacion
{
    public partial class UsuarioPrincipal : Form
    {
        public UsuarioPrincipal()
        {
            InitializeComponent();
        }
        int IdUsuario;

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombreUsuario.Text)){
                if (!string.IsNullOrEmpty(txtContrasenia.Text))
                {
                    if (txtContrasenia.Text == txtContrasenia2.Text)
                    {
                        insertarUsuariosDefecto();
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden,verifiquelas por favor", "AsisTor", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("El campo de contraseña no puede estar vacio", "AsisTor",MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("El nombre de usuario no debe estar vacio","AsisTor",MessageBoxButtons.OK);
            }
        }

        private void insertarUsuariosDefecto()
        {
            LUsuario parametro=new LUsuario();
            DUsuario funcion=new DUsuario();
            parametro.nombres = txtNombreUsuario.Text;
            parametro.login=txtUsuario.Text;
            parametro.password = txtContrasenia.Text;
            MemoryStream ms=new MemoryStream();
            Icono.Image.Save(ms, Icono.Image.RawFormat);
            parametro.icono=ms.GetBuffer();
            if (funcion.insertarUsuario(parametro) == true)
            {
                insertarModulos();
                ObtenerIdUsuario();
                insertarPermiso();
            }

        }
        private void ObtenerIdUsuario()
        {
            DUsuario funcion=new DUsuario();
            funcion.obtenerIdUsuario(ref IdUsuario, txtUsuario.Text);
        }
        private void insertarPermiso()
        {
            DataTable dt=new DataTable();
            DModulo funcionModulos=new DModulo();
            funcionModulos.mostrarModulos(ref dt);
            foreach (DataRow row in dt.Rows)
            {
                int idModulo = Convert.ToInt32(row["idModulo"]);
                LPermiso parametros=new LPermiso();
                DPermiso funcion=new DPermiso();
                parametros.idModulo=idModulo;
                parametros.idUsuario = IdUsuario;
                if (funcion.insertarPermisos(parametros) == true)
                {
                    MessageBox.Show("Recuerda que para iniciar sesion tu usuario es: " + txtUsuario.Text+"\n Contraseña: "+txtContrasenia.Text,"AsisTor",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Dispose();
                    Login frm=new Login();
                    frm.ShowDialog();
                }
            }
        }
        private void insertarModulos()
        {
            LModulo parametros=new LModulo();
            DModulo funcion=new DModulo();
            var Modulos = new List<string> { "Usuarios", "Personal", "PrePlanillas","Respaldos" };
            foreach(var modulo in Modulos)
            {
                parametros.modulo = modulo;
                funcion.insertarModulos(parametros);
            }
        }
    }
}
