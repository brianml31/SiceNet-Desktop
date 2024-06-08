using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Net.Http;
using System.Net;
using Modelos;
using Datos;

namespace GUI
{
    public partial class frmLogin : MaterialForm
    {

        CookieContainer cookieContainer;
        HttpClientHandler handler;
        HttpClient cliente;

        public frmLogin()
        {
            InitializeComponent();


            //Aplicar el diseño de material desing al formulario
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightGreen200, TextShade.WHITE);

            //Iniciar el cliente 
            cookieContainer = new CookieContainer();
            handler = new HttpClientHandler
            {
                CookieContainer = cookieContainer,
                AllowAutoRedirect = true
            };
            cliente = new HttpClient(handler);
            cliente.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");

        }


        private async void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (cliente != null && cookieContainer != null)
            {
                Alumno alumno = new Alumno(txtNoControl.Text, txtContrasena.Text);
                if (await new DAOAlumno().getInicioSesion(cliente, cookieContainer, alumno))
                {
                    //frmInfoAlumno frminfoalumno = new frmInfoAlumno(cliente, cookieContainer);
                    //frminfoalumno.Show();
                    frmInicio frminicio = new frmInicio(cliente, cookieContainer);
                    frminicio.Show();
                    this.Hide();
                }
            }
        }


    }
}
