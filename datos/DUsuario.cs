using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using Asistencias.logica;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace Asistencias.datos
{
    public class DUsuario
    {
        public bool insertarUsuario(LUsuario parametros)
        {
			try
			{

                CONEXIONMAESTRA.abrir();
				SqlCommand cmd = new SqlCommand("insertarUsuario", CONEXIONMAESTRA.conexionDB);
				cmd.Parameters.AddWithValue("@nombres", parametros.nombres);
				cmd.Parameters.AddWithValue("@login", parametros.login);
				cmd.Parameters.AddWithValue("@password",parametros.password);
				cmd.Parameters.AddWithValue("@icono", parametros.icono);
				cmd.Parameters.AddWithValue("@estado","ACTIVO");
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex )
			{
				MessageBox.Show( ex.StackTrace );
				return false;
				
			}
			finally
			{
				CONEXIONMAESTRA.cerrar();
			}
        }
		public void mostrarUsuarios(ref DataTable dt)
		{
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlDataAdapter da = new SqlDataAdapter("Select * from Usuario", CONEXIONMAESTRA.conexionDB);
				da.Fill(dt);
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.StackTrace );
			}
			finally
			{
				CONEXIONMAESTRA.cerrar();

			}
		}
    }
}
