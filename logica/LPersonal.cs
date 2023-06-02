using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asistencias.logica
{
    public class LPersonal
    {
        public int id_personal {get;set;}
        public string nombres { get;set;}
        public string cedula { get;set;}
        public string pais { get;set;}

        public int id_cargo { get;set;} 
        public double sueldo_hora { get;set;}

        public string estado { get;set;} 

        public string codigo { get;set; }
    }
}
