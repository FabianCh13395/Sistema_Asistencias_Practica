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
        int idCargo=0 ;
        int desde = 1;
        int hasta = 10;
        int contador;
        int idPersonal;
        private int items_por_pagina = 10;
        string estado;
        int totalPaginas;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LocalizarDtvCargos();
            pnCargos.Visible = false;
            pnPaginado.Visible = false;
            pnRegistros.Visible = true;
            pnRegistros.Dock=DockStyle.Fill;
            btnGuardarPersonal.Visible = true;
            btnGuardarCambiosPersonal.Visible = false;
            limpiar();
        }
        private void LocalizarDtvCargos()
        {
            dtListadoCargos.Location=new Point(txtCargo.Location.X,txtCargo.Location.Y+25);
            dtListadoCargos.Size = new Size(460, 140);
            dtListadoCargos.Visible = true;
            lblTextoSueldo.Visible = false;
            pnBtnGuardarPersonal.Visible=false;
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
            if (!string.IsNullOrEmpty(txtNombres.Text))
            {
                if (!string.IsNullOrEmpty(txtCedula.Text))
                {
                    if (!string.IsNullOrEmpty(cbPaises.Text))
                    {
                        if (idCargo > 0)
                        {
                            if (!string.IsNullOrEmpty(txtSueldo.Text))
                            {
                                InsertarPersonal();
                            }
                        }
                    }
                }
            }
        }
        private void InsertarPersonal()
        {
            LPersonal parametros = new LPersonal();
            Dpersonal dpersonal = new Dpersonal();
            parametros.nombres= txtNombres.Text;
            parametros.cedula = txtCedula.Text;
            parametros.pais = cbPaises.Text;
            parametros.id_cargo = idCargo;
            parametros.sueldo_hora = Convert.ToDouble( txtSueldo.Text);
            if (dpersonal.InsertarPersonal(parametros) == true)
            {
                MostrarPersonal();
                pnRegistros.Visible= false;
            }
        }
        private void MostrarPersonal()
        {
            DataTable dt = new DataTable();
            Dpersonal funcion = new Dpersonal();
            funcion.MostrarPersonal(ref dt, desde, hasta);
            dtListadoPersonal.DataSource= dt;
            DiseniarDtvPersonal();
        }
        private void DiseniarDtvPersonal()
        {
            Bases.DisenioDt(ref dtListadoPersonal);
            pnPaginado.Visible= true;
            dtListadoPersonal.Columns[2].Visible=false;
            dtListadoPersonal.Columns[7].Visible = false;
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
            funcion.BuscarCargos(ref dt, txtCargo.Text);
            dtListadoCargos.DataSource = dt;
            Bases.DisenioDt(ref dtListadoCargos);
            dtListadoCargos.Columns[1].Visible = false;
            dtListadoCargos.Columns[3].Visible = false;
            dtListadoCargos.Visible = true;
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

        private void dtListadoCargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtListadoCargos.Columns["EditarC"].Index)
            {
                ObtenerCargosEditar();
            }
            if (e.ColumnIndex == dtListadoCargos.Columns["cargo"].Index)
            {
                ObtenerDatosCargo();
            }
        }
        private void ObtenerDatosCargo()
        {
            idCargo = Convert.ToInt32(dtListadoCargos.SelectedCells[1].Value);
            txtCargo.Text = dtListadoCargos.SelectedCells[2].Value.ToString();
            txtSueldo.Text = dtListadoCargos.SelectedCells[3].Value.ToString();
            dtListadoCargos.Visible = false;
            pnBtnGuardarPersonal.Visible = true;
            lblTextoSueldo.Visible = true;
        }
        private void ObtenerCargosEditar()
        {
            idCargo = Convert.ToInt32(dtListadoCargos.SelectedCells[1].Value);
            txtCargoI.Text = dtListadoCargos.SelectedCells[2].Value.ToString();
            txtSueldoI.Text=dtListadoCargos.SelectedCells[3].Value.ToString();
            btnGuardarCargo.Visible = false;
            btnGuardarEditadoC.Visible = true;
            btnCancelarCargo.Visible = true;
            txtCargoI.Focus();
            txtCargoI.SelectAll();
            pnCargos.Visible = true;
            pnCargos.Dock=DockStyle.Fill;
            pnCargos.BringToFront();
        }

        private void btnCancelarCargo_Click(object sender, EventArgs e)
        {
            pnCargos.Visible=false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            pnRegistros.Visible=false;
        }

        private void btnGuardarEditadoC_Click(object sender, EventArgs e)
        {
            EditarCargos();
        }
        private void EditarCargos()
        {
            Lcargo parametros = new Lcargo();
            Dcargos funcion = new Dcargos();
            parametros.id_cargo = idCargo;
            parametros.Cargo = txtCargoI.Text;
            parametros.sueldoPorHora = Convert.ToDouble(txtSueldoI.Text);
            if (funcion.EditarCargo(parametros) == true)
            {
                txtCargo.Clear();
                buscarCargos();
                pnCargos.Visible = false;
            }
        }

        private void Personal_Load(object sender, EventArgs e)
        {
            MostrarPersonal();
        }

        private void dtListadoPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtListadoPersonal.Columns["Eliminar"].Index)
            {
                DialogResult result = MessageBox.Show("Esta seguro que desea cambiar de estado a eliminado el siguiente registro?", "ELIMINAR REGISTRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(result == DialogResult.OK)
                {
                    EliminarPersonal();
                }
                
            }
            if (e.ColumnIndex == dtListadoPersonal.Columns["Editar"].Index)
            {
                ObtenerDatos();
            }
        }
        private void EliminarPersonal()
        {
            idPersonal = Convert.ToInt32(dtListadoPersonal.SelectedCells[2].Value);
            LPersonal parametro=new LPersonal();
            Dpersonal funcion=new Dpersonal();
            parametro.id_personal = idPersonal;
            if (funcion.EliminarPersonal(parametro) == true)
            {
                MostrarPersonal();
            }
        }
        private void ObtenerDatos()
        {
            idPersonal = Convert.ToInt32(dtListadoPersonal.SelectedCells[2].Value);
            estado = dtListadoPersonal.SelectedCells[8].Value.ToString();
            if (estado == "Eliminado")
            {
                RestaurarPersonal();
            }
            else
            {
                txtNombres.Text = dtListadoPersonal.SelectedCells[3].Value.ToString();
                txtCedula.Text=dtListadoPersonal.SelectedCells[4].Value.ToString();
                cbPaises.Text = dtListadoPersonal.SelectedCells[10].Value.ToString();
                txtCargo.Text=dtListadoPersonal.SelectedCells[6].Value.ToString();
                idCargo= Convert.ToInt32(dtListadoPersonal.SelectedCells[7].Value);
                txtSueldo.Text=dtListadoPersonal.SelectedCells[5].Value.ToString();
                pnPaginado.Visible = false;
                pnCargos.Visible = false;
                pnRegistros.Visible = true;
                pnRegistros.Dock=DockStyle.Fill;
                dtListadoCargos.Visible = false;
                lblTextoSueldo.Visible = false;
                pnBtnGuardarPersonal.Visible = true;
                btnGuardarCambiosPersonal.Visible = true;
                btnGuardarPersonal.Visible=false;

            }
        }
        private void RestaurarPersonal()
        {

        }
    }
}
