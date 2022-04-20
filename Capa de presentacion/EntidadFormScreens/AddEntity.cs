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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            Console.Write(userName);

            string password = textBox2.Text;
            Console.Write(password);

            string descripcion = textBox3.Text;
            Console.Write(descripcion);

            string rol = textBox4.Text;
            Console.Write(rol);

            string tipoDocumento = textBox5.Text;
            Console.Write(tipoDocumento);

            string tipoEntidad = textBox6.Text;
            Console.Write(tipoEntidad);

            string localidad = textBox7.Text;
            Console.Write(localidad);

            string direccion = textBox8.Text;
            Console.Write(direccion);

            string telefono = textBox9.Text;
            Console.Write(telefono);

            string comentario = textBox12.Text;
            Console.Write(comentario);

            string tiktokUrl = textBox14.Text;
            Console.Write(tiktokUrl);

            string twitterUrl = textBox15.Text;
            Console.Write(twitterUrl);

            string instagramUrl = textBox16.Text;
            Console.Write(instagramUrl);

            string facebookUrl = textBox17.Text;
            Console.Write(facebookUrl);

            string paginaWebUrl = textBox18.Text;
            Console.Write(paginaWebUrl);
        }

        private void AddEntity_Load(object sender, EventArgs e)
        {
           ServicioEntidad servicioEntidad = new ServicioEntidad();
            

        }
    }
}
