using Asistencias.datos;
using Asistencias.logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Asistencias.presentacion
{
    public partial class CtlUsuarios : UserControl
    {
        public CtlUsuarios()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Limpiar();
            HabilitarPanales();
            MostrarModulos();
        }
        private void Limpiar()
        {
            txtNombre.Clear();
            txtUsuario.Clear();
            txtPassword.Clear();
        }
        private void HabilitarPanales()
        {
            pnRegistro.Visible = true;
            lbAvisoIcono.Visible = true;
            pnIconos.Visible = false;
            pnRegistro.Dock=DockStyle.Fill;
            pnRegistro.BringToFront();
            btnGuardar.Visible = true;
            btnEditar.Visible = false;
            btnRegresar.Visible = true;
        }
        private void MostrarModulos()
        {
            DModulo funcion=new DModulo();
            DataTable dt = new DataTable();
            funcion.mostrarModulos(ref dt);
            dtModulos.DataSource = dt;
            dtModulos.Columns["Marcar"].ReadOnly = false;
            dtModulos.Columns["idModulo"].ReadOnly = true;
            dtModulos.Columns["modulo"].ReadOnly = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtUsuario.Text)&& !string.IsNullOrEmpty(txtPassword.Text))
            {
                if (lbAvisoIcono.Visible==false)
                {
                    insertarUsuarios();
                }
                else
                {
                    MessageBox.Show("Seleccione un icono");
                }
            }
            else
            {
                MessageBox.Show("Debe rellenar todos los campos.");
            }
        }

        private void insertarUsuarios()
        {
            LUsuario parametros = new LUsuario();
            DUsuario funcion=new DUsuario();
            parametros.nombres = txtNombre.Text;
            parametros.login = txtUsuario.Text;
            parametros.password = txtPassword.Text;
            MemoryStream ms=new MemoryStream();
            pbIcono.Image.Save(ms, pbIcono.Image.RawFormat);
            parametros.icono=ms.GetBuffer();
            if (funcion.insertarUsuario(parametros) == true)
            {

            }
        }
    }
}
