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

        public VentasForm()
        {
            InitializeComponent();
            gestionVentas = new GestionVentas();
            CargarVentas();
        }

        private void CargarVentas()
        {
            dgvVentas.DataSource = gestionVentas.ObtenerVentas();
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            // Ejemplo simple: aquí agregarás la lógica para registrar una venta
            Venta nuevaVenta = new Venta
            {
                ID_Cliente = Convert.ToInt32(txtClienteID.Text), // Asumimos que tienes un campo para el ID del cliente
                Fecha_Venta = DateTime.Now,
                Monto_Total_Venta = decimal.Parse(txtMontoTotal.Text) // Asumimos que tienes un campo para el monto total
            };

            gestionVentas.RegistrarVenta(nuevaVenta, new List<DetalleVenta>());
            LimpiarCampos();
            CargarVentas();
        }

        private void LimpiarCampos()
        {
            txtClienteID.Clear();
            txtMontoTotal.Clear();
        }

        // Eventos para txtClienteID
        private void txtClienteID_Enter(object sender, EventArgs e)
        {
            if (txtClienteID.Text == "ID del Cliente")
            {
                txtClienteID.Text = "";
                txtClienteID.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtClienteID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClienteID.Text))
            {
                txtClienteID.Text = "ID del Cliente";
                txtClienteID.ForeColor = System.Drawing.Color.Gray;
            }
        }

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
