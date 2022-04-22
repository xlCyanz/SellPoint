using System;
using System.Windows.Forms;

namespace Capa_de_presentacion
{
    public partial class SplashScreen : Form
    {
        Timer tmr;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            tmr.Interval = 3000;
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            tmr.Stop();
            LoginScreen screen = new LoginScreen();
            this.Hide();
            screen.ShowDialog();
            this.Close();
        }
    }
}
