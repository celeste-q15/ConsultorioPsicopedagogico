﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultorioPsicopedagogico.CPresentacion;

namespace ConsultorioPsicopedagogico.CPresentacion
{
    public partial class Concurrentes : Form
    {
        public Concurrentes()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            CPresentacion.NuevoConcurrente nuevoConcurrente = new CPresentacion.NuevoConcurrente();
            nuevoConcurrente.Show();
            this.Hide();
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {

        private void btn_volver_Click(object sender, EventArgs e)
        {
            CPresentacion.Menu menu = new CPresentacion.Menu();
            menu.Show();
            this.Hide();
        }
    }
}
