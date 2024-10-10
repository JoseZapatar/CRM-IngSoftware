using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

public class GestionVentas
{
    private DatabaseConnection dbConnection;

    public GestionVentas()
    {
        dbConnection = new DatabaseConnection();
    }

    public List<Venta> ObtenerVentas()
    {
        List<Venta> ventas = new List<Venta>();
        string query = "SELECT * FROM Ventas";

        dbConnection.OpenConnection();
        MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
        MySqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Venta venta = new Venta
            {
                ID_Venta = Convert.ToInt32(reader["ID_Venta"]),
                ID_Cliente = Convert.ToInt32(reader["ID_Cliente"]),
                Fecha_Venta = Convert.ToDateTime(reader["Fecha_Venta"]),
                Monto_Total_Venta = Convert.ToDecimal(reader["Monto_Total_Venta"])
            };
            ventas.Add(venta);
        }

        dbConnection.CloseConnection();
        return ventas;
    }

    public void RegistrarVenta(Venta venta, List<DetalleVenta> detallesVenta)
    {
        string queryVenta = "INSERT INTO Ventas (ID_Cliente, Fecha_Venta, Monto_Total_Venta) VALUES (@ID_Cliente, @Fecha, @MontoTotal); SELECT LAST_INSERT_ID();";
        string queryDetalle = "INSERT INTO Detalles_Venta (ID_Venta, ID_Producto, Cantidad, Precio_Unitario) VALUES (@ID_Venta, @ID_Producto, @Cantidad, @PrecioUnitario)";

        dbConnection.OpenConnection();
        MySqlCommand cmdVenta = new MySqlCommand(queryVenta, dbConnection.GetConnection());
        cmdVenta.Parameters.AddWithValue("@ID_Cliente", venta.ID_Cliente);
        cmdVenta.Parameters.AddWithValue("@Fecha", venta.Fecha_Venta);
        cmdVenta.Parameters.AddWithValue("@MontoTotal", venta.Monto_Total_Venta);

        // Obtener el ID de la venta insertada
        int idVenta = Convert.ToInt32(cmdVenta.ExecuteScalar());

        foreach (var detalle in detallesVenta)
        {
            MySqlCommand cmdDetalle = new MySqlCommand(queryDetalle, dbConnection.GetConnection());
            cmdDetalle.Parameters.AddWithValue("@ID_Venta", idVenta);
            cmdDetalle.Parameters.AddWithValue("@ID_Producto", detalle.ID_Producto);
            cmdDetalle.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
            cmdDetalle.Parameters.AddWithValue("@PrecioUnitario", detalle.Precio_Unitario);
            cmdDetalle.ExecuteNonQuery();
        }

        dbConnection.CloseConnection();
    }
}
