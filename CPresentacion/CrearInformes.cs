
using ConsultorioPsicopedagogico.CLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.tool.xml;
using PdfSharp.Pdf;
using TheArtOfDev.HtmlRenderer.PdfSharp;


namespace ConsultorioPsicopedagogico.CPresentacion
{
    public partial class CrearInformes : Form
    {
        private void CrearInformes_Load(object sender, EventArgs e)
        {
            dtp_Fecha.Value = DateTime.Now;
        }
        public CrearInformes()
        {
            InitializeComponent();
        }

        private void btn_DescargarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(lbl_DNI.Text, out int dni))
                {
                    MessageBox.Show("Ingrese un DNI válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cargar los datos del informe
                InformeCL informe = new InformeCL();
                if (!informe.CargarInformePorId(dni))
                {
                    MessageBox.Show("No se encontró el informe correspondiente a ese DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener HTML de la plantilla
                string html = Properties.Resources.plantilla.ToString();

                // Reemplazar datos estáticos
                html = html.Replace("@fechaemision", dtp_Fecha.Value.ToString("yyyy-MM-dd"));
                html = html.Replace("@nombre", $"{informe.Concurrente_D.Nombre_D} {informe.Concurrente_D.Apellido_D}");
                html = html.Replace("@edad", CalcularEdad(informe.Concurrente_D.FechaNac_D).ToString());
                html = html.Replace("@dni", informe.Concurrente_D.Dni_D.ToString());
                html = html.Replace("@diagnostico", informe.Concurrente_D.Diagnostico_D);
                html = html.Replace("@institucion", informe.Concurrente_D.Escuela_D);
                html = html.Replace("@grado", $"{informe.Concurrente_D.NivelEscolar_D} / {informe.Concurrente_D.AñoEscolar_D}");
                html = html.Replace("@obrasocial", informe.Concurrente_D.Obrasocial_D);

                // Logo base64 desde Resources
                if (Properties.Resources.MAria_ELena_Quintana != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        Properties.Resources.MAria_ELena_Quintana.Save(ms, ImageFormat.Png);
                        string base64Logo = Convert.ToBase64String(ms.ToArray());
                        string dataUri = $"data:image/png;base64,{base64Logo}";
                        html = html.Replace("@logo", dataUri);
                    }
                }
                else
                {
                    html = html.Replace("@logo", "");
                }

                // Armar las secciones dinámicas de áreas
                string secciones = "";
                foreach (var area in informe.InformeAreas_D)
                {
                    secciones += $"<div class='seccion'><h3>{area.Area_D.Nombre_Area_D}</h3><p>{area.Texto_Area_D}</p></div>";
                }
                html = html.Replace("@areasdinamicas", secciones);

                // Guardar PDF
                SaveFileDialog saveFile = new SaveFileDialog
                {
                    FileName = $"Informe_{informe.Concurrente_D.Dni_D}.pdf",
                    Filter = "PDF Files|*.pdf"
                };

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    // Crear documento PDF desde HTML
                    PdfDocument pdf = PdfGenerator.GeneratePdf(html, PdfSharp.PageSize.A4);

                    // Guardar el archivo
                    pdf.Save(saveFile.FileName);

                    MessageBox.Show("PDF generado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al generar el PDF:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Función para calcular edad desde string fecha
        private int CalcularEdad(string fechaNacStr)
        {
            if (DateTime.TryParse(fechaNacStr, out DateTime fechaNac))
            {
                int edad = DateTime.Today.Year - fechaNac.Year;
                if (DateTime.Today < fechaNac.AddYears(edad)) edad--;
                return edad;
            }
            return 0;
        }

        private void btn_select_DNI_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txt_DNI.Text))
            {

                ConcurrentesCL Concurrente1 = new ConcurrentesCL();
                ConcurrentesCL Concurrente2 = new ConcurrentesCL();
                Concurrente2 = Concurrente1.SeleccionarPorDni(Convert.ToInt32(txt_DNI.Text));
                if (Convert.ToInt32(Concurrente2.Dni_C.ToString()) > 0)
                {
                    txt_DNI.Enabled = false;
                    txt_DNI.Text = Concurrente2.Dni_C.ToString();

                }
                else
                {
                    txt_DNI.Enabled = true;
                    txt_DNI.Text = "";
                    MessageBox.Show("No se ha encontrado al concurrente", "ERROR", MessageBoxButtons.OK);
                }

                lbl_DNI.Text = Concurrente2.Dni_C.ToString();
                lbl_NombreConcurrente.Text = Concurrente2.Nombre_C.ToString()+" "+Concurrente2.Apellido_C.ToString();
            }
            else
            {
                MessageBox.Show("Debe ingresar el DNI del concurrente para poder buscarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_BuscarArea_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_DNI.Text))
            {

                ConcurrentesCL Concurrente1 = new ConcurrentesCL();
                ConcurrentesCL Concurrente2 = new ConcurrentesCL();
                Concurrente2 = Concurrente1.SeleccionarPorDni(Convert.ToInt32(txt_DNI.Text));
                if (Convert.ToInt32(Concurrente2.Dni_C.ToString()) > 0)
                {
                    txt_DNI.Enabled = false;
                    txt_DNI.Text = Concurrente2.Dni_C.ToString();

                }
                else
                {
                    txt_DNI.Enabled = true;
                    txt_DNI.Text = "";
                    MessageBox.Show("No se ha encontrado al concurrente", "ERROR", MessageBoxButtons.OK);
                }

                lbl_DNI.Text = Concurrente2.Dni_C.ToString();
            }
            else
            {
                MessageBox.Show("Debe ingresar el DNI del concurrente para poder buscarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}           

      
      


