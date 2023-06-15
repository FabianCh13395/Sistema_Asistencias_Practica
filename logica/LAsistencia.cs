using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asistencias.logica
{
    public class LAsistencia
    {
        public int idAsistencia { get; set; }
        public int IdPersonal { get; set; }
        public DateTime fecha_entrada { get; set; }

        public DateTime fecha_salida { get;set; }
        public string estado { get; set; }

        public double horas { get; set; }
        public string observacion { get; set; }
    }
}
