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
        private int clienteId;

        public GestionContactoForm(MySqlConnection connection, int idCliente)
        {
            InitializeComponent();
            dbConnection = connection;
            clienteId = idCliente;
            LlenarComboBoxTipoContacto();
            CargarContactos();
        }

        private void LlenarComboBoxTipoContacto()
        {
            cmbTipoContacto.Items.Add("Teléfono");
            cmbTipoContacto.Items.Add("Correo Electrónico");
            cmbTipoContacto.Items.Add("Dirección");
            cmbTipoContacto.Items.Add("Otro");
            cmbTipoContacto.SelectedIndex = 0; // Seleccionar un valor por defecto
        }

        private void CargarContactos()
        {
            try
            {
                dbConnection.Open();
                string query = "SELECT Tipo_Contacto, Valor_Contacto FROM Contactos WHERE ID_Cliente = @ID_Cliente";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                cmd.Parameters.AddWithValue("@ID_Cliente", clienteId);

                MySqlDataReader reader = cmd.ExecuteReader();
                dgvContactos.Rows.Clear();

                while (reader.Read())
                {
                    dgvContactos.Rows.Add(reader["Tipo_Contacto"], reader["Valor_Contacto"]);
                }

                reader.Close();
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
            try
            {
                dbConnection.Open();
                string query = "INSERT INTO Contactos (ID_Cliente, Tipo_Contacto, Valor_Contacto) VALUES (@ID_Cliente, @TipoContacto, @ValorContacto)";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                cmd.Parameters.AddWithValue("@ID_Cliente", clienteId);
                cmd.Parameters.AddWithValue("@TipoContacto", cmbTipoContacto.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@ValorContacto", txtValorContacto.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Información de contacto agregada correctamente.");
                CargarContactos(); // Recargar la lista de contactos
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
            try
            {
                dbConnection.Open();
                string query = "INSERT INTO Contactos (ID_Cliente, Tipo_Contacto, Valor_Contacto) VALUES (@ID_Cliente, @TipoContacto, @ValorContacto)";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                cmd.Parameters.AddWithValue("@ID_Cliente", clienteId);
                cmd.Parameters.AddWithValue("@TipoContacto", cmbTipoContacto.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@ValorContacto", txtValorContacto.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Información de contacto agregada correctamente.");
                CargarContactos(); // Recargar la lista de contactos
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

        }

        private void txtValorContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipoContacto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
