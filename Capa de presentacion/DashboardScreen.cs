using System;
using System.Windows.Forms;

using Capa_de_presentacion.EntidadFormScreens;
using Capa_de_presentacion.GrupoEntidadScreens;
using Capa_de_presentacion.TipoEntidadScreens;

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
            this.toolStripStatusLabel.Text = "Usuario Conectado";
        }

        private void entidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEntidad screen = new FormEntidad();
            screen.MdiParent = this;
            screen.Show();
        }

        private void gruposEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGrupoEntidad screen = new FormGrupoEntidad();
            screen.MdiParent = this;
            screen.Show();
        }

        private void tiposEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTipoEntidad screen = new FormTipoEntidad();
            screen.MdiParent = this;
            screen.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginScreen screen = new LoginScreen();
            this.Hide();
            screen.ShowDialog();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs screen = new AboutUs();
            this.Hide();
            screen.ShowDialog();
            this.Close();
        }
    }
}
