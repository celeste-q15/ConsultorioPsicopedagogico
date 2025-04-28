using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultorioPsicopedagogico.CLogica;
using System.Drawing.Text;

namespace ConsultorioPsicopedagogico.CPresentacion
{
    public partial class NuevoConcurrente : Form
    {
        public NuevoConcurrente()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
      
            var validator = new ConcurrenteValidation();
            ValidationResult results = validator.Validate(this);

            if (!results.IsValid)
            {
                foreach (var error in results.Errors)
                {
                    MessageBox.Show(error.ErrorMessage, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                // Crear el objeto ConcurrentesCL con los datos del formulario
                ConcurrentesCL concurrente = PasarLogica();
                TutorCL tutor = PasarLogicaTutor();

                try
                {
                    // Guardar los datos en la base de datos
                    tutor.GuardarOModificarTutor(tutor, true);
                    concurrente.CargarEnSql(concurrente);
                    
                    LimpiarCampos();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public class ConcurrenteValidation : AbstractValidator<NuevoConcurrente>
        {
            public ConcurrenteValidation()
            {
                RuleFor(x => x.txt_dni.Text)
                    .NotEmpty().WithMessage("El DNI es obligatorio.")
                    .Matches(@"^\d{8}$").WithMessage("El DNI debe tener exactamente 8 dígitos.\nNo ingresar puntos.");
                RuleFor(x => x.txt_nom.Text)
                    .NotEmpty().WithMessage("El nombre es obligatorio.");
                RuleFor(x => x.txt_ape.Text)
                    .NotEmpty().WithMessage("El apellido es obligatorio.");
                RuleFor(x => x.date_naci.Value)
                    .NotEmpty().WithMessage("La fecha de nacimiento es obligatoria.")
                    .LessThan(DateTime.Now.Date).WithMessage("La fecha de nacimiento debe ser anterior a la fecha actual.");
                RuleFor(x => x.txt_diagnostico.Text)
                    .NotEmpty().WithMessage("El diagnostico es obligatorio.");
                RuleFor(x => x.txt_domicilio.Text)
                    .NotEmpty().WithMessage("La dirección es obligatoria.");
                RuleFor(x => x.txt_colegio.Text)
                    .NotEmpty().WithMessage("El colegio es obligatorio.");
                RuleFor(x => x.txt_anio.Text)
                    .NotEmpty().WithMessage("El año es obligatorio.")
                    .Matches(@"^[1-6]$").WithMessage("El año debe ser un número entre 1 y 6.");
                RuleFor(x => x.txt_nivel.Text)
                    .NotEmpty().WithMessage("El nivel es obligatorio.");               
                RuleFor(x => x.txt_tutor.Text)
                    .NotEmpty().WithMessage("El nombre del tutor es obligatorio.");
                RuleFor(x => x.txt_contTutor.Text)
                    .NotEmpty().WithMessage("El contacto del tutor es obligatorio.")
                    .Matches(@"^\d{10}$").WithMessage("El contacto del tutor debe tener exactamente 10 dígitos y solo contener números.");
                RuleFor(x => x.txt_obs.Text)
                    .NotEmpty().WithMessage("Ingresar no si no cuenta con obra.");
                RuleFor(x => x.txt_DniTutor.Text)
                    .NotEmpty().WithMessage("El DNI del tutor es obligatorio.")
                    .Matches(@"^\d{8}$").WithMessage("DNI Incorrecto.\nNo ingresar puntos.");
                RuleFor(x => x.txt_Mail.Text)
                    .NotEmpty().WithMessage("El email del tutor es obligatorio.")
                    .EmailAddress().WithMessage("El formato del email es incorrecto.");
                RuleFor(x => x.txt_Parent.Text)
                    .NotEmpty().WithMessage("El parentesco del tutor es obligatorio.");


            }
        }

<<<<<<< Updated upstream
      private ConcurrentesCL PasarLogica()
        {
            ConcurrentesCL concurrentes = new ConcurrentesCL();
            concurrentes.Dni_C = Convert.ToInt32(txt_dni.Text);
            concurrentes.Nombre_C = txt_nom.Text;
            concurrentes.Apellido_C = txt_ape.Text;
            concurrentes.FechaNac_C = date_naci.Value.ToString("yyyy-MM-dd");
            concurrentes.Diagnostico_C = txt_diagnostico.Text;
            concurrentes.Domicilio_C = txt_domicilio.Text;
            concurrentes.Escuela_C = txt_colegio.Text;
            concurrentes.AñoEscolar_C = Convert.ToInt32(txt_anio.Text);
            concurrentes.NivelEscolar_C = txt_nivel.Text;
            concurrentes.Obrasocial_C = txt_obs.Text;
            concurrentes.DniTutor_C1 = Convert.ToInt32(txt_DniTutor.Text);

            return concurrentes;
        }

        private TutorCL PasarLogicaTutor()
        {
            TutorCL tutor = new TutorCL();
            tutor.DniTutor_C = Convert.ToInt32(txt_dni.Text);
            tutor.NombreTutor_C = txt_tutor.Text;
            tutor.ApellidoTutor_C = txt_ape.Text;
            tutor.TelefonoTutor_C = txt_contTutor.Text;
            tutor.EmailTutor_C = txt_Mail.Text;
            tutor.ParentescoTutor_C = txt_Parent.Text;
            return tutor;

        }
        void LimpiarCampos()
        {
            txt_anio.Text = "";
            txt_nom.Text = "";
            txt_ape.Text = "";
            txt_domicilio.Text = "";
            txt_diagnostico.Text = "";
            txt_tutor.Text = "";
            txt_colegio.Text = "";
            txt_dni.Text = "";
            txt_nivel.Text = "";
            txt_contTutor.Text = "";
            txt_obs.Text = "";
            txt_DniTutor.Text = "";
            txt_Parent.Text = "";
            txt_Mail.Text = "";
=======
        private void btn_volver_Click(object sender, EventArgs e)
        {
            CPresentacion.Menu menu = new CPresentacion.Menu();
            menu.Show();
            this.Hide();
>>>>>>> Stashed changes
        }
    }
}


