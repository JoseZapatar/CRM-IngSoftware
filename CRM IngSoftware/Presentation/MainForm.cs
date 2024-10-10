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

    public partial class MainForm : Form
    {
        public MainForm(bool esAdministrador)
        {
            InitializeComponent();
            AplicarPermisos(esAdministrador);
        }

        private void AplicarPermisos(bool esAdministrador)
        {
            if (!esAdministrador)
            {
                btnGestionarUsuarios.Visible = false; // Los empleados no pueden gestionar usuarios
            }
        }

        private void btnGestionarClientes_Click(object sender, EventArgs e)
        {
            ClientesForm clientesForm = new ClientesForm();
            clientesForm.Show();
        }

        private void btnGestionarVentas_Click(object sender, EventArgs e)
        {
            VentasForm ventasForm = new VentasForm();
            ventasForm.Show();
        }

        private void btnGestionarProductos_Click(object sender, EventArgs e)
        {
            ProductosForm productosForm = new ProductosForm();
            productosForm.Show();
        }

        private void btnGestionarReportes_Click(object sender, EventArgs e)
        {
            ReportesForm reportesForm = new ReportesForm();
            reportesForm.Show();
        }

        private void btnGestionarUsuarios_Click(object sender, EventArgs e)
        {
            GestionUsuariosForm gestionUsuariosForm = new GestionUsuariosForm();
            gestionUsuariosForm.Show();
        }
    }

}
