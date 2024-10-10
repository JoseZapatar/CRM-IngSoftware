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
    

    

    public partial class ClientesForm : Form
    {
        private GestionClientes gestionClientes;

        public ClientesForm()
        {
            InitializeComponent();
            gestionClientes = new GestionClientes();
            CargarClientes();
        }

        private void CargarClientes()
        {
            dgvClientes.DataSource = gestionClientes.ObtenerClientes();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente
            {
                Nombre_Cliente = txtNombre.Text,
                Correo_Cliente = txtCorreo.Text,
                Telefono_Cliente = txtTelefono.Text,
                Direccion_Cliente = txtDireccion.Text
            };

            gestionClientes.AgregarCliente(nuevoCliente);
            LimpiarCampos();
            CargarClientes();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                Cliente cliente = new Cliente
                {
                    ID_Cliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["ID_Cliente"].Value),
                    Nombre_Cliente = txtNombre.Text,
                    Correo_Cliente = txtCorreo.Text,
                    Telefono_Cliente = txtTelefono.Text,
                    Direccion_Cliente = txtDireccion.Text
                };

                gestionClientes.ActualizarCliente(cliente);
                LimpiarCampos();
                CargarClientes();
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                int idCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["ID_Cliente"].Value);
                gestionClientes.EliminarCliente(idCliente);
                LimpiarCampos();
                CargarClientes(); // Volver a cargar los datos sin el cliente eliminado
            }
        }


        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
        }

        // Evento 'Enter' para el TextBox 'Nombre'
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre del Cliente")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = System.Drawing.Color.Black;
            }
        }

        // Evento 'Leave' para el TextBox 'Nombre'
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "Nombre del Cliente";
                txtNombre.ForeColor = System.Drawing.Color.Gray;
            }
        }

        // Eventos 'Enter' y 'Leave' para el TextBox 'Correo'
        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo del Cliente")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                txtCorreo.Text = "Correo del Cliente";
                txtCorreo.ForeColor = System.Drawing.Color.Gray;
            }
        }

        // Eventos 'Enter' y 'Leave' para el TextBox 'Teléfono'
        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Teléfono del Cliente")
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                txtTelefono.Text = "Teléfono del Cliente";
                txtTelefono.ForeColor = System.Drawing.Color.Gray;
            }
        }

        // Eventos 'Enter' y 'Leave' para el TextBox 'Dirección'
        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "Dirección del Cliente")
            {
                txtDireccion.Text = "";
                txtDireccion.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                txtDireccion.Text = "Dirección del Cliente";
                txtDireccion.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

                // Verifica los datos obtenidos
                Console.WriteLine("Nombre Cliente: " + row.Cells["Nombre_Cliente"].Value);
                Console.WriteLine("Correo Cliente: " + row.Cells["Correo_Cliente"].Value);
                Console.WriteLine("Teléfono Cliente: " + row.Cells["Telefono_Cliente"].Value);
                Console.WriteLine("Dirección Cliente: " + row.Cells["Direccion_Cliente"].Value);

                // Luego cargar los datos en los TextBox
                txtNombre.Text = row.Cells["Nombre_Cliente"].Value?.ToString() ?? "";
                txtCorreo.Text = row.Cells["Correo_Cliente"].Value?.ToString() ?? "";
                txtTelefono.Text = row.Cells["Telefono_Cliente"].Value?.ToString() ?? "";
                txtDireccion.Text = row.Cells["Direccion_Cliente"].Value?.ToString() ?? "";
            }
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                Cliente cliente = new Cliente
                {
                    ID_Cliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["ID_Cliente"].Value),
                    Nombre_Cliente = txtNombre.Text,
                    Correo_Cliente = txtCorreo.Text,
                    Telefono_Cliente = txtTelefono.Text,
                    Direccion_Cliente = txtDireccion.Text
                };

                gestionClientes.ActualizarCliente(cliente);
                LimpiarCampos();
                CargarClientes(); // Volver a cargar los datos actualizados
            }
        }




    }


}
