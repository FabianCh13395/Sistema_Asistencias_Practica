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
            buscarCargos();
        }

        private void btnGuardarPersonal_Click(object sender, EventArgs e)
        {

        }
        private void InsertarPersonal()
        {
            LPersonal parametros = new LPersonal();
            parametros.nombres= txtNombres.Text;
            parametros.cedula = txtCedula.Text;
            parametros.pais = cbPaises.Text;
        }
        private void InsertarCargos()
        {
            if (!string.IsNullOrEmpty(txtCargoI.Text))
            {
                if (!string.IsNullOrEmpty(txtSueldoI.Text))
                {
                    Lcargo parametro = new Lcargo();
                    Dcargos funcion = new Dcargos();
                    parametro.Cargo = txtCargoI.Text;
                    parametro.sueldoPorHora = Convert.ToDouble(txtSueldoI.Text);
                    if (funcion.InsertarCargos(parametro))
                    {
                        txtCargo.Clear();
                        buscarCargos();
                        pnCargos.Visible = false;

                    }
                }
                else
                {
                    MessageBox.Show("Agregue el Sueldo", "Falta el Sueldo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Agregue el Cargo", "Falta el Cargo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void buscarCargos()
        {
            DataTable dt = new DataTable();
            Dcargos funcion = new Dcargos();
            Console.WriteLine(txtCargo.Text+"Estamos aqui");
            funcion.BuscarCargos(ref dt, txtCargo.Text);
            dtListadoCargos.DataSource = dt;
            Bases.DisenioDt(ref dtListadoCargos);
        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {
            buscarCargos();
        }

        private void btnAgregarCargo_Click(object sender, EventArgs e)
        {
            pnCargos.Visible = true;
            pnCargos.Dock = DockStyle.Fill;
            pnCargos.BringToFront();
            btnGuardarCargo.Visible = true;
            txtCargoI.Clear();
            txtSueldoI.Clear();

        }

        private void btnGuardarCargo_Click(object sender, EventArgs e)
        {
            InsertarCargos();
        }

        private void txtSueldoI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Decimales(txtSueldoI, e);
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Decimales(txtSueldo, e);

        }
    }
}
