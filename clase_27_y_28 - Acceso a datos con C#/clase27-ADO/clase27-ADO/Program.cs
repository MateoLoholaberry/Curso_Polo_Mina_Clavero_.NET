using System.Data.SqlClient;

var connectionString = @"Server=MATEO\SQLEXPRESS;Database=Northwind;Trusted_Connection=yes;";


using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();
    var command = new SqlCommand("SELECT * FROM Customers", connection);
    var reader = command.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine($"{reader["CustomerID"]} | {reader["CompanyName"]} | {reader["ContactName"]}");
    }
}

