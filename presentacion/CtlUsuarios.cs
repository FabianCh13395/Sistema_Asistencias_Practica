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
        int IdUsuario;
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
            pnRegistro.BackColor = Color.White;
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
            dtModulos.Columns["modulo"].ReadOnly = true;
            dtModulos.Columns[1].Visible = false;
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
                obtenerIdUsuario();
                insertarPermisos();
            }
        }
        private void obtenerIdUsuario()
        {
            DUsuario funcion = new DUsuario();
            funcion.obtenerIdUsuario(ref IdUsuario, txtUsuario.Text);
        }
        private void insertarPermisos()
        {
            foreach(DataGridViewRow row in dtModulos.Rows)
            {
                int IdModulo = Convert.ToInt32(row.Cells["idModulo"].Value);
                bool marcado =Convert.ToBoolean( row.Cells["Marcar"].Value);
                if(marcado == true)
                {
                    LPermiso parametros = new LPermiso();
                    DPermiso funcion = new DPermiso();
                    parametros.idModulo=IdModulo;
                    parametros.idUsuario=IdUsuario;
                    funcion.insertarPermisos(parametros);
  
                }
            }
            mostrarUsuarios();
            pnRegistro.Visible = false;
        }
        private void mostrarUsuarios()
        {
            DataTable dt=new DataTable();
            DUsuario funcion = new DUsuario();
            funcion.mostrarUsuarios(ref dt);
            dtRegistroPersonal.DataSource = dt;
            diseniarDtGridViewUsuarios();
        }
        private void diseniarDtGridViewUsuarios()
        {
            Bases.DisenioDt(ref dtRegistroPersonal);
            Bases.DisenioDtvEliminar(ref dtRegistroPersonal);
            dtRegistroPersonal.Columns[2].Visible = false;
            dtRegistroPersonal.Columns[5].Visible = false;
            dtRegistroPersonal.Columns[6].Visible = false;
        }

        private void lbAvisoIcono_Click(object sender, EventArgs e)
        {
            mostrarPanelIcono();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pbIcono.Image= pictureBox3.Image;
            ocultarPanelIcono();
        }
        private void ocultarPanelIcono()
        {
            pnIconos.Visible=false;
            lbAvisoIcono.Visible=false;
            pbIcono.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pbIcono.Image = pictureBox4.Image;
            ocultarPanelIcono();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pbIcono.Image = pictureBox5.Image;
            ocultarPanelIcono();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pbIcono.Image = pictureBox6.Image;
            ocultarPanelIcono();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pbIcono.Image = pictureBox7.Image;
            ocultarPanelIcono();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pbIcono.Image = pictureBox8.Image;
            ocultarPanelIcono();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pbIcono.Image = pictureBox9.Image;
            ocultarPanelIcono();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pbIcono.Image = pictureBox10.Image;
            ocultarPanelIcono();
        }

        private void pbAgregarIconoPc_Click(object sender, EventArgs e)
        {
            dlgIcono.InitialDirectory = "";
            dlgIcono.Filter="Imagenes|*.jpg;*.png";
            dlgIcono.FilterIndex = 2;
            dlgIcono.Title = "Cargador de Iconos";
            if(dlgIcono.ShowDialog() == DialogResult.OK)
            {
                pbIcono.BackgroundImage = null;
                pbIcono.Image = new Bitmap(dlgIcono.FileName);
                ocultarPanelIcono();
            }
        }

        private void pbIcono_Click(object sender, EventArgs e)
        {
            mostrarPanelIcono();
        }
        private void mostrarPanelIcono()
        {
            pnIconos.Visible = true;
            pnIconos.Dock = DockStyle.Fill;
            pnIconos.BringToFront();
        }

        private void CtlUsuarios_Load(object sender, EventArgs e)
        {
            mostrarUsuarios();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            pnRegistro.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnIconos.Visible = false;
        }
    }
}
