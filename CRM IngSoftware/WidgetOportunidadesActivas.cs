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

namespace CRM_IngSoftware
{
    public partial class WidgetOportunidades : UserControl
    {
        private DatabaseConnection dbConnection;

        public WidgetOportunidades()
        {
            InitializeComponent();
        }

        private DatabaseConnection DbConnection
        {
            get
            {
                if (dbConnection == null)
                {
                    dbConnection = new DatabaseConnection();
                }
                return dbConnection;
            }
        }

        private void CargarOportunidades()
        {
            listOportunidadesActivas.Items.Clear();
            listOportunidadesCerradas.Items.Clear();

            try
            {
                DbConnection.OpenConnection();

                // Cargar Oportunidades Activas
                string queryActivas = "SELECT Descripcion FROM Oportunidades WHERE Estado = 'Activa'";
                MySqlCommand cmdActivas = new MySqlCommand(queryActivas, DbConnection.GetConnection());
                MySqlDataReader readerActivas = cmdActivas.ExecuteReader();

                while (readerActivas.Read())
                {
                    listOportunidadesActivas.Items.Add(readerActivas["Descripcion"].ToString());
                }
                readerActivas.Close();

                // Cargar Oportunidades Cerradas
                string queryCerradas = "SELECT Descripcion FROM Oportunidades WHERE Estado = 'Cerrada'";
                MySqlCommand cmdCerradas = new MySqlCommand(queryCerradas, DbConnection.GetConnection());
                MySqlDataReader readerCerradas = cmdCerradas.ExecuteReader();

                while (readerCerradas.Read())
                {
                    listOportunidadesCerradas.Items.Add(readerCerradas["Descripcion"].ToString());
                }
                readerCerradas.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar oportunidades: " + ex.Message);
            }
            finally
            {
                DbConnection.CloseConnection();
            }
        }


        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarOportunidades();
        }

        private void lblOportunidades_Click(object sender, EventArgs e)
        {

        }

        private void btnRefrescar_Click_1(object sender, EventArgs e)
        {
            CargarOportunidades();
        }

        private void listOportunidadesCerradas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCerradas_Click(object sender, EventArgs e)
        {

        }
    }
}
