using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Asistencias.logica;
using System.Windows.Forms;
using Asistencias.presentacion;

namespace Asistencias.datos
{
    public class Dpersonal
    {
        public bool InsertarPersonal(LPersonal parametros)
        {
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlCommand cmd=new SqlCommand("InsertarPersonal",CONEXIONMAESTRA.conexionDB);
				cmd.CommandType=CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@nombres", parametros.nombres);
				cmd.Parameters.AddWithValue("@cedula", parametros.cedula);
                cmd.Parameters.AddWithValue("@pais", parametros.pais);
                cmd.Parameters.AddWithValue("@id_cargo", parametros.id_cargo);
                cmd.Parameters.AddWithValue("@sueldoPorHora", parametros.sueldo_hora);
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
		public bool EditarPersonal(LPersonal parametros)
		{
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editarPersonal", CONEXIONMAESTRA.conexionDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_personal", parametros.id_personal);
                cmd.Parameters.AddWithValue("@nombres", parametros.nombres);
                cmd.Parameters.AddWithValue("@cedula", parametros.cedula);
                cmd.Parameters.AddWithValue("@pais", parametros.pais);
                cmd.Parameters.AddWithValue("@id_cargo", parametros.id_cargo);
                cmd.Parameters.AddWithValue("@sueldoPorHora", parametros.sueldo_hora);
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
        public bool EliminarPersonal(LPersonal parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("eliminarPersonal", CONEXIONMAESTRA.conexionDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_personal", parametros.id_personal);
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
        public void MostrarPersonal(ref DataTable dt, int desde, int hasta) {
            try {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrarPersonal",CONEXIONMAESTRA.conexionDB);
                da.SelectCommand.CommandType=CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Desde", desde);
                da.SelectCommand.Parameters.AddWithValue("@Hasta", hasta);
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

        public void BuscarPersonal(ref DataTable dt, int desde, int hasta,string buscador)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("BuscarPersonal", CONEXIONMAESTRA.conexionDB);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Desde", desde);
                da.SelectCommand.Parameters.AddWithValue("@Hasta", hasta);
                da.SelectCommand.Parameters.AddWithValue("@Buscador", buscador);
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

        public bool RestaurarPersonal(LPersonal parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("restaurar_personal", CONEXIONMAESTRA.conexionDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_personal", parametros.id_personal);
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

        public void ContarPersonal(ref int contador)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("Select Count(id_personal) from Personal",CONEXIONMAESTRA.conexionDB);
                contador = Convert.ToInt32( cmd.ExecuteScalar());
            }
            catch (Exception )
            {
                contador = 0;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }

        public void BuscarPersonalCedula(ref DataTable dtPersonal, string buscador)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("BuscarPersonalCedula", CONEXIONMAESTRA.conexionDB);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@buscador",buscador);
                da.Fill(dtPersonal);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }

        
    }
}
