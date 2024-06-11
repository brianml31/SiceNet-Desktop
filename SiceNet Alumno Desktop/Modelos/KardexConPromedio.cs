using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class KardexConPromedio
    {
        public List<KardexEntry> lstKardex { get; set; }
        public Promedio Promedio { get; set; }
    }

    public class KardexEntry
    {
        public string FecEsp { get; set; }
        public string ClvMat { get; set; }
        public string ClvOfiMat { get; set; }
        public string Materia { get; set; }
        public int Cdts { get; set; }
        public int Calif { get; set; }
        public string Acred { get; set; }
        public string S1 { get; set; }
        public string P1 { get; set; }
        public string A1 { get; set; }
        public object S2 { get; set; }
        public object P2 { get; set; }
        public object A2 { get; set; }
    }

    public class Promedio
    {
        public double PromedioGral { get; set; }
        public int CdtsAcum { get; set; }
        public int CdtsPlan { get; set; }
        public int MatCursadas { get; set; }
        public int MatAprobadas { get; set; }
        public double AvanceCdts { get; set; }
    }
}
