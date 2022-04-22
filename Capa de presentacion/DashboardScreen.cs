using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_de_presentacion.EntidadFormScreens;

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
            FormEntidad screen = new FormEntidad();
            this.Hide();
            screen.ShowDialog();
            this.Close();
        }

        private void gruposEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tiposEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
