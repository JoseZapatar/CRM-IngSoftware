using MySql.Data.MySqlClient;
using System;

public class GestionEventos
{
    private DatabaseConnection dbConnection;

    public GestionEventos()
    {
        dbConnection = new DatabaseConnection();
    }

    public void AgregarEvento(int? idCliente, int idEmpleado, string titulo, string descripcion, DateTime fechaEvento, string tipoEvento)
    {
        string query = "INSERT INTO Eventos_Calendario (ID_Cliente, ID_Empleado, Titulo, Descripcion, Fecha_Evento, Tipo_Evento) VALUES (@ID_Cliente, @ID_Empleado, @Titulo, @Descripcion, @Fecha_Evento, @Tipo_Evento)";
        dbConnection.OpenConnection();
        MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
        cmd.Parameters.AddWithValue("@ID_Cliente", idCliente);
        cmd.Parameters.AddWithValue("@ID_Empleado", idEmpleado);
        cmd.Parameters.AddWithValue("@Titulo", titulo);
        cmd.Parameters.AddWithValue("@Descripcion", descripcion);
        cmd.Parameters.AddWithValue("@Fecha_Evento", fechaEvento);
        cmd.Parameters.AddWithValue("@Tipo_Evento", tipoEvento);
        cmd.ExecuteNonQuery();
        dbConnection.CloseConnection();
    }
}
