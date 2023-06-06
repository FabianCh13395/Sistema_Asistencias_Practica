using Asistencias.logica;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Asistencias.datos
{
    public class Dcargos
    {
        public bool InsertarCargos(Lcargo parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertarCargo", CONEXIONMAESTRA.conexionDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cargo", parametros.Cargo);
                cmd.Parameters.AddWithValue("@sueldoPorHora ", parametros.sueldoPorHora);
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
        public bool EditarCargo(Lcargo parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editarCargo", CONEXIONMAESTRA.conexionDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", parametros.id_cargo);
                cmd.Parameters.AddWithValue("@cargo ", parametros.Cargo);
                cmd.Parameters.AddWithValue("@sueldo ", parametros.sueldoPorHora);
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
        public void BuscarCargos(ref DataTable dt,string buscador)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("buscarCargos", CONEXIONMAESTRA.conexionDB);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@buscador", buscador);
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
