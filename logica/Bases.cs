using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asistencias.logica
{
    public class Bases
    {
        public static void DisenioDt(ref DataGridView Listado)
        {
            Listado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            Listado.BackgroundColor = Color.FromArgb(28, 29, 31);
            Listado.EnableHeadersVisualStyles = false;
            Listado.BorderStyle = BorderStyle.None;
            Listado.CellBorderStyle=DataGridViewCellBorderStyle.None;
            Listado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Listado.RowHeadersVisible = false;
            DataGridViewCellStyle cabecera=new DataGridViewCellStyle(); 
            cabecera.BackColor = Color.FromArgb(28, 29, 31);
            cabecera.ForeColor= Color.White;
            cabecera.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            Listado.ColumnHeadersDefaultCellStyle = cabecera;

        }
        public static object Decimales(TextBox Cajatexto,KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') || (e.KeyChar == ','))
            {
                e.KeyChar = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }else if(e.KeyChar == ',' && (~Cajatexto.Text.IndexOf(",")) != 0)
            {
                e.Handled = true;
            }else if (e.KeyChar==',')
            {
                e.Handled = false;
            }else if (e.KeyChar=='.')
            {
                e.Handled=false;
            }
            else
            {
                e.Handled = true;
            }
            return null;
        }
    }
}
