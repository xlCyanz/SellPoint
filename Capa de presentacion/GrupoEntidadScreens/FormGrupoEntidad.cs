using System;
using System.Windows.Forms;

using Capa_de_negocio;

namespace Capa_de_presentacion.GrupoEntidadScreens
{
    public partial class FormGrupoEntidad : Form
    {
        public FormGrupoEntidad()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            string id = Convert.ToString(dataGridView1[0, rowIndex].Value);
            string NoEliminable = Convert.ToString(dataGridView1[4, rowIndex].Value);

            if (NoEliminable == "False")
            {
                string box_msg = "No se puede eliminar este registro.";
                string box_title = "Hubo un error";

                MessageBox.Show(box_msg, box_title);
                return;
            }

            ServicioGrupoEntidad servicioGrupoEntidad = new ServicioGrupoEntidad();
            bool deleted = servicioGrupoEntidad.Eliminar(id);

            if(deleted)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            }
             else
            {
                string box_msg = "Ha ocurrido un error esto puede deberse a un fallo en la conexion o este registro no existe.";
                string box_title = "Hubo un error";

                MessageBox.Show(box_msg, box_title);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddGrupoEntidad screen = new AddGrupoEntidad();
            screen.ShowDialog();
        }

        private void MostrarEntidades()
        {
            ServicioGrupoEntidad servicio = new ServicioGrupoEntidad();
            dataGridView1.DataSource = servicio.Mostrar();
        }

        private void FormGrupoEntidad_Load(object sender, EventArgs e)
        {
            MostrarEntidades();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string value = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
            string column = dataGridView1.Columns[e.ColumnIndex].Name;
            string id = Convert.ToString(dataGridView1[0, e.RowIndex].Value);

            ServicioGrupoEntidad servicioGrupoEntidad = new ServicioGrupoEntidad();
            bool updated = servicioGrupoEntidad.Actualizar(id, column, value);

            if (!updated)
            {
                string box_msg = "Ha ocurrido un error esto puede deberse a un fallo en la conexion o este campo no se puede editar.";
                string box_title = "Hubo un error";

                MessageBox.Show(box_msg, box_title);
            }

            MostrarEntidades();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarEntidades();
        }
    }
}
