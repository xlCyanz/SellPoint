using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_de_negocio;

namespace Capa_de_presentacion.EntidadFormScreens
{
    public partial class AddEntity : Form
    {
        public AddEntity()
        {
            InitializeComponent();

            //comboBox1.SelectedIndex = 0;
            //comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 1;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 2;
            comboBox6.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            Console.WriteLine(userName);

            string password = textBox2.Text;
            Console.WriteLine(password);

            string descripcion = textBox3.Text;
            Console.WriteLine(descripcion);

            string rol = comboBox5.Text;
            Console.WriteLine(rol);

            string tipoDocumento = comboBox4.Text;
            Console.WriteLine(tipoDocumento);

            string tipoEntidad = comboBox3.Text;
            Console.WriteLine(tipoEntidad);

            string localidad = textBox7.Text;
            Console.WriteLine(localidad);

            string direccion = textBox8.Text;
            Console.WriteLine(direccion);

            string telefono = textBox9.Text;
            Console.WriteLine(telefono);

            string comentario = textBox12.Text;
            Console.WriteLine(comentario);

            string tiktokUrl = textBox14.Text;
            Console.WriteLine(tiktokUrl);

            string twitterUrl = textBox15.Text;
            Console.WriteLine(twitterUrl);

            string instagramUrl = textBox16.Text;
            Console.WriteLine(instagramUrl);

            string facebookUrl = textBox17.Text;
            Console.WriteLine(facebookUrl);

            string paginaWebUrl = textBox18.Text;
            Console.WriteLine(paginaWebUrl);

            string relacionIdGrupoEntidad = comboBox1.Text;
            Console.WriteLine(relacionIdGrupoEntidad);

            string relacionIdTipoEntidad = comboBox2.Text;
            Console.WriteLine(relacionIdTipoEntidad);
        }

        private void AddEntity_Load(object sender, EventArgs e)
        {
           ServicioEntidad servicioEntidad = new ServicioEntidad();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
