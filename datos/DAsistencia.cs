using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asistencias.logica;

namespace Asistencias.datos
{
    public class DAsistencia
    {
        public void BuscarAsistenciasId(ref DataTable dt, int idPersona)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("buscarAsistenciasId", CONEXIONMAESTRA.conexionDB);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@IdPersonal", idPersona);
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

        public bool insertarAsistencia(LAsistencia parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertarAsistencias", CONEXIONMAESTRA.conexionDB);
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPersonal", parametros.IdPersonal);
                cmd.Parameters.AddWithValue("@fecha_entrada", parametros.fecha_entrada);
                cmd.Parameters.AddWithValue("@fecha_salida ", parametros.fecha_salida);
                cmd.Parameters.AddWithValue("@estado", parametros.estado);
                cmd.Parameters.AddWithValue("@horas ",parametros.horas);
                cmd.Parameters.AddWithValue("@observacion",parametros.observacion);
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

        public bool confirmarSalida(LAsistencia parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("confirmarSalida", CONEXIONMAESTRA.conexionDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPersonal", parametros.IdPersonal);
                cmd.Parameters.AddWithValue("@horas", parametros.horas);
                cmd.Parameters.AddWithValue("@fecha_salida ", parametros.fecha_salida);
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
