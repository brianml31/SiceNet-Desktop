using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Net.Http;
using System.Net;
using Modelos;
using Datos;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.Collections.Generic;

namespace GUI
{
    public partial class frmInicio : MaterialForm
    {

        CookieContainer cookieContainer;
        HttpClient cliente;

        public frmInicio()
        {
            InitializeComponent();


            //Aplicar el diseño de material desing al formulario
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green700, TextShade.WHITE);
        }

        public frmInicio(HttpClient cliente, CookieContainer cookieContainer) : this()
        {
            try
            {
                this.cliente = cliente;
                this.cookieContainer = cookieContainer;
                InitializeAsync();
            }
            catch
            {
            }
        }

        //Cargar los datos de la informacion del alumno
        private async void InitializeAsync()
        {
            try
            {
                if (this.cliente != null && this.cookieContainer != null)
                {
                    AlumnoAcademico alumnoAcademico = await new DAOAlumno().getAlumnoAcademico(cliente, cookieContainer);
                    if (alumnoAcademico != null) {
                        lblNombreAlumno.Text = alumnoAcademico.nombre;
                        lblNoControl.Text = alumnoAcademico.matricula;
                        lblFechaHora.Text = alumnoAcademico.fechaReins;
                        lblEspecialidad.Text = alumnoAcademico.especialidad;
                        lblCreditosReunidos.Text = alumnoAcademico.cdtosAcumulados.ToString();
                        lblCreditosActuales.Text = alumnoAcademico.cdtosActuales.ToString();
                        lblSemestreActual.Text = alumnoAcademico.semActual.ToString();
                        lblCarrera.Text = alumnoAcademico.carrera;
                        DatosConexion.nombreAlumno = alumnoAcademico.nombre;
                        DatosConexion.noControl = alumnoAcademico.matricula;
                        DatosConexion.carrera = alumnoAcademico.carrera;
                        DatosConexion.semestreActual = alumnoAcademico.semActual.ToString();

                    }
                }
            }
            catch (Exception ex)
            {
               
            }
        }

