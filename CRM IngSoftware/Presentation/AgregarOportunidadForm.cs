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
    public partial class AgregarOportunidadForm : Form
    {
        private MySqlConnection dbConnection;

        public AgregarOportunidadForm(MySqlConnection connection)
        {
            InitializeComponent();
            dbConnection = connection;
            LlenarComboBoxClientes();
        }

        private void LlenarComboBoxClientes()
        {
            try
            {
                dbConnection.Open();
                string query = "SELECT ID_Cliente, Nombre_Cliente FROM Clientes";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                // Agregar clientes al ComboBox
                while (reader.Read())
                {
                    cmbCliente.Items.Add(new
                    {
                        Text = reader["Nombre_Cliente"].ToString(),
                        Value = reader["ID_Cliente"]
                    });
                }
                reader.Close();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnection.Open();
                string query = "INSERT INTO Oportunidades (Descripcion, Estado, Fecha_Creacion) VALUES (@Descripcion, 'Activa', NOW())";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Oportunidad agregada correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la oportunidad: " + ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbCliente.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un cliente para asociar la oportunidad.");
                    return;
                }

                int clienteId = (int)((dynamic)cmbCliente.SelectedItem).Value;

                dbConnection.Open();
                string query = "INSERT INTO Oportunidades (Descripcion, Estado, Fecha_Creacion, ID_Cliente) VALUES (@Descripcion, 'Activa', NOW(), @ID_Cliente)";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@ID_Cliente", clienteId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Oportunidad agregada correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la oportunidad: " + ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }
    }
}
