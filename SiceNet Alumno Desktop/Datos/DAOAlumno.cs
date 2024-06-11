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
