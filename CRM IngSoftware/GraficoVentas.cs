using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CRM_IngSoftware
{
    public partial class GraficoVentas : UserControl
    {
        private MySqlConnection dbConnection;

        public GraficoVentas()
        {
            InitializeComponent();
            ConfigurarGrafico();
            CargarDatosVentas();
        }

        private MySqlConnection DbConnection
        {
            get
            {
                if (dbConnection == null)
                {
                    // Coloca manualmente tu cadena de conexión aquí
                    string connectionString = "Server=sql3.freesqldatabase.com;Database=sql3736675;User Id=sql3736675;Password=HMNnvBQYSN;";

                    dbConnection = new MySqlConnection(connectionString);
                }
                return dbConnection;
            }
        }

        private void ConfigurarGrafico()
        {
            chartVentas.Series.Clear();
            chartVentas.Titles.Add("Ventas Mensuales");

            Series serie = new Series("Ventas");
            serie.ChartType = SeriesChartType.Column;
            serie.XValueType = ChartValueType.String;
            chartVentas.Series.Add(serie);

            chartVentas.ChartAreas[0].AxisX.Title = "Mes";
            chartVentas.ChartAreas[0].AxisY.Title = "Monto de Ventas";
        }

        private void CargarDatosVentas()
        {
            try
            {
                DbConnection.Open();

                string query = @"
                SELECT DATE_FORMAT(Fecha_Venta, '%Y-%m') AS Mes, SUM(Monto_Total_Venta) AS TotalVentas
                FROM Ventas
                GROUP BY Mes
                ORDER BY Mes";

                MySqlCommand cmd = new MySqlCommand(query, DbConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                chartVentas.Series["Ventas"].Points.Clear();

                while (reader.Read())
                {
                    string mes = reader["Mes"].ToString();
                    decimal totalVentas = Convert.ToDecimal(reader["TotalVentas"]);
                    chartVentas.Series["Ventas"].Points.AddXY(mes, totalVentas);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos de ventas: " + ex.Message);
            }
            finally
            {
                if (DbConnection.State == System.Data.ConnectionState.Open)
                {
                    DbConnection.Close();
                }
            }
        }

        private void chartVentas_Click(object sender, EventArgs e)
        {

        }
    }
}
