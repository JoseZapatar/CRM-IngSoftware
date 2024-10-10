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
    public partial class LoginForm : Form
    {
        private GestionSeguridad gestionSeguridad;

        public LoginForm()
        {
            InitializeComponent();
            gestionSeguridad = new GestionSeguridad(); // Clase que maneja la autenticación
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool esAdministrador;
            string correo = txtCorreo.Text;
            string contraseña = txtContraseña.Text;

            if (gestionSeguridad.AutenticarEmpleado(correo, contraseña, out esAdministrador))
            {
                MainForm mainForm = new MainForm(esAdministrador); // Abrir el formulario principal
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Intente nuevamente.");
            }
        }
    }


}

