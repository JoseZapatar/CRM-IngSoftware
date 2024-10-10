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

    public partial class ReportesForm : Form
    {
        private GestionReportes gestionReportes;

        public ReportesForm()
        {
            InitializeComponent();
            gestionReportes = new GestionReportes(); // Inicializar la clase de gestión de reportes
            CargarReportes();
        }

        private void CargarReportes()
        {
            // Cargar datos iniciales en el DataGridView si es necesario
            dgvReportes.DataSource = gestionReportes.ObtenerReportes(); // Método para obtener reportes, si corresponde
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            // Lógica para generar el reporte basado en criterios seleccionados
            string tipoReporte = cmbTipoReporte.SelectedItem.ToString();
            var reportesGenerados = gestionReportes.GenerarReporte(tipoReporte);

            // Mostrar los reportes generados en el DataGridView
            dgvReportes.DataSource = reportesGenerados;
        }
    }



}
