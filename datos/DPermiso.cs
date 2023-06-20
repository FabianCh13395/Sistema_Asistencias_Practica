using Asistencias.logica;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asistencias.datos
{
    public class DPermiso
    {
        public bool insertarPermisos(LPermiso parametros)
        {
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlCommand cmd = new SqlCommand("insertarPermisos", CONEXIONMAESTRA.conexionDB);
				cmd.CommandType =CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@IdModulo ", parametros.idModulo);
				cmd.Parameters.AddWithValue("@IdUsuario ", parametros.idUsuario);
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
				return false;
			}
			finally
			{
				CONEXIONMAESTRA.cerrar();
			}
        }
		public void mostrarPermisos(ref  DataTable dt,LPermiso parametros)
		{
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlDataAdapter da = new SqlDataAdapter("mostrarPermisos", CONEXIONMAESTRA.conexionDB);
				da.SelectCommand.CommandType = CommandType.StoredProcedure;
				da.SelectCommand.Parameters.AddWithValue("@idusuario", parametros.idUsuario);
				da.Fill(dt);
			}
			catch (Exception e)
			{

				MessageBox.Show(e.StackTrace);
			}
			finally
			{
				CONEXIONMAESTRA.cerrar();
			}
		}
		public bool eliminarPermisos(LPermiso parametros)
		{
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlCommand cmd = new SqlCommand("eliminarPermisos",CONEXIONMAESTRA.conexionDB);
				cmd.CommandType=CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@IdUsuario", parametros.idUsuario);
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.StackTrace);
				return false;
			}
			finally
			{
				CONEXIONMAESTRA.cerrar();
			}
		}
    }
}
