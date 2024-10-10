using CRM_IngSoftware.Presentation;
using System;
using System.Windows.Forms;

namespace CRM_IngSoftware
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Aquí llamas al formulario de inicio, por ejemplo, LoginForm o MainForm.
            Application.Run(new LoginForm()); // Si usas autenticación, inicia con LoginForm
        }
    }
}
