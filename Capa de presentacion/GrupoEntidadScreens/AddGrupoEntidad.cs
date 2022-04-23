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

namespace Capa_de_presentacion.GrupoEntidadScreens
{
    public partial class AddGrupoEntidad : Form
    {
        public AddGrupoEntidad()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string descripcion = textBox1.Text;
            string comentario = textBox2.Text;

            string status = comboBox1.Text;
            string eliminableValue = comboBox2.Text;

            bool eliminable;

            if(eliminableValue == "Verdadero")
            {
                eliminable = true;
            } else
            {
                eliminable = false;
            }

            ServicioGrupoEntidad servicioGrupoEntidad = new ServicioGrupoEntidad();
            servicioGrupoEntidad.Agregar(descripcion, comentario, status, eliminable);
            this.Close();
        }
    }
}
