using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asistencias.datos
{
    public class DModulo
    {
        public void mostrarModulos(ref DataTable dt)
        {
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlDataAdapter da = new SqlDataAdapter("Select * from Modulo",CONEXIONMAESTRA.conexionDB);
				da.Fill(dt);

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.StackTrace);
			}
			finally
			{
				CONEXIONMAESTRA.cerrar();
			}
        }
    }
}
