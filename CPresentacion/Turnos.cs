﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultorioPsicopedagogico.CLogica;

namespace ConsultorioPsicopedagogico.CPresentacion
{
    public partial class Turnos : Form
    {
        public Turnos()
        {
            InitializeComponent();
        }
<<<<<<< Updated upstream
        CLogica.ConcurrentesCL con = new CLogica.ConcurrentesCL();
        
        
=======

        private void volver_btn_Click(object sender, EventArgs e)
        {
            CPresentacion.Menu menu = new CPresentacion.Menu();
            menu.Show();
            this.Hide();

        }
>>>>>>> Stashed changes
    }
}
