using Asistencias.datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asistencias.presentacion
{
    public partial class PrePlanilla : UserControl
    {
        public PrePlanilla()
        {
            InitializeComponent();
        }

        private void PrePlanilla_Load(object sender, EventArgs e)
        {
            calcularNumeroSemana();
        }
        private void ReporteDeAsistencias()
        {
            Reportes.ReporteAsistencias rpt=new Reportes.ReporteAsistencias();
            DataTable dataTable = new DataTable();
            DAsistencia funcion=new DAsistencia();
            funcion.mostrarAsistenciasDiarias(ref dataTable, dtDesde.Value, dtHasta.Value,Convert.ToInt32(lblSemana.Text));
            rpt.DataSource = dataTable;
            rpt.table1.DataSource = dtDesde;
            Telerik.Reporting.InstanceReportSource reportSource = new Telerik.Reporting.InstanceReportSource();
            reportSource.ReportDocument = rpt;
            reportViewer1.ReportSource=reportSource;
            reportViewer1.Refresh();
        }

        private void dtDesde_ValueChanged(object sender, EventArgs e)
        {
            calcularNumeroSemana();
            ReporteDeAsistencias();
        }
        private void calcularNumeroSemana()
        {
            DateTime v2 = dtHasta.Value;
            lblSemana.Text = CultureInfo.CurrentUICulture.Calendar.GetWeekOfYear(v2, CalendarWeekRule.FirstDay, v2.DayOfWeek).ToString();
        }

        private void dtHasta_ValueChanged(object sender, EventArgs e)
        {
            calcularNumeroSemana();
            ReporteDeAsistencias();
        }
    }
}
