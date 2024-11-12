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
    public partial class AgregarTareaForm : Form
    {
        private MySqlConnection dbConnection;

        public AgregarTareaForm(MySqlConnection connection)
        {
            InitializeComponent();
            dbConnection = connection;
            LlenarComboBoxEmpleados();
        }

        private void LlenarComboBoxEmpleados()
        {
            try
            {
                dbConnection.Open();
                string query = "SELECT ID_Empleado, Nombre_Empleado FROM Empleados";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                // Agregar empleados al ComboBox
                while (reader.Read())
                {
                    cmbEmpleado.Items.Add(new
                    {
                        Text = reader["Nombre_Empleado"].ToString(),
                        Value = reader["ID_Empleado"]
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message);
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
                string query = "INSERT INTO Tareas (Titulo, Descripcion, Estado, Fecha_Vencimiento) VALUES (@Titulo, @Descripcion, 'Pendiente', @FechaVencimiento)";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@FechaVencimiento", dtpFechaVencimiento.Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Tarea agregada correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la tarea: " + ex.Message);
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
                if (cmbEmpleado.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un empleado para asignar la tarea.");
                    return;
                }

                int empleadoId = (int)((dynamic)cmbEmpleado.SelectedItem).Value;

                dbConnection.Open();
                string query = "INSERT INTO Tareas (Titulo, Descripcion, Estado, Fecha_Asignacion, ID_Empleado) VALUES (@Titulo, @Descripcion, 'Pendiente', NOW(), @ID_Empleado)";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@ID_Empleado", empleadoId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Tarea agregada correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la tarea: " + ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarTareaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
