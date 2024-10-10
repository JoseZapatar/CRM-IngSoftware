using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

public class GestionClientes
{
    private DatabaseConnection dbConnection;

    public GestionClientes()
    {
        dbConnection = new DatabaseConnection();
    }

    public List<Cliente> ObtenerClientes()
    {
        List<Cliente> clientes = new List<Cliente>();

        string query = "SELECT * FROM Clientes";
        dbConnection.OpenConnection();
        MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
        MySqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Cliente cliente = new Cliente
            {
                ID_Cliente = Convert.ToInt32(reader["ID_Cliente"]),
                Nombre_Cliente = reader["Nombre_Cliente"].ToString(),
                Correo_Cliente = reader["Correo_Cliente"].ToString(),
                Telefono_Cliente = reader["Telefono_Cliente"].ToString(),
                Fecha_Registro = Convert.ToDateTime(reader["Fecha_Registro"]),
                Direccion_Cliente = reader["Direccion_Cliente"].ToString()
            };
            clientes.Add(cliente);
        }

        dbConnection.CloseConnection();
        return clientes;
    }

    public void AgregarCliente(Cliente cliente)
    {
        string query = "INSERT INTO Clientes (Nombre_Cliente, Correo_Cliente, Telefono_Cliente, Direccion_Cliente) VALUES (@Nombre, @Correo, @Telefono, @Direccion)";

        dbConnection.OpenConnection();
        MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
        cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre_Cliente);
        cmd.Parameters.AddWithValue("@Correo", cliente.Correo_Cliente);
        cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono_Cliente);
        cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion_Cliente ?? (object)DBNull.Value);
        cmd.ExecuteNonQuery();
        dbConnection.CloseConnection();
    }

    public void ActualizarCliente(Cliente cliente)
    {
        string query = "UPDATE Clientes SET Nombre_Cliente = @Nombre, Correo_Cliente = @Correo, Telefono_Cliente = @Telefono, Direccion_Cliente = @Direccion WHERE ID_Cliente = @ID";

        dbConnection.OpenConnection();
        MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
        cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre_Cliente);
        cmd.Parameters.AddWithValue("@Correo", cliente.Correo_Cliente);
        cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono_Cliente);
        cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion_Cliente ?? (object)DBNull.Value);
        cmd.Parameters.AddWithValue("@ID", cliente.ID_Cliente);
        cmd.ExecuteNonQuery();
        dbConnection.CloseConnection();
    }

    public void EliminarCliente(int idCliente)
    {
        string query = "DELETE FROM Clientes WHERE ID_Cliente = @ID";

        dbConnection.OpenConnection();
        MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
        cmd.Parameters.AddWithValue("@ID", idCliente);
        cmd.ExecuteNonQuery();
        dbConnection.CloseConnection();
    }
}
