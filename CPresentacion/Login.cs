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

namespace ConsultorioPsicopedagogico
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private const string MatriculaValida = "1";
        private const string ContraseñaValida = "1";

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

            if (Matricula == MatriculaValida && Contraseña == ContraseñaValida)
            {
                CPresentacion.Menu menu = new CPresentacion.Menu();
                menu.Show();
                this.Hide();
              
            }
            else
            {
                // Credenciales inválidas, mostrar un mensaje de error
                MessageBox.Show("Usuario o contraseña incorrectos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void lblmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
