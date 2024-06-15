using Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class JsonDeserializer
    {
        //Deserializado por el paquete nuget (Newtonsoft.Json )

        public AccesoLogin deserializarJsonAccesoLogin(string json)
        {
            return JsonConvert.DeserializeObject<AccesoLogin>(json);
        }

        public AlumnoAcademico deserializarJsonInfoAlumno(string json)
        {
            return JsonConvert.DeserializeObject<AlumnoAcademico>(json);
        }

        public List<CalificacionesFinales> deserializarJsonCalifFinales(string json)
        {
            return JsonConvert.DeserializeObject<List<CalificacionesFinales>>(json);
        }

        public KardexConPromedio deserializarJsonKardex(string json)
        {
            return JsonConvert.DeserializeObject<KardexConPromedio>(json);
        }
    }
}
