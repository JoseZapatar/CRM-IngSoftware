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


    using System;
    using System.Windows.Forms;

    public partial class VentasForm : Form
    {
        private GestionVentas gestionVentas;
        private GestionClientes gestionClientes;
        public VentasForm()
        {
            InitializeComponent();
            gestionVentas = new GestionVentas();
            gestionClientes = new GestionClientes();
            CargarClientes();
            CargarVentas();
        }

        private void CargarClientes()
        {
            try
            {
                // Obtener los clientes desde la base de datos
                var clientes = gestionClientes.ObtenerClientes();
                cmbClientes.DataSource = clientes;
                cmbClientes.DisplayMember = "Nombre_Cliente"; // Mostrar el nombre del cliente
                cmbClientes.ValueMember = "ID_Cliente"; // Usar el ID del cliente como valor
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
        }

        private void CargarVentas()
        {
            dgvVentas.DataSource = gestionVentas.ObtenerVentas();
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que se haya seleccionado un cliente
                if (cmbClientes.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, selecciona un cliente.");
                    return;
                }

                Venta nuevaVenta = new Venta
                {
                    ID_Cliente = Convert.ToInt32(cmbClientes.SelectedValue), // Obtener el ID del cliente seleccionado
                    Fecha_Venta = DateTime.Now,
                    Monto_Total_Venta = decimal.Parse(txtMontoTotal.Text)
                };

                gestionVentas.RegistrarVenta(nuevaVenta, new List<DetalleVenta>());
                MessageBox.Show("Venta registrada exitosamente.");
                LimpiarCampos();
                CargarVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la venta: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            cmbClientes.SelectedIndex = -1; // Limpiar selección del ComboBox
            txtMontoTotal.Clear();
        }

        // Eventos para txtClienteID
        

        // Eventos para txtMontoTotal
        private void txtMontoTotal_Enter(object sender, EventArgs e)
        {
            if (txtMontoTotal.Text == "Monto Total")
            {
                txtMontoTotal.Text = "";
                txtMontoTotal.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtMontoTotal_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMontoTotal.Text))
            {
                txtMontoTotal.Text = "Monto Total";
                txtMontoTotal.ForeColor = System.Drawing.Color.Gray;
            }
        }

    }


}
