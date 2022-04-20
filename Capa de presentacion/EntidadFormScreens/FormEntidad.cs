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
    public partial class FormEntidad : Form
    {
        public FormEntidad()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarEntidades();
        }
        private void MostrarEntidades()
        {
            ServicioEntidad servicio = new ServicioEntidad();
            dataGridView1.DataSource = servicio.Mostrar();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string value = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
            string column = dataGridView1.Columns[e.ColumnIndex].Name;
            int idEntidad = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
            Console.WriteLine(value);
            Console.WriteLine(column);
            Console.WriteLine(idEntidad);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idEntidad = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            ServicioEntidad servicio = new ServicioEntidad();
            servicio.Eliminar(idEntidad);
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DashboardScreen dashboard = new DashboardScreen();
            dashboard.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddEntity addEntity = new AddEntity();
            addEntity.Show();
            this.Hide();
        }
    }
}
