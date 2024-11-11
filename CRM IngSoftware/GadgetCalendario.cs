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
    public partial class GadgetCalendario : UserControl
    {
        private DatabaseConnection dbConnection;

        public GadgetCalendario()
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

        private void calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime fechaSeleccionada = e.Start;
            MostrarEventosDelDia(fechaSeleccionada);
        }

        private void MostrarEventosDelDia(DateTime fecha)
        {
            listEventos.Items.Clear();
            try
            {
                DbConnection.OpenConnection();
                string query = "SELECT Titulo, Tipo_Evento FROM Eventos_Calendario WHERE DATE(Fecha_Evento) = @Fecha";
                MySqlCommand cmd = new MySqlCommand(query, DbConnection.GetConnection());
                cmd.Parameters.AddWithValue("@Fecha", fecha.ToString("yyyy-MM-dd"));

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string tipoEvento = reader["Tipo_Evento"].ToString();
                    string titulo = reader["Titulo"].ToString();
                    listEventos.Items.Add($"{tipoEvento}: {titulo}");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener eventos: " + ex.Message);
            }
            finally
            {
                DbConnection.CloseConnection();
            }
        }

        private void calendario_DateSelected_1(object sender, DateRangeEventArgs e)
        {
            DateTime fechaSeleccionada = e.Start;
            MostrarEventosDelDia(fechaSeleccionada);
        }
    }

}
