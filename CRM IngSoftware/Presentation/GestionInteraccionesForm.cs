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

        public GestionInteraccionesForm(MySqlConnection connection)
        {
            InitializeComponent();
            dbConnection = connection;
            CargarClientes();
            LlenarComboBoxTipoInteraccion();
        }

        private void CargarClientes()
        {
            try
            {
                dbConnection.Open();
                string query = "SELECT ID_Cliente, Nombre_Cliente FROM Clientes";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);

                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);

                dgvClientes.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idCliente = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells["ID_Cliente"].Value);
                CargarInteracciones(idCliente);
            }
        }

        private void CargarInteracciones(int idCliente)
        {
            try
            {
                dbConnection.Open();
                string query = "SELECT Tipo_Interaccion, Detalle_Interaccion, Fecha_Interaccion FROM Historial_Interacciones WHERE ID_Cliente = @ID_Cliente ORDER BY Fecha_Interaccion DESC";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                cmd.Parameters.AddWithValue("@ID_Cliente", idCliente);

                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);

                dgvInteracciones.DataSource = dataTable;
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
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un cliente primero.");
                return;
            }

            int idCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["ID_Cliente"].Value);

            try
            {
                dbConnection.Open();
                string query = "INSERT INTO Historial_Interacciones (ID_Cliente, Tipo_Interaccion, Detalle_Interaccion, Fecha_Interaccion) VALUES (@ID_Cliente, @TipoInteraccion, @DetalleInteraccion, NOW())";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                cmd.Parameters.AddWithValue("@ID_Cliente", idCliente);
                cmd.Parameters.AddWithValue("@TipoInteraccion", cmbTipoInteraccion.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@DetalleInteraccion", txtDetalleInteraccion.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Interacción registrada correctamente.");
                CargarInteracciones(idCliente); // Recargar las interacciones
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
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un cliente primero.");
                return;
            }

            int idCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["ID_Cliente"].Value);

            try
            {
                dbConnection.Open();
                string query = "INSERT INTO Historial_Interacciones (ID_Cliente, Tipo_Interaccion, Detalle_Interaccion, Fecha_Interaccion) VALUES (@ID_Cliente, @TipoInteraccion, @DetalleInteraccion, NOW())";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                cmd.Parameters.AddWithValue("@ID_Cliente", idCliente);
                cmd.Parameters.AddWithValue("@TipoInteraccion", cmbTipoInteraccion.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@DetalleInteraccion", txtDetalleInteraccion.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Interacción registrada correctamente.");
                CargarInteracciones(idCliente); // Recargar las interacciones
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

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idCliente = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells["ID_Cliente"].Value);
                CargarInteracciones(idCliente);
            }
        }
        private void LlenarComboBoxTipoInteraccion()
        {
            // Asegúrate de limpiar los ítems antes de llenarlo, si es necesario
            cmbTipoInteraccion.Items.Clear();

            // Agregar los valores directamente
            cmbTipoInteraccion.Items.Add("Llamada");
            cmbTipoInteraccion.Items.Add("Correo");
            cmbTipoInteraccion.Items.Add("Reunión");
            cmbTipoInteraccion.Items.Add("Otro");

            // Seleccionar el primer elemento por defecto
            if (cmbTipoInteraccion.Items.Count > 0)
            {
                cmbTipoInteraccion.SelectedIndex = 0;
            }
        }
    }
}
