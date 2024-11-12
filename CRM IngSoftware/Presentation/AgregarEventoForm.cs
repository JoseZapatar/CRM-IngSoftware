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
    public partial class AgregarEventoForm : Form
    {
        private MySqlConnection dbConnection;

        public AgregarEventoForm(MySqlConnection connection)
        {
            InitializeComponent();
            dbConnection = connection;
            LlenarComboBoxTipoEvento();
        }

        private void LlenarComboBoxTipoEvento()
        {
            // Aquí puedes definir los tipos de eventos manualmente
            cmbTipoEvento.Items.Add("Reunión");
            cmbTipoEvento.Items.Add("Tarea");
            cmbTipoEvento.Items.Add("Llamada");
            cmbTipoEvento.Items.Add("Otro");

            // Opcional: Seleccionar un valor por defecto
            cmbTipoEvento.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnection.Open();
                string query = "INSERT INTO Eventos_Calendario (Titulo, Descripcion, Fecha_Evento, Tipo_Evento) VALUES (@Titulo, @Descripcion, @FechaEvento, @TipoEvento)";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@FechaEvento", dtpFechaEvento.Value);
                cmd.Parameters.AddWithValue("@TipoEvento", cmbTipoEvento.SelectedItem.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Evento agregado correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el evento: " + ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnection.Open();
                string query = "INSERT INTO Eventos_Calendario (Titulo, Descripcion, Fecha_Evento, Tipo_Evento) VALUES (@Titulo, @Descripcion, @FechaEvento, @TipoEvento)";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@FechaEvento", dtpFechaEvento.Value);
                cmd.Parameters.AddWithValue("@TipoEvento", cmbTipoEvento.SelectedItem.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Evento agregado correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el evento: " + ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
