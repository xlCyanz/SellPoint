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

namespace Capa_de_presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarEntidades();
        }
        private void MostrarEntidades()
        {
            ServicioEntidad objeto = new ServicioEntidad();
            dataGridView1.DataSource = objeto.Mostrar();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServicioEntidad objeto = new ServicioEntidad();
            objeto.Agregar("Buenas", "Manza", "Barrio", "232323", "23929323", 1, 2, "Johan", "johan27", "Hola", DateTime.Now);
            MostrarEntidades();
        }
    }
}
