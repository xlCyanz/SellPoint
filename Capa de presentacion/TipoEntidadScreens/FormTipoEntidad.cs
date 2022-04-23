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

namespace Capa_de_presentacion.TipoEntidadScreens
{
    public partial class FormTipoEntidad : Form
    {
        public FormTipoEntidad()
        {
            InitializeComponent();
        }

        private void FormTipoEntidad_Load(object sender, EventArgs e)
        {
            MostrarEntidades();
        }

        private void MostrarEntidades()
        {
            ServicioTipoEntidad servicio = new ServicioTipoEntidad();
            dataGridView1.DataSource = servicio.Mostrar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarEntidades();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddTipoEntidad screen = new AddTipoEntidad();
            screen.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            string id = Convert.ToString(dataGridView1[0, rowIndex].Value);
            string NoEliminable = Convert.ToString(dataGridView1[5, rowIndex].Value);

            if (NoEliminable == "False")
            {
                string box_msg = "No se puede eliminar este registro.";
                string box_title = "Hubo un error";

                MessageBox.Show(box_msg, box_title);
                return;
            }

            ServicioTipoEntidad servicio = new ServicioTipoEntidad();
            bool deleted = servicio.Eliminar(id);

            if (deleted)
            {
                MostrarEntidades();
            }
            else
            {
                string box_msg = "Ha ocurrido un error esto puede deberse a un fallo en la conexion o este registro no existe.";
                string box_title = "Hubo un error";

                MessageBox.Show(box_msg, box_title);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string value = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
            string column = dataGridView1.Columns[e.ColumnIndex].Name;
            string id = Convert.ToString(dataGridView1[0, e.RowIndex].Value);

            ServicioTipoEntidad servicio = new ServicioTipoEntidad();
            bool updated = servicio.Actualizar(id, column, value);

            if (!updated)
            {
                string box_msg = "Ha ocurrido un error esto puede deberse a un fallo en la conexion o este campo no se puede editar.";
                string box_title = "Hubo un error";

                MessageBox.Show(box_msg, box_title);
            }

            MostrarEntidades();
        }
    }
}
