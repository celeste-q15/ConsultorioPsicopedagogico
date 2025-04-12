using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultorioPsicopedagogico.CPresentacion;
using FluentValidation;
using FluentValidation.Results;
using Org.BouncyCastle.Crypto.Engines;

namespace ConsultorioPsicopedagogico
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private const string MatriculaValida = "celeste";
        private const string ContraseñaValida = "123456";

        private void txt_Mat_TextChanged(object sender, EventArgs e)
        {
            if (txt_Mat.Text == "")
            {
                txt_Mat.Text = "";
                txt_Mat.ForeColor = Color.DimGray;
            }
        }

        private void txt_Contraseña_TextChanged(object sender, EventArgs e)
        {
            if (txt_Contraseña.Text == "")
            {
                txt_Contraseña.Text = "";
                txt_Contraseña.ForeColor = Color.DimGray;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string  Matricula = txt_Mat.Text;
            string Contraseña = txt_Contraseña.Text;

            Login login = new Login();
            LoginValidation Validacion = new LoginValidation();

            ValidationResult result = Validacion.Validate(login);

            if (string.IsNullOrWhiteSpace(Matricula))
            {
                MessageBox.Show("El campo de usuario no puede estar vacío.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(Contraseña))
            {
                MessageBox.Show("El campo de contraseña no puede estar vacío.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Matricula != MatriculaValida || Contraseña != ContraseñaValida)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Contraseña.Text = "";
                txt_Mat.Text = "";
                return;
            }

            MessageBox.Show("Ingreso Exitoso!!", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CPresentacion.Menu menu = new CPresentacion.Menu();
            menu.Show();
            this.Hide();

        }

        private void lblmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public class LoginValidation : AbstractValidator<Login>
        {
            public LoginValidation()
            {
                RuleFor(x => x.txt_Mat.Text)
                    .NotEmpty().WithMessage("El campo no puede estar vacío")
                    .Length(5, 10).WithMessage("El campo debe tener entre 5 y 10 caracteres");
                RuleFor(x => x.txt_Contraseña.Text)
                    .NotEmpty().WithMessage("El campo no puede estar vacío")
                    .Length(6, 12).WithMessage("El campo debe tener entre 6 y 12 caracteres");
            }
        }
            

    }
}
