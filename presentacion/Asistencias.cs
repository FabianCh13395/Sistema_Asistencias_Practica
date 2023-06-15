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
    public partial class Asistencias : Form
    {
        public Asistencias()
        {
            InitializeComponent();
        }
        string cedula;
        int idPersonal;
        int contador;
        DateTime fechaRegistro;

        private void Asistencias_Load(object sender, EventArgs e)
        {

        }

        private void tmTiempo_Tick(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToString("HH:mm:ss");
            txtFecha.Text = DateTime.Now.ToShortDateString();       
        }

        private void txtICedula_TextChanged(object sender, EventArgs e)
        {
            buscarPersonalCedula();
            if (cedula == txtICedula.Text)
            {
                buscarAsistenciasId();
                if (contador == 0)
                {
                    DialogResult result = MessageBox.Show("¿Agregar una Observación?", "Observación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        pnObservacion.Visible = true;
                        pnObservacion.Location=new Point(pnPrincipal.Location.X, pnPrincipal.Location.Y);
                        pnObservacion.Size=new Size(pnPrincipal.Width, pnPrincipal.Height);
                        pnObservacion.BringToFront();
                        rchObservacion.Clear();
                        rchObservacion.Focus();
                    }
                    else
                    {
                        insertarAsistencias();
                    }
                }
                else
                {
                    confirmarSalida();

                }
            }
        }
        private void confirmarSalida()
        {
            LAsistencia parametros=new LAsistencia();
            DAsistencia funcion=new DAsistencia();
            parametros.IdPersonal = idPersonal;
            parametros.fecha_salida = DateTime.Now;
            parametros.horas=Bases.DateDiff(Bases.DateInterval.Hour,fechaRegistro,DateTime.Now);
            if (funcion.confirmarSalida(parametros) == true)
            {
                txtEntrada.Text = "SALIDA REGISTRADA";
                txtICedula.Clear();
                txtICedula.Focus();
            }
        }
        private void insertarAsistencias()
        {
            if (string.IsNullOrEmpty(rchObservacion.Text))
            {
                rchObservacion.Text = "-";
            }

            LAsistencia parametros = new LAsistencia();
            DAsistencia funcion= new DAsistencia();
            parametros.IdPersonal = idPersonal;
            parametros.fecha_entrada=DateTime.Now;
            parametros.fecha_salida = DateTime.Now;
            parametros.estado = "ENTRADA";
            parametros.horas = 0;
            parametros.observacion = rchObservacion.Text;
           if(funcion.insertarAsistencia(parametros) == true)
            {
                txtEntrada.Text = "Entrada Registrada";
                txtICedula.Clear();
                txtICedula.Focus();
                pnObservacion.Visible = false;
            }
        }
        private void buscarAsistenciasId()
        {
            DataTable dt =new DataTable();
            DAsistencia funcion =new DAsistencia();
            funcion.BuscarAsistenciasId(ref dt, idPersonal);
            contador = dt.Rows.Count;
            if (contador > 0)
            {
                fechaRegistro = Convert.ToDateTime(dt.Rows[0]["fecha_entrada"]);
            }
        }
        private void buscarPersonalCedula()
        {
            DataTable dt = new DataTable();
            Dpersonal funcion = new Dpersonal();
            Console.WriteLine(txtICedula.Text);
            funcion.BuscarPersonalCedula(ref dt, txtICedula.Text);
            if(dt.Rows.Count > 0)
            {
                Console.WriteLine("Entro Aqui");
                cedula = dt.Rows[0]["cedula"].ToString();
                idPersonal = Convert.ToInt32(dt.Rows[0]["id_personal"]);
                txtNombre.Text = dt.Rows[0]["nombres"].ToString();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            insertarAsistencias();
        }
    }
}
