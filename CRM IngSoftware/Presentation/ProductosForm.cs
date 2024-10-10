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

    public partial class ProductosForm : Form
    {
        private GestionProductos gestionProductos;

        public ProductosForm()
        {
            InitializeComponent();
            gestionProductos = new GestionProductos();
            CargarProductos();
        }

        private void CargarProductos()
        {
            dgvProductos.DataSource = gestionProductos.ObtenerProductos();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Producto nuevoProducto = new Producto
            {
                Nombre_Producto = txtNombre.Text,
                Descripcion_Producto = txtDescripcion.Text,
                Precio_Producto = decimal.Parse(txtPrecio.Text),
                Stock_Producto = int.Parse(txtStock.Text)
            };

            gestionProductos.AgregarProducto(nuevoProducto);
            LimpiarCampos();
            CargarProductos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }
        // Eventos para txtNombre
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre del Producto")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];

                // Mensajes de depuración para verificar los datos
                Console.WriteLine("Nombre Producto: " + row.Cells["Nombre_Producto"].Value);
                Console.WriteLine("Descripción Producto: " + row.Cells["Descripcion_Producto"].Value);
                Console.WriteLine("Precio Producto: " + row.Cells["Precio_Producto"].Value);
                Console.WriteLine("Stock Producto: " + row.Cells["Stock_Producto"].Value);

                // Luego cargar los datos en los TextBox
                txtNombre.Text = row.Cells["Nombre_Producto"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripcion_Producto"].Value.ToString();
                txtPrecio.Text = row.Cells["Precio_Producto"].Value.ToString();
                txtStock.Text = row.Cells["Stock_Producto"].Value.ToString();
            }
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                Producto producto = new Producto
                {
                    ID_Producto = Convert.ToInt32(dgvProductos.CurrentRow.Cells["ID_Producto"].Value),
                    Nombre_Producto = txtNombre.Text,
                    Descripcion_Producto = txtDescripcion.Text,
                    Precio_Producto = Convert.ToDecimal(txtPrecio.Text),
                    Stock_Producto = Convert.ToInt32(txtStock.Text)
                };

                gestionProductos.ActualizarProducto(producto);
                LimpiarCampos();
                CargarProductos(); // Recargar productos después de actualizar
            }
        }
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                int idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells["ID_Producto"].Value);
                gestionProductos.EliminarProducto(idProducto);
                LimpiarCampos();
                CargarProductos(); // Recargar productos después de eliminar
            }
        }




        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "Nombre del Producto";
                txtNombre.ForeColor = System.Drawing.Color.Gray;
            }
        }

        // Eventos para txtDescripcion
        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "Descripción del Producto")
            {
                txtDescripcion.Text = "";
                txtDescripcion.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                txtDescripcion.Text = "Descripción del Producto";
                txtDescripcion.ForeColor = System.Drawing.Color.Gray;
            }
        }

        // Eventos para txtPrecio
        private void txtPrecio_Enter(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "Precio del Producto")
            {
                txtPrecio.Text = "";
                txtPrecio.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                txtPrecio.Text = "Precio del Producto";
                txtPrecio.ForeColor = System.Drawing.Color.Gray;
            }
        }

        // Eventos para txtStock
        private void txtStock_Enter(object sender, EventArgs e)
        {
            if (txtStock.Text == "Stock del Producto")
            {
                txtStock.Text = "";
                txtStock.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtStock_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStock.Text))
            {
                txtStock.Text = "Stock del Producto";
                txtStock.ForeColor = System.Drawing.Color.Gray;
            }
        }

    }

}
