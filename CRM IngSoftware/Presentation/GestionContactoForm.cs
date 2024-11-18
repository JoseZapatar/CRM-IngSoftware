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
    public partial class GestionContactoForm : Form
    {
        private MySqlConnection dbConnection;

        public GestionContactoForm(MySqlConnection connection)
        {
            InitializeComponent();
            dbConnection = connection;
            CargarClientes();
            LlenarComboBoxTipoContacto();
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
                CargarContactos(idCliente);
            }
        }

        private void CargarContactos(int idCliente)
        {
            try
            {
                dbConnection.Open();
                string query = "SELECT Tipo_Contacto, Valor_Contacto FROM Contactos WHERE ID_Cliente = @ID_Cliente";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                cmd.Parameters.AddWithValue("@ID_Cliente", idCliente);

                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);

                dgvContactos.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar contactos: " + ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        private void btnAgregarContacto_Click(object sender, EventArgs e)
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
                string query = "INSERT INTO Contactos (ID_Cliente, Tipo_Contacto, Valor_Contacto) VALUES (@ID_Cliente, @TipoContacto, @ValorContacto)";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                cmd.Parameters.AddWithValue("@ID_Cliente", idCliente);
                cmd.Parameters.AddWithValue("@TipoContacto", cmbTipoContacto.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@ValorContacto", txtValorContacto.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Contacto agregado correctamente.");
                CargarContactos(idCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar contacto: " + ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }



        private void button1_Click(object sender, EventArgs e)
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
                string query = "INSERT INTO Contactos (ID_Cliente, Tipo_Contacto, Valor_Contacto) VALUES (@ID_Cliente, @TipoContacto, @ValorContacto)";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                cmd.Parameters.AddWithValue("@ID_Cliente", idCliente);
                cmd.Parameters.AddWithValue("@TipoContacto", cmbTipoContacto.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@ValorContacto", txtValorContacto.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Contacto agregado correctamente.");
                CargarContactos(idCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar contacto: " + ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        private void dgvContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idCliente = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells["ID_Cliente"].Value);
                CargarContactos(idCliente);
            }
        }

        private void txtValorContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipoContacto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idCliente = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells["ID_Cliente"].Value);
                CargarContactos(idCliente);
            }
        }
        private void LlenarComboBoxTipoContacto()
        {
            // Limpiar el ComboBox antes de llenarlo (opcional)
            cmbTipoContacto.Items.Clear();

            // Agregar opciones para los tipos de contacto
            cmbTipoContacto.Items.Add("Teléfono");
            cmbTipoContacto.Items.Add("Correo Electrónico");
            cmbTipoContacto.Items.Add("Dirección");
            cmbTipoContacto.Items.Add("Otro");

            // Seleccionar el primer elemento como predeterminado
            if (cmbTipoContacto.Items.Count > 0)
            {
                cmbTipoContacto.SelectedIndex = 0;
            }
        }
    }
}