        private async void TabsControlDrawer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tabSeleccionada = TabsControlDrawer.SelectedIndex;
            switch (tabSeleccionada)
            {  
                //Si se selecciona la tab de Kardex llena la tabla que mostrara el kardex del alumno
                case 1:
                    KardexConPromedio kardexconpromedio = await new DAOAlumno().getAllKardexConPromedio(cliente, cookieContainer);
                    if (kardexconpromedio != null)
                    {
                        lblPromedioGeneral.Text = kardexconpromedio.Promedio.PromedioGral.ToString();
                        lblCreditosAprobados.Text = kardexconpromedio.Promedio.CdtsAcum +" (" +kardexconpromedio.Promedio.AvanceCdts +" %) de un total de "+ kardexconpromedio.Promedio.CdtsPlan;
                        lblMateriasCursadas.Text = kardexconpromedio.Promedio.MatCursadas.ToString();
                        ListViewKardex.Items.Clear();
                        foreach (var elementoKardex in kardexconpromedio.lstKardex)
                        {
                            ListViewItem listViewItem = new ListViewItem();
                            listViewItem.SubItems[0].Text = elementoKardex.ClvMat;
                            listViewItem.SubItems.Add(elementoKardex.ClvOfiMat);
                            listViewItem.SubItems.Add(elementoKardex.Materia);
                            listViewItem.SubItems.Add(elementoKardex.Cdts.ToString());
                            listViewItem.SubItems.Add(elementoKardex.Calif.ToString());
                            listViewItem.SubItems.Add(elementoKardex.Acred);
                            listViewItem.SubItems.Add((elementoKardex.S1 == null && elementoKardex.P1 == null && elementoKardex.A1 == null) ? "" : "( " + elementoKardex.S1 + " / " + elementoKardex.P1 + " / " + elementoKardex.A1 + " )");
                            listViewItem.SubItems.Add((elementoKardex.S2 == null && elementoKardex.P2 == null && elementoKardex.A2 == null) ? "" : "( " + elementoKardex.S2 + " / " + elementoKardex.P2 + " / " + elementoKardex.A2 + " )");
                            listViewItem.SubItems.Add((elementoKardex.FecEsp ==  null) ? "" : elementoKardex.FecEsp);
                            ListViewKardex.Items.Add(listViewItem);
                        }
                    }
                    break;
                case 2:
                    List<CalificacionesFinales> listCalifFinales = await new DAOAlumno().getCalifFinales(cliente, cookieContainer);
                    if (listCalifFinales != null || listCalifFinales.Count != 0)
                    {
  
                        
                        foreach (var elementoCalifFinales in listCalifFinales)
                        {

                            dataGridViewCalifFinales.Rows.Add(elementoCalifFinales.materia, elementoCalifFinales.calif.ToString(), elementoCalifFinales.acred);
                        }
                        
                    }
                    break;
                case 3:
                    if ("finalizada".Equals(await new DAOAlumno().getCerrarSesion(cliente, cookieContainer))) {
                        frmLogin frmlogin = new frmLogin();
                        frmlogin.Show();
                        this.Hide();
                    }
                    break;
                default:
                    break;
            }
        }

        private async void btnGenerarKardex_Click(object sender, EventArgs e)
        {
            KardexConPromedio kardexconpromedio = await new DAOAlumno().getAllKardexConPromedio(cliente, cookieContainer);
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));
            string PaginaHTML_Texto = Properties.Resources.Plantilla_kardex.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NOMBRE_ALUMNO", DatosConexion.nombreAlumno);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NO_CONTROL", DatosConexion.noControl);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CARRERA", DatosConexion.carrera);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@SEMESTRE_ACTUAL", DatosConexion.semestreActual);
            if (kardexconpromedio != null) {
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@PROMEDIO_GENERAL", kardexconpromedio.Promedio.PromedioGral.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CREDITOS_APROBADOS", kardexconpromedio.Promedio.CdtsAcum + " (" + kardexconpromedio.Promedio.AvanceCdts + " %) de un total de " + kardexconpromedio.Promedio.CdtsPlan);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@MATERIAS_CURSADAS", kardexconpromedio.Promedio.MatCursadas.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@MATERIAS_APROBADAS", kardexconpromedio.Promedio.MatAprobadas.ToString());
                string filas = string.Empty;
                foreach (var elementoKardex in kardexconpromedio.lstKardex)
                {
                    filas += "<tr>";
                    filas += "<td style=\"border: 1px solid #ddd;\">" + elementoKardex.ClvMat + "</td>";
                    filas += "<td style=\"border: 1px solid #ddd;\">" + elementoKardex.ClvOfiMat + "</td>";
                    filas += "<td style=\"border: 1px solid #ddd;\">" + elementoKardex.Materia + "</td>";
                    filas += "<td style=\"border: 1px solid #ddd;\">" + elementoKardex.Cdts + "</td>";
                    filas += "<td style=\"border: 1px solid #ddd;\">" + elementoKardex.Calif + "</td>";
                    filas += "<td style=\"border: 1px solid #ddd;\">" + elementoKardex.Acred + "</td>";
                    filas += "<td style=\"border: 1px solid #ddd;\">" + (elementoKardex.S1==null ? "" : elementoKardex.S1) + "</td>";
                    filas += "<td style=\"border: 1px solid #ddd;\">" + (elementoKardex.P1 == null ? "" : elementoKardex.P1) + "</td>";
                    filas += "<td style=\"border: 1px solid #ddd;\">" + (elementoKardex.A1 == null ? "" : elementoKardex.A1) + "</td>";
                    filas += "<td style=\"border: 1px solid #ddd;\">" + (elementoKardex.S2 == null ? "" : elementoKardex.S2) + "</td>";
                    filas += "<td style=\"border: 1px solid #ddd;\">" + (elementoKardex.P2 == null ? "" : elementoKardex.P2) + "</td>";
                    filas += "<td style=\"border: 1px solid #ddd;\">" + (elementoKardex.A2 == null ? "" : elementoKardex.A2) + "</td>";
                    filas += "<td style=\"border: 1px solid #ddd;\">" + (elementoKardex.FecEsp == null ? "" : elementoKardex.FecEsp.Split('|')[0]) + "</td>";
                    filas += "<td style=\"border: 1px solid #ddd;\">" + (elementoKardex.FecEsp == null ? "" : elementoKardex.FecEsp.Split('|')[1]) + "</td>";
                    filas += "<td style=\"border: 1px solid #ddd;\">" + (elementoKardex.FecEsp == null ? "" : elementoKardex.FecEsp.Split('|')[2]) + "</td>";
                    filas += "</tr>";
                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            }
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Rectangle customSize = new Rectangle(1000, 1300);
                    Document pdfDoc = new Document(customSize, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logo_itsur, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(80, 80);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);
                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }
                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }
    }
}
