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

    public partial class GestionUsuariosForm : Form
    {
        private GestionUsuarios gestionUsuarios;

        public GestionUsuariosForm()
        {
            InitializeComponent();
            gestionUsuarios = new GestionUsuarios(); // Clase que maneja la lógica de los usuarios
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = gestionUsuarios.ObtenerEmpleados();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            Empleado nuevoEmpleado = new Empleado
            {
                Nombre_Empleado = txtNombre.Text,
                Correo_Empleado = txtCorreo.Text,
                Contraseña = txtContraseña.Text,
                EsAdministrador = chkEsAdministrador.Checked
            };

            gestionUsuarios.AgregarEmpleado(nuevoEmpleado);
            LimpiarCampos();
            CargarUsuarios();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                Empleado empleado = new Empleado
                {
                    ID_Empleado = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["ID_Empleado"].Value),
                    Nombre_Empleado = txtNombre.Text,
                    Correo_Empleado = txtCorreo.Text,
                    Contraseña = txtContraseña.Text,
                    EsAdministrador = chkEsAdministrador.Checked
                };

                gestionUsuarios.ActualizarEmpleado(empleado);
                LimpiarCampos();
                CargarUsuarios();
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                int idEmpleado = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["ID_Empleado"].Value);
                gestionUsuarios.EliminarEmpleado(idEmpleado);
                LimpiarCampos();
                CargarUsuarios(); // Volver a cargar los datos sin el usuario eliminado
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCorreo.Clear();
            txtContraseña.Clear();
            chkEsAdministrador.Checked = false;
        }

        // Evento 'Enter' para el TextBox 'Nombre'
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre del Usuario")
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
                txtNombre.Text = "Nombre del Usuario";
                txtNombre.ForeColor = System.Drawing.Color.Gray;
            }
        }

        // Eventos 'Enter' y 'Leave' para el TextBox 'Correo'
        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo del Usuario")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                txtCorreo.Text = "Correo del Usuario";
                txtCorreo.ForeColor = System.Drawing.Color.Gray;
            }
        }

        // Eventos 'Enter' y 'Leave' para el TextBox 'Contraseña'
        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = System.Drawing.Color.Gray;
            }
        }

        // Evento CellClick para el DataGridView de Usuarios
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];

                // Mensajes de depuración para verificar los datos
                Console.WriteLine("Nombre Empleado: " + row.Cells["Nombre_Empleado"].Value);
                Console.WriteLine("Correo Empleado: " + row.Cells["Correo_Empleado"].Value);
                Console.WriteLine("Contraseña: " + row.Cells["Contraseña"].Value);
                Console.WriteLine("Es Administrador: " + row.Cells["EsAdministrador"].Value);

                // Cargar los datos seleccionados en los TextBox
                txtNombre.Text = row.Cells["Nombre_Empleado"].Value?.ToString() ?? "";
                txtCorreo.Text = row.Cells["Correo_Empleado"].Value?.ToString() ?? "";
                txtContraseña.Text = row.Cells["Contraseña"].Value?.ToString() ?? "";
                chkEsAdministrador.Checked = Convert.ToBoolean(row.Cells["EsAdministrador"].Value);
            }
        }
    }



}
