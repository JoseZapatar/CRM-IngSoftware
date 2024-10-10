using System;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

public class DatabaseConnection
{
    private MySqlConnection connection;

    public DatabaseConnection()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CRM_Connection"].ConnectionString;
        connection = new MySqlConnection(connectionString);
    }

    public MySqlConnection GetConnection()
    {
        return connection;
    }

    public void OpenConnection()
    {
        if (connection.State == System.Data.ConnectionState.Closed)
        {
            connection.Open();
        }
    }

    public void CloseConnection()
    {
        if (connection.State == System.Data.ConnectionState.Open)
        {
            connection.Close();
        }
    }
}

