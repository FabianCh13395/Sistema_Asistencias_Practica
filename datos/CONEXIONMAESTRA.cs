using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Asistencias.datos
{
    public class CONEXIONMAESTRA
    {
        public static string conexion = @"Data source=LAPTOP-7EN4EVCO\SQLEXPRESS;Initial Catalog=AsistorBD;Integrated Security=False;User Id=sa;Password=15xyz1820111";
        public static SqlConnection conexionDB = new SqlConnection(conexion);

        public static void abrir()
        {
            if (conexionDB.State == ConnectionState.Closed)
            {
                conexionDB.Open();
            }
        }
        public static void cerrar()
        {
            if (conexionDB.State == ConnectionState.Open)
            {
                conexionDB.Close();
            }
        }
    }
}
