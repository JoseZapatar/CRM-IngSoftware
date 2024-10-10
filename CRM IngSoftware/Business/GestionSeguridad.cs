using System;
using MySql.Data.MySqlClient;

public class GestionSeguridad
{
    private DatabaseConnection dbConnection;

    public GestionSeguridad()
    {
        dbConnection = new DatabaseConnection();
    }

    public bool AutenticarEmpleado(string correo, string contraseña, out bool esAdministrador)
    {
        esAdministrador = false;
        string query = "SELECT EsAdministrador FROM Empleados WHERE Correo_Empleado = @Correo AND Contraseña = @Contraseña";

        dbConnection.OpenConnection();
        MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
        cmd.Parameters.AddWithValue("@Correo", correo);
        cmd.Parameters.AddWithValue("@Contraseña", contraseña);

        MySqlDataReader reader = cmd.ExecuteReader();

        if (reader.Read())
        {
            esAdministrador = Convert.ToBoolean(reader["EsAdministrador"]);
            dbConnection.CloseConnection();
            return true;
        }

        dbConnection.CloseConnection();
        return false;
    }
}
