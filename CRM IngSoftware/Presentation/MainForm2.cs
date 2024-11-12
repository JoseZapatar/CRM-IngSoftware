using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_IngSoftware.Presentation
{
    public partial class MainForm2 : Form
    {
        public MainForm2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=sql3.freesqldatabase.com;Database=sql3736675;User Id=sql3736675;Password=HMNnvBQYSN;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            AgregarTareaForm agregarTareaForm = new AgregarTareaForm(connection);
            agregarTareaForm.ShowDialog();
        }

        private void btnAgregarEvento_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=sql3.freesqldatabase.com;Database=sql3736675;User Id=sql3736675;Password=HMNnvBQYSN;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            AgregarEventoForm agregarEventoForm = new AgregarEventoForm(connection);
            agregarEventoForm.ShowDialog();
        }

        private void btnAgregarOportunidad_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=sql3.freesqldatabase.com;Database=sql3736675;User Id=sql3736675;Password=HMNnvBQYSN;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            AgregarOportunidadForm agregarOportunidadForm = new AgregarOportunidadForm(connection);
            agregarOportunidadForm.ShowDialog();
        }
    }
}
