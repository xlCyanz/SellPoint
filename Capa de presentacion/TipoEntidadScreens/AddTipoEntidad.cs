using System;
using System.Windows.Forms;

using Capa_de_negocio;

namespace Capa_de_presentacion.TipoEntidadScreens
{
    public partial class AddTipoEntidad : Form
    {
        public AddTipoEntidad()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
            MostrarOpcionesGrupoEntidad();
        }

        public void MostrarOpcionesGrupoEntidad()
        {
            ServicioGrupoEntidad servicio = new ServicioGrupoEntidad();
            comboBox3.DataSource = servicio.Mostrar();
            comboBox3.ValueMember = "IdGrupoEntidad";
            comboBox3.DisplayMember = "Descripcion";
            comboBox3.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string descripcion = textBox1.Text;
            string comentario = textBox2.Text;

            if(descripcion == "" || comentario == "")
            {
                string box_msg = "Rellena todos los campos necesarios.";
                string box_title = "Hubo un error";

                MessageBox.Show(box_msg, box_title);
                return;
            }

            string status = comboBox1.Text;
            string eliminableValue = comboBox2.Text;
            string idGrupoEntidad = comboBox3.SelectedValue.ToString();

            bool eliminable;

            if (eliminableValue == "Verdadero")
            {
                eliminable = true;
            }
            else
            {
                eliminable = false;
            }

            ServicioTipoEntidad servicioTipoEntidad = new ServicioTipoEntidad();
            bool added = servicioTipoEntidad.Agregar(descripcion, comentario, idGrupoEntidad, status, eliminable);

            if (added)
            {
                this.Close();
            } else
            {
                string box_msg = "No se ha podido agregar el nuevo tipo entidad.";
                string box_title = "Hubo un error";

                MessageBox.Show(box_msg, box_title);
            }
        }
    }
}
