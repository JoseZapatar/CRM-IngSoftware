using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

public class GestionUsuarios
{
    private DatabaseConnection dbConnection;

    public GestionUsuarios()
    {
        dbConnection = new DatabaseConnection();
    }

    public List<Empleado> ObtenerEmpleados()
    {
        List<Empleado> empleados = new List<Empleado>();
        string query = "SELECT ID_Empleado, Nombre_Empleado, Correo_Empleado, EsAdministrador, Fecha_Registro FROM Empleados";

        dbConnection.OpenConnection();
        MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
        MySqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Empleado empleado = new Empleado
            {
                ID_Empleado = Convert.ToInt32(reader["ID_Empleado"]),
                Nombre_Empleado = reader["Nombre_Empleado"].ToString(),
                Correo_Empleado = reader["Correo_Empleado"].ToString(),
                EsAdministrador = Convert.ToBoolean(reader["EsAdministrador"]),
                Fecha_Registro = Convert.ToDateTime(reader["Fecha_Registro"])
            };
            empleados.Add(empleado);
        }

        dbConnection.CloseConnection();
        return empleados;
    }


    public void AgregarEmpleado(Empleado empleado)
    {
        string query = "INSERT INTO Empleados (Nombre_Empleado, Correo_Empleado, Contraseña, EsAdministrador) VALUES (@Nombre, @Correo, @Contraseña, @EsAdministrador)";

        dbConnection.OpenConnection();
        MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
        cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre_Empleado);
        cmd.Parameters.AddWithValue("@Correo", empleado.Correo_Empleado);
        cmd.Parameters.AddWithValue("@Contraseña", empleado.Contraseña);
        cmd.Parameters.AddWithValue("@EsAdministrador", empleado.EsAdministrador);
        cmd.ExecuteNonQuery();
        dbConnection.CloseConnection();
    }

    public void ActualizarEmpleado(Empleado empleado)
    {
        string query = "UPDATE Empleados SET Nombre_Empleado = @Nombre, Correo_Empleado = @Correo, Contraseña = @Contraseña, EsAdministrador = @EsAdministrador WHERE ID_Empleado = @ID_Empleado";

        dbConnection.OpenConnection();
        MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
        cmd.Parameters.AddWithValue("@ID_Empleado", empleado.ID_Empleado);
        cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre_Empleado);
        cmd.Parameters.AddWithValue("@Correo", empleado.Correo_Empleado);
        cmd.Parameters.AddWithValue("@Contraseña", empleado.Contraseña);
        cmd.Parameters.AddWithValue("@EsAdministrador", empleado.EsAdministrador);
        cmd.ExecuteNonQuery();
        dbConnection.CloseConnection();
    }

    public void EliminarEmpleado(int idEmpleado)
    {
        string query = "DELETE FROM Empleados WHERE ID_Empleado = @ID_Empleado";

        dbConnection.OpenConnection();
        MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
        cmd.Parameters.AddWithValue("@ID_Empleado", idEmpleado);
        cmd.ExecuteNonQuery();
        dbConnection.CloseConnection();
    }
}
