using MySql.Data.MySqlClient;

public class GestionTareas
{
    private DatabaseConnection dbConnection;

    public GestionTareas()
    {
        dbConnection = new DatabaseConnection();
    }

    public void AgregarTarea(int idEmpleado, string titulo, string descripcion)
    {
        string query = "INSERT INTO Tareas (ID_Empleado, Titulo, Descripcion) VALUES (@ID_Empleado, @Titulo, @Descripcion)";
        dbConnection.OpenConnection();
        MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
        cmd.Parameters.AddWithValue("@ID_Empleado", idEmpleado);
        cmd.Parameters.AddWithValue("@Titulo", titulo);
        cmd.Parameters.AddWithValue("@Descripcion", descripcion);
        cmd.ExecuteNonQuery();
        dbConnection.CloseConnection();
    }
}
