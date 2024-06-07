using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class AlumnoAcademico
    {
        public string nombre { get; set; }
        public string matricula { get; set; }
        public string fechaReins { get; set; }
        public string especialidad { get; set; }
        public int cdtosAcumulados { get; set; }
        public int cdtosActuales { get; set; }
        public int semActual { get; set; }
    }
}
