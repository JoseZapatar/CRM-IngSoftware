using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

public class GestionOportunidades
{
    private DatabaseConnection dbConnection;

    public GestionOportunidades()
    {
        dbConnection = new DatabaseConnection();
    }

    public void AgregarOportunidad(int idCliente, string descripcion)
    {
        string query = "INSERT INTO Oportunidades (ID_Cliente, Descripcion) VALUES (@ID_Cliente, @Descripcion)";
        dbConnection.OpenConnection();
        MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
        cmd.Parameters.AddWithValue("@ID_Cliente", idCliente);
        cmd.Parameters.AddWithValue("@Descripcion", descripcion);
        cmd.ExecuteNonQuery();
        dbConnection.CloseConnection();
    }

    // Método para obtener oportunidades activas
    public List<Oportunidad> ObtenerOportunidadesActivas()
    {
        List<Oportunidad> oportunidades = new List<Oportunidad>();
        string query = "SELECT * FROM Oportunidades WHERE Estado = 'Activa'";
        dbConnection.OpenConnection();
        MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
        MySqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            oportunidades.Add(new Oportunidad
            {
                ID_Oportunidad = reader.GetInt32("ID_Oportunidad"),
                Descripcion = reader["Descripcion"].ToString(),
                Fecha_Creacion = reader.GetDateTime("Fecha_Creacion")
            });
        }
        dbConnection.CloseConnection();
        return oportunidades;
    }
}
