using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DAOAlumno
    {
        public async Task<bool> getInicioSesion(HttpClient cliente, CookieContainer cookieContainer, Alumno alumno)
        {
            string uri = DatosConexion.urlBase + "/ws/wsalumnos.asmx/accesoLogin?strMatricula=" + alumno.getNoControl() + "&strContrasenia=" + alumno.getPassword() + "&tipoUsuario=ALUMNO";
            HttpResponseMessage respuesta = await cliente.GetAsync(uri);
            if (respuesta.IsSuccessStatusCode)
            {
                string cuerpoRespuesta = await respuesta.Content.ReadAsStringAsync();
                XmlStringDeserializer deserializer = new XmlStringDeserializer();
                XmlString result = deserializer.Deserialize(cuerpoRespuesta);
                if (result.respuestaJson!=null)
                {
                    JsonDeserializer deserializerJson = new JsonDeserializer();
                    AccesoLogin userStatus = deserializerJson.deserializarJsonAccesoLogin(result.respuestaJson);
                    return userStatus.acceso;
                }
                else {
                    return false; 
                }
            }else {
                return false;
            }
        }

        public async Task<AlumnoAcademico> getAlumnoAcademico(HttpClient cliente, CookieContainer cookieContainer)
        {
            string uri = DatosConexion.urlBase + "/ws/wsalumnos.asmx/getAlumnoAcademico?";
            HttpResponseMessage respuesta = await cliente.GetAsync(uri);
            if (respuesta.IsSuccessStatusCode)
            {
                string cuerpoRespuesta = await respuesta.Content.ReadAsStringAsync();
                XmlStringDeserializer deserializer = new XmlStringDeserializer();
                XmlString result = deserializer.Deserialize(cuerpoRespuesta);
                if (result.respuestaJson!=null)
                {
                    JsonDeserializer deserializerJson = new JsonDeserializer();
                    AlumnoAcademico alumnoacademico = deserializerJson.deserializarJsonInfoAlumno(result.respuestaJson);
                    return alumnoacademico;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<List<CalificacionesFinales>> getCalifFinales(HttpClient cliente, CookieContainer cookieContainer)
        {
            string uri = DatosConexion.urlBase + "/ws/wsalumnos.asmx/getAllCalifFinalByAlumnos?bytModEducativo=1";
            HttpResponseMessage respuesta = await cliente.GetAsync(uri);
            if (respuesta.IsSuccessStatusCode)
            {
                string cuerpoRespuesta = await respuesta.Content.ReadAsStringAsync();
                XmlStringDeserializer deserializer = new XmlStringDeserializer();
                XmlString result = deserializer.Deserialize(cuerpoRespuesta);
                if (result.respuestaJson == null)
                {
                    JsonDeserializer deserializerJson = new JsonDeserializer();
                    String prueba = "[ { \"calif\": 92, \"acred\": \"Ordinario\", \"grupo\": \"TI1A\", \"materia\": \"PROGRAMACION WEB II\", \"Observaciones\": \"\" }, { \"calif\": 83, \"acred\": \"Regularización\", \"grupo\": \"2S7A\", \"materia\": \"CONMUTACION Y ENRUTAMIENTO DE REDES DE DATOS\", \"Observaciones\": \"\" }, { \"calif\": 94, \"acred\": \"Ordinario\", \"grupo\": \"TI4A\", \"materia\": \"INTERNET DE LAS COSAS\", \"Observaciones\": \"\" }, { \"calif\": 95, \"acred\": \"Ordinario\", \"grupo\": \"3S8A\", \"materia\": \"TALLER DE INVESTIGACION II\", \"Observaciones\": \"\" }, { \"calif\": 97, \"acred\": \"Ordinario\", \"grupo\": \"7S6A\", \"materia\": \"ACTIVIDAD COMPLEMENTARIA V\", \"Observaciones\": \"\" }, { \"calif\": 99, \"acred\": \"Ordinario\", \"grupo\": \"TI5A\", \"materia\": \"PROGRAMACION MOVIL II\", \"Observaciones\": \"\" }, { \"calif\": 86, \"acred\": \"Ordinario\", \"grupo\": \"TI6A\", \"materia\": \"FORMULACION Y EVALUACION DE PROYECTOS DE INVERSION\", \"Observaciones\": \"\" } ]";
                    List<CalificacionesFinales> calificacionesFinales = calificacionesFinales = deserializerJson.deserializarJsonCalifFinales(/*result.respuestaJson*/prueba);
                    return calificacionesFinales;
                }
                else
                {
                    return new List<CalificacionesFinales>();
                }
            }
            else
            {
                return new List<CalificacionesFinales>();
            }
        }


        public async Task<KardexConPromedio> getAllKardexConPromedio(HttpClient cliente, CookieContainer cookieContainer)
        {
            string uri = DatosConexion.urlBase + "/ws/wsalumnos.asmx/getAllKardexConPromedioByAlumno?aluLineamiento=1";
            HttpResponseMessage respuesta = await cliente.GetAsync(uri);
            if (respuesta.IsSuccessStatusCode)
            {
                string cuerpoRespuesta = await respuesta.Content.ReadAsStringAsync();
                XmlStringDeserializer deserializer = new XmlStringDeserializer();
                XmlString result = deserializer.Deserialize(cuerpoRespuesta);
                if (result.respuestaJson != null)
                {
                    JsonDeserializer deserializerJson = new JsonDeserializer();
                    KardexConPromedio kardexconpromedio = deserializerJson.deserializarJsonKardex(result.respuestaJson);
                    return kardexconpromedio;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<string> getCerrarSesion(HttpClient cliente, CookieContainer cookieContainer)
        {
            string uri = DatosConexion.urlBase + "/ws/wsalumnos.asmx/cerrarSesion?";
            HttpResponseMessage respuesta = await cliente.GetAsync(uri);
            if (respuesta.IsSuccessStatusCode)
            {
                string cuerpoRespuesta = await respuesta.Content.ReadAsStringAsync();
                XmlStringDeserializer deserializer = new XmlStringDeserializer();
                XmlString result = deserializer.Deserialize(cuerpoRespuesta);
                if (result.respuestaJson != null)
                {
                    return result.respuestaJson;
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }
    }
}
