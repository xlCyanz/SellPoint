﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_de_presentacion
{
    public partial class DashboardScreen : Form
    {
        public DashboardScreen()
        {
            InitializeComponent();
        }

        private void DashboardScreen_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = DateTime.Today.ToString();
        }

        private void entidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEntidad formEntidad = new FormEntidad();
            formEntidad.Show();
            this.Hide();
        }
    }
}
