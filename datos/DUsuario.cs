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
                cmd.CommandType = CommandType.StoredProcedure;
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
				MessageBox.Show( ex.Message );
				Console.WriteLine( ex.Message );
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
        
		public void obtenerIdUsuario(ref int idUsuario,string login)
		{
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlCommand cmd = new SqlCommand("obtenerIdUsuario",CONEXIONMAESTRA.conexionDB);
				cmd.CommandType=CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Login",login);
				idUsuario =Convert.ToInt32( cmd.ExecuteScalar());
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
		public void verificarUsuarios(ref string indicador)
		{
			try
			{
				int IdUser;
				CONEXIONMAESTRA.abrir();
				SqlCommand da = new SqlCommand("Select idUsuario from Usuario", CONEXIONMAESTRA.conexionDB);
				IdUser = Convert.ToInt32(da.ExecuteScalar());
				CONEXIONMAESTRA.cerrar();
				indicador = "Correcto";
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.StackTrace);
				MessageBox.Show(ex.StackTrace);
				indicador = "Incorrecto";
			}
		}

		public void validarUsuarios(LUsuario parametros,ref int id)
		{
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlCommand cmd = new SqlCommand("validarUsuario", CONEXIONMAESTRA.conexionDB);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Password ", parametros.password);
				cmd.Parameters.AddWithValue("@Login", parametros.login);
				id= Convert.ToInt32(cmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				id = 0;
				MessageBox.Show(ex.StackTrace);
			}
			finally
			{
				CONEXIONMAESTRA.cerrar();
			}
		}
    }
}
