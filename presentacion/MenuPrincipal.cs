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

namespace Asistencias.presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        public int idUsuario;
        public string loginV;


        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            panelBienvenida.Dock = DockStyle.Fill;
            validarPermisos();
        }
        private void validarPermisos()
        {
            DataTable dt=new DataTable();
            DPermiso funcion=new DPermiso();
            LPermiso parametros = new LPermiso();
            parametros.idUsuario= idUsuario;
            funcion.mostrarPermisos(ref dt,parametros);
            btnConsultas.Enabled = false;
            btnPersonal.Enabled = false;
            btnRegistro.Enabled = false;
            btnUsuarios.Enabled = false;
            btnRestaurar.Enabled = false;
            btnRespaldos.Enabled = false;
            foreach(DataRow rowPermiso in dt.Rows)
            {
                string modulo = Convert.ToString(rowPermiso["modulo"]);
                if (modulo == "PrePlanillas")
                {
                    btnConsultas.Enabled= true;
                }else if(modulo == "Usuarios")
                {
                    btnUsuarios.Enabled= true;
                    btnRegistro.Enabled= true;
                }else if (modulo == "Personal")
                {
                    btnPersonal.Enabled= true;
                }else if((modulo == "Respaldos"))
                {
                    btnRespaldos.Enabled= true;
                    btnRestaurar.Enabled= true;
                }
            }
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            pnlPadre.Controls.Clear();
            Personal control =new Personal();
            control.Dock = DockStyle.Fill;
            pnlPadre.Controls.Add(control);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            pnlPadre.Controls.Clear();
            CtlUsuarios usuario=new CtlUsuarios();
            usuario.Dock = DockStyle.Fill;
            pnlPadre.Controls.Add(usuario);
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            pnlPadre.Controls.Clear();
            PrePlanilla control=new PrePlanilla();
            control.Dock= DockStyle.Fill;
            pnlPadre .Controls.Add(control);   
        }
    }
}
