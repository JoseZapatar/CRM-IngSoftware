using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public class GestionReportes
{
    private DatabaseConnection dbConnection;

    public GestionReportes()
    {
        dbConnection = new DatabaseConnection();
    }

    public List<Reporte> ObtenerReportes()
    {
        // Este método puede permanecer vacío si no se utiliza
        return new List<Reporte>();
    }

    public List<Reporte> GenerarReporte(string tipoReporte)
    {
        List<Reporte> reportesGenerados = new List<Reporte>();

        // Solo se maneja el reporte de ventas
        if (tipoReporte == "Reporte de Ventas")
        {
            string query = "SELECT ID_Reporte, Fecha_Reporte, Descripcion_Reporte, ID_Venta FROM Reportes_Ventas";

            dbConnection.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Reporte reporte = new Reporte
                {
                    ID_Reporte = Convert.ToInt32(reader["ID_Reporte"]),
                    Fecha_Reporte = Convert.ToDateTime(reader["Fecha_Reporte"]),
                    Descripcion_Reporte = reader["Descripcion_Reporte"].ToString(),
                    ID_Venta = Convert.ToInt32(reader["ID_Venta"])
                };
                reportesGenerados.Add(reporte);
            }

            dbConnection.CloseConnection();
        }
        else
        {
            MessageBox.Show("El tipo de reporte seleccionado no es válido.");
        }

        return reportesGenerados;
    }
}
