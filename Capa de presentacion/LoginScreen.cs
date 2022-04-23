using System;
using System.Windows.Forms;

using Capa_de_negocio;

namespace Capa_de_presentacion
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if(username == "" || password == "")
            {
                string box_msg = "Rellena todos los campos necesarios.";
                string box_title = "Hubo un error";

                MessageBox.Show(box_msg, box_title);
                return;
            }

            ServicioEntidad servicio = new ServicioEntidad();

            bool logged = servicio.Login(username, password);

            if(!logged)
            {
                string box_msg = "Ha ocurrido un error al intentar verificar los datos, puede deberse a un fallo en la conexion o los datos estan mal, verificalos.";
                string box_title = "Hubo un error";

                MessageBox.Show(box_msg, box_title);
                return;
            }

            DashboardScreen screen = new DashboardScreen();
            this.Hide();
            screen.ShowDialog();
            this.Close();
        }
    }
}
