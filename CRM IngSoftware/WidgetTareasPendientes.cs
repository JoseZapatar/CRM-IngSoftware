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

    public partial class WidgetTareas : UserControl
    {
        private DatabaseConnection dbConnection;

        public WidgetTareas()
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

        private void CargarTareas()
        {
            listTareasPendientes.Items.Clear();
            listTareasCompletadas.Items.Clear();

            try
            {
                DbConnection.OpenConnection();

                // Cargar Tareas Pendientes
                string queryPendientes = "SELECT Titulo FROM Tareas WHERE Estado = 'Pendiente'";
                MySqlCommand cmdPendientes = new MySqlCommand(queryPendientes, DbConnection.GetConnection());
                MySqlDataReader readerPendientes = cmdPendientes.ExecuteReader();

                while (readerPendientes.Read())
                {
                    listTareasPendientes.Items.Add(readerPendientes["Titulo"].ToString());
                }
                readerPendientes.Close();

                // Cargar Tareas Completadas
                string queryCompletadas = "SELECT Titulo FROM Tareas WHERE Estado = 'Completada'";
                MySqlCommand cmdCompletadas = new MySqlCommand(queryCompletadas, DbConnection.GetConnection());
                MySqlDataReader readerCompletadas = cmdCompletadas.ExecuteReader();

                while (readerCompletadas.Read())
                {
                    listTareasCompletadas.Items.Add(readerCompletadas["Titulo"].ToString());
                }
                readerCompletadas.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tareas: " + ex.Message);
            }
            finally
            {
                DbConnection.CloseConnection();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarTareas();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            CargarTareas();
        }

        private void lstTareas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPendientes_Click(object sender, EventArgs e)
        {

        }
    }
}
