using Microsoft.Data.SqlClient;

const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$";

var connection = new SqlConnection(CONNECTION_STRING);
connection.Open();

connection.Close();
Console.ReadKey();