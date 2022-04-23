using System;
using System.Windows.Forms;

using Capa_de_negocio;

namespace Capa_de_presentacion.EntidadFormScreens
{
    public partial class AddEntidad : Form
    {
        public AddEntidad()
        {
            InitializeComponent();
        }

        public void MostrarGruposEntidades()
        {
            ServicioGrupoEntidad servicioGrupoEntidad = new ServicioGrupoEntidad();
            comboBox1.DataSource = servicioGrupoEntidad.Mostrar();
            comboBox1.ValueMember = "IdGrupoEntidad";
            comboBox1.DisplayMember = "Descripcion";
            comboBox1.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Datos
            string username = textBox1.Text;
            string password = textBox2.Text;
            string rol = comboBox5.Text;
            string descripcion = textBox3.Text;
            string direccion = textBox8.Text;
            string localidad = textBox7.Text;
            string telefono = textBox9.Text;
            string tipoDocumento = comboBox4.Text;
            string tipoEntidad = comboBox3.Text;
            string numeroDocumento = textBox5.Text;

            if (username == "" || password == "" || rol == "" || descripcion == "" || direccion == "" || localidad == "" || telefono == "" || tipoDocumento == "" || tipoEntidad == "" || numeroDocumento == "")
            {
                string box_msg = "Rellena todos los campos necesarios de la seccion datos.";
                string box_title = "Hubo un error";

                MessageBox.Show(box_msg, box_title);
                return;
            }

            // Redes Sociales
            string tiktokUrl = textBox14.Text;
            string twitterUrl = textBox15.Text;
            string instagramUrl = textBox16.Text;
            string facebookUrl = textBox17.Text;
            string paginaWebUrl = textBox18.Text;

            // Relaciones

            string relacionIdGrupoEntidad = comboBox1.SelectedValue.ToString();
            string relacionIdTipoEntidad = comboBox2.SelectedValue.ToString();

            if (relacionIdGrupoEntidad == "" || relacionIdTipoEntidad == "")
            {
                string box_msg = "Rellena todos los campos necesarios de la seccion relaciones.";
                string box_title = "Hubo un error";

                MessageBox.Show(box_msg, box_title);
                return;
            }

            // Otros

            string comentario = textBox12.Text;
            string status = comboBox6.Text;
            int limiteCredito = Int32.Parse(textBox4.Text);

            if (limiteCredito < 0)
            {
                string box_msg = "El limite de creditos debe ser superior a cero (0).";
                string box_title = "Hubo un error";

                MessageBox.Show(box_msg, box_title);
                return;
            }

            bool NoEliminable = radioButton1.Checked;

            if (comentario == "" || status == "")
            {
                string box_msg = "Rellena todos los campos necesarios de la seccion otros.";
                string box_title = "Hubo un error";

                MessageBox.Show(box_msg, box_title);
                return;
            }

            ServicioEntidad servicioEntidad = new ServicioEntidad();
            bool added = servicioEntidad.Agregar(descripcion, direccion, localidad, numeroDocumento, telefono, relacionIdGrupoEntidad, relacionIdTipoEntidad, username, password, comentario, status, rol, limiteCredito, tipoEntidad, tipoDocumento, NoEliminable, paginaWebUrl, facebookUrl, instagramUrl, twitterUrl, tiktokUrl);

            if (!added)
            {
                string box_msg = "No se pudo agregar el nuevo registro, verifica los campos y la conexion a los servicios de almacenamiento.";
                string box_title = "Hubo un error";

                MessageBox.Show(box_msg, box_title);
                return;
            };

            this.Close();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string idGrupoEntidad = comboBox1.SelectedValue.ToString();

            ServicioTipoEntidad servicioTipoEntidad = new ServicioTipoEntidad();
            comboBox2.DataSource = servicioTipoEntidad.BuscarPorGrupoEntidad(idGrupoEntidad);
            comboBox2.ValueMember = "IdTipoEntidad";
            comboBox2.DisplayMember = "Descripcion";
            comboBox2.SelectedIndex = -1;
        }

        private void AddEntidad_Load(object sender, EventArgs e)
        {
            comboBox3.SelectedIndex = 1;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 2;
            comboBox6.SelectedIndex = 0;

            textBox4.Text = "0";

            MostrarGruposEntidades();
        }
    }
}
