using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Asistencias.datos
{
    public class CONEXIONMAESTRA


    {
        // Convert.ToString(logica.Desencryptacion.checkServer());
        //@"Data source=LAPTOP-7EN4EVCO\SQLEXPRESS;Initial Catalog=Asitencias;Integrated Security=False;User Id=sa;Password="

        public static string conexion = @"Data source=LAPTOP-7EN4EVCO\SQLEXPRESS;Initial Catalog=Asistencias;User Id=raptor;Password=13395";
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
