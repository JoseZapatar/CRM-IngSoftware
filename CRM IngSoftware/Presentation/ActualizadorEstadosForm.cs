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
    public partial class ActualizadorEstadosForm : Form
    {
        private MySqlConnection dbConnection;

        public ActualizadorEstadosForm(MySqlConnection connection)
        {
            InitializeComponent();
            dbConnection = connection;
            CargarClientes();
        }

        private void ActualizadorEstadosForm_Load(object sender, EventArgs e)
        {
            // Cargar los clientes al iniciar el formulario
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                dbConnection.Open();
                string query = "SELECT ID_Cliente, Nombre_Cliente, Estado FROM Clientes";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable clientes = new DataTable();
                adapter.Fill(clientes);

                dgvClientes.DataSource = clientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        private void btnActualizarEstados_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnection.Open();

                // Actualizar el estado de los clientes según sus ventas
                string query = @"
                UPDATE Clientes
                SET Estado = 
                    CASE 
                        WHEN EXISTS (
                            SELECT 1 FROM Ventas WHERE Ventas.ID_Cliente = Clientes.ID_Cliente
                        ) THEN 'Activo'
                        ELSE 'Inactivo'
                    END";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                int rowsAffected = cmd.ExecuteNonQuery();

                // Mostrar un mensaje con los resultados
                lblResultado.Text = $"Se actualizaron {rowsAffected} clientes.";
                lblResultado.ForeColor = System.Drawing.Color.Green;

                // Recargar la tabla para reflejar los cambios
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los estados: " + ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        private void btnActualizarEstados_Click_1(object sender, EventArgs e)
        {
            try
            {
                dbConnection.Open();

                // Actualizar el estado de los clientes según sus ventas
                string query = @"
                UPDATE Clientes
                SET Estado = 
                    CASE 
                        WHEN EXISTS (
                            SELECT 1 FROM Ventas WHERE Ventas.ID_Cliente = Clientes.ID_Cliente
                        ) THEN 'Activo'
                        ELSE 'Inactivo'
                    END";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                int rowsAffected = cmd.ExecuteNonQuery();

                // Mostrar un mensaje con los resultados
                lblResultado.Text = $"Se actualizaron {rowsAffected} clientes.";
                lblResultado.ForeColor = System.Drawing.Color.Green;

                // Recargar la tabla para reflejar los cambios
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los estados: " + ex.Message);
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
