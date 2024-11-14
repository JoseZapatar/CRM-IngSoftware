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
    public partial class GestionInteraccionesForm : Form
    {
        private MySqlConnection dbConnection;
        private int clienteId;

        public GestionInteraccionesForm(MySqlConnection connection, int idCliente)
        {
            InitializeComponent();
            dbConnection = connection;
            clienteId = idCliente;
            LlenarComboBoxTipoInteraccion();
            CargarInteracciones();
        }

        private void LlenarComboBoxTipoInteraccion()
        {
            cmbTipoInteraccion.Items.Add("Llamada");
            cmbTipoInteraccion.Items.Add("Correo");
            cmbTipoInteraccion.Items.Add("Reunión");
            cmbTipoInteraccion.Items.Add("Otro");
            cmbTipoInteraccion.SelectedIndex = 0; // Seleccionar un valor por defecto
        }

        private void CargarInteracciones()
        {
            try
            {
                dbConnection.Open();
                string query = "SELECT Tipo_Interaccion, Detalle_Interaccion, Fecha_Interaccion FROM Historial_Interacciones WHERE ID_Cliente = @ID_Cliente ORDER BY Fecha_Interaccion DESC";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                cmd.Parameters.AddWithValue("@ID_Cliente", clienteId);

                MySqlDataReader reader = cmd.ExecuteReader();
                dgvInteracciones.Rows.Clear();

                while (reader.Read())
                {
                    dgvInteracciones.Rows.Add(reader["Tipo_Interaccion"], reader["Detalle_Interaccion"], reader["Fecha_Interaccion"]);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar interacciones: " + ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        private void btnAgregarInteraccion_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnection.Open();
                string query = "INSERT INTO Historial_Interacciones (ID_Cliente, Tipo_Interaccion, Detalle_Interaccion, Fecha_Interaccion) VALUES (@ID_Cliente, @TipoInteraccion, @DetalleInteraccion, NOW())";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                cmd.Parameters.AddWithValue("@ID_Cliente", clienteId);
                cmd.Parameters.AddWithValue("@TipoInteraccion", cmbTipoInteraccion.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@DetalleInteraccion", txtDetalleInteraccion.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Interacción registrada correctamente.");
                CargarInteracciones(); // Recargar el historial de interacciones
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la interacción: " + ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarInteraccion_Click_1(object sender, EventArgs e)
        {
            try
            {
                dbConnection.Open();
                string query = "INSERT INTO Historial_Interacciones (ID_Cliente, Tipo_Interaccion, Detalle_Interaccion, Fecha_Interaccion) VALUES (@ID_Cliente, @TipoInteraccion, @DetalleInteraccion, NOW())";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                cmd.Parameters.AddWithValue("@ID_Cliente", clienteId);
                cmd.Parameters.AddWithValue("@TipoInteraccion", cmbTipoInteraccion.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@DetalleInteraccion", txtDetalleInteraccion.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Interacción registrada correctamente.");
                CargarInteracciones(); // Recargar el historial de interacciones
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la interacción: " + ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
