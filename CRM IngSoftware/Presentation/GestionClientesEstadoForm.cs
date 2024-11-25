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
    public partial class GestionClientesEstadoForm : Form
    {
        private MySqlConnection dbConnection;

        public GestionClientesEstadoForm(MySqlConnection connection)
        {
            InitializeComponent();
            dbConnection = connection;
            CargarClientesConEstado();
        }

        private void CargarClientesConEstado()
        {
            try
            {
                dbConnection.Open();
                string query = @"
                SELECT 
                    c.ID_Cliente, 
                    c.Nombre_Cliente, 
                    c.Correo_Cliente,
                    CASE 
                        WHEN EXISTS (
                            SELECT 1 
                            FROM Ventas 
                            WHERE Ventas.ID_Cliente = c.ID_Cliente 
                              AND Ventas.Fecha_Venta >= DATE_SUB(NOW(), INTERVAL 6 MONTH)
                        ) THEN 'Activo'
                        ELSE 'Inactivo'
                    END AS Estado
                FROM Clientes c";

                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);

                dgvClientesEstado.DataSource = dataTable;
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

        private void btnEnviarAlertas_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvClientesEstado.Rows)
                {
                    string estado = row.Cells["Estado"].Value.ToString();
                    if (estado == "Inactivo")
                    {
                        string correo = row.Cells["Correo_Cliente"].Value.ToString();
                        string nombre = row.Cells["Nombre_Cliente"].Value.ToString();
                        EnviarAlerta(correo, nombre);
                    }
                }

                MessageBox.Show("Alertas enviadas a todos los clientes inactivos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar alertas: " + ex.Message);
            }
        }

        private void EnviarAlerta(string correo, string nombre)
        {
            // Ejemplo básico de envío de alerta (puede ser un correo, SMS, etc.)
            Console.WriteLine($"Enviando alerta a {nombre} ({correo})...");
            // Aquí podrías implementar un envío de correo o una integración con una API.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviarAlertas_Click_1(object sender, EventArgs e)
        {
            try
            {
                rtbAlertas.Clear(); // Limpia el contenido previo del RichTextBox

                foreach (DataGridViewRow row in dgvClientesEstado.Rows)
                {
                    // Asegurarse de que no es una fila nueva
                    if (!row.IsNewRow)
                    {
                        // Validar que la celda de "Estado" no sea nula antes de acceder
                        var cellValue = row.Cells["Estado"]?.Value;

                        if (cellValue != null) // Validar que tenga un valor
                        {
                            string estado = cellValue.ToString();
                            if (estado == "Inactivo")
                            {
                                // Validar las demás celdas antes de usarlas
                                string correo = row.Cells["Correo_Cliente"]?.Value?.ToString() ?? "Correo no disponible";
                                string nombre = row.Cells["Nombre_Cliente"]?.Value?.ToString() ?? "Nombre no disponible";

                                // Mostrar en pantalla
                                rtbAlertas.AppendText($"Cliente: {nombre}\n");
                                rtbAlertas.AppendText($"Correo: {correo}\n");
                                rtbAlertas.AppendText($"Estado: {estado}\n");
                                rtbAlertas.AppendText("------------------------\n");

                                // Enviar la alerta (si es necesario)
                                EnviarAlerta(correo, nombre);
                            }
                        }
                    }
                }

                if (rtbAlertas.Text == "")
                {
                    rtbAlertas.AppendText("No hay clientes inactivos.\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar alertas: {ex.Message}");
            }
        }

        private void dgvClientesEstado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // En el formulario principal o desde donde se llame:
            ActualizadorEstadosForm form = new ActualizadorEstadosForm(new DatabaseConnection().GetConnection());
            form.Show();

        }
    }
}
