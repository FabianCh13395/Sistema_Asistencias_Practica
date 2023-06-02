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
    }
}
