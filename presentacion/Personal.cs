using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asistencias.logica;
using Asistencias.datos;

namespace Asistencias.presentacion
{
    public partial class Personal : UserControl
    {
        public Personal()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnCargos.Visible = false;
            pnPaginado.Visible = false;
            pnRegistros.Visible = true;
            pnRegistros.Dock=DockStyle.Fill;
            btnGuardarPersonal.Visible = true;
            btnGuardarCambiosPersonal.Visible = false;
            limpiar();
        }
        private void limpiar()
        {
            txtNombres.Clear();
            txtCedula.Clear();
            txtCargo.Clear();
            txtSueldo.Clear();
        }
    }
}
