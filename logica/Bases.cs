using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
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
        public static void DisenioDtvEliminar(ref DataGridView modificado) 
        {
            
            foreach (DataGridViewRow data in modificado.Rows)
            {
                string estado;
                estado = data.Cells["estado"].Value.ToString();
                if (estado == "ELIMINADO")
                {
                    data.DefaultCellStyle.Font = new Font("Segoe UI",12,FontStyle.Strikeout|FontStyle.Bold);
                    data.DefaultCellStyle.ForeColor = Color.FromArgb(146, 43, 33);
                }
            }
            
        }

        public enum DateInterval
        {
            Day,
            DayOfYear,
            Hour,
            Minute,
            Month,
            Quarter,
            Second,
            Weekday,
            WeekOfYear,
            Year
        }
        public static long DateDiff(DateInterval dateInterval,DateTime dateOne,DateTime dateTwo)
        {
            switch (dateInterval)
            {
                case DateInterval.Day:
                case DateInterval.DayOfYear:
                    TimeSpan spanforDays = dateTwo - dateOne;
                    return (long)spanforDays.TotalDays;
                case DateInterval.Hour:
                    TimeSpan spanforHours = dateTwo - dateOne;
                    return(long)spanforHours.TotalHours;
                case DateInterval.Minute:
                    TimeSpan spanforMinutes = dateTwo - dateOne;
                    return (long)spanforMinutes.TotalMinutes;
                case DateInterval.Month:
                    return ((dateTwo.Year - dateOne.Year) * 12) + (dateTwo.Month - dateOne.Month);
                case DateInterval.Quarter:
                    long dateOneQuarter = (long)Math.Ceiling(dateOne.Month / 3.0);
                    long dateTwoQuarter = (long)Math.Ceiling(dateTwo.Month / 3.0);
                    return (4 * (dateTwo.Year - dateOne.Year)) + dateTwoQuarter - dateOneQuarter;
                case DateInterval.Second:
                    TimeSpan spanforSecond = dateTwo - dateOne;
                    return (long)spanforSecond.TotalSeconds;
                case DateInterval.Weekday:
                    TimeSpan spanforWeekdays = dateTwo - dateOne;
                    return (long)(spanforWeekdays.TotalDays/7);
                case DateInterval.WeekOfYear:
                    DateTime dateOneModified = dateOne;
                    DateTime dateTwoModified = dateTwo;
                    while(dateTwoModified.DayOfWeek != DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek)
                    {
                        dateTwoModified = dateTwoModified.AddDays(-1);
                    }
                    while (dateOneModified.DayOfWeek != DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek)
                    {
                        dateOneModified = dateOneModified.AddDays(-1);
                    }
                    TimeSpan spanForWeekYear = dateTwoModified - dateOneModified;
                    return (long)(spanForWeekYear.TotalDays / 7.0);
                case DateInterval.Year:
                    return dateTwo.Year - dateOne.Year;
                default:
                    return 0;

            }
        }
    }
}
