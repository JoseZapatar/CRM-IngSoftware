using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

public class GestionProductos
{
    private DatabaseConnection dbConnection;

    public GestionProductos()
    {
        dbConnection = new DatabaseConnection();
    }

    // Método para obtener todos los productos
    public List<Producto> ObtenerProductos()
    {
        List<Producto> productos = new List<Producto>();
        string query = "SELECT * FROM Productos";

        dbConnection.OpenConnection();
        MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
        MySqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Producto producto = new Producto
            {
                ID_Producto = Convert.ToInt32(reader["ID_Producto"]),
                Nombre_Producto = reader["Nombre_Producto"].ToString(),
                Descripcion_Producto = reader["Descripcion_Producto"].ToString(),
                Precio_Producto = Convert.ToDecimal(reader["Precio_Producto"]),
                Stock_Producto = Convert.ToInt32(reader["Stock_Producto"])
            };
            productos.Add(producto);
        }

        dbConnection.CloseConnection();
        return productos;
    }

    // Método para agregar un nuevo producto
    public void AgregarProducto(Producto producto)
    {
        string query = "INSERT INTO Productos (Nombre_Producto, Descripcion_Producto, Precio_Producto, Stock_Producto) VALUES (@Nombre, @Descripcion, @Precio, @Stock)";

        dbConnection.OpenConnection();
        MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
        cmd.Parameters.AddWithValue("@Nombre", producto.Nombre_Producto);
        cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion_Producto);
        cmd.Parameters.AddWithValue("@Precio", producto.Precio_Producto);
        cmd.Parameters.AddWithValue("@Stock", producto.Stock_Producto);
        cmd.ExecuteNonQuery();
        dbConnection.CloseConnection();
    }

    // Método para actualizar un producto existente
    public void ActualizarProducto(Producto producto)
    {
        string query = "UPDATE Productos SET Nombre_Producto = @Nombre, Descripcion_Producto = @Descripcion, Precio_Producto = @Precio, Stock_Producto = @Stock WHERE ID_Producto = @ID_Producto";

        dbConnection.OpenConnection();
        MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
        cmd.Parameters.AddWithValue("@ID_Producto", producto.ID_Producto);
        cmd.Parameters.AddWithValue("@Nombre", producto.Nombre_Producto);
        cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion_Producto);
        cmd.Parameters.AddWithValue("@Precio", producto.Precio_Producto);
        cmd.Parameters.AddWithValue("@Stock", producto.Stock_Producto);
        cmd.ExecuteNonQuery();
        dbConnection.CloseConnection();
    }

    // Método para eliminar un producto
    public void EliminarProducto(int idProducto)
    {
        string query = "DELETE FROM Productos WHERE ID_Producto = @ID_Producto";

        dbConnection.OpenConnection();
        MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
        cmd.Parameters.AddWithValue("@ID_Producto", idProducto);
        cmd.ExecuteNonQuery();
        dbConnection.CloseConnection();
    }
}
