using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ofinger
{
	internal class Database
	{
		private MySqlConnection connection;
		private string connectionString;

		public Database()
		{
			// Create the connection string
			connectionString = $"Server=localhost;Database=ofinger;User ID=root;Password=;";

			// Initialize the MySqlConnection object
			connection = new MySqlConnection(connectionString);
		}

		public void OpenConnection()
		{
			try
			{
				if (connection.State == System.Data.ConnectionState.Closed)
				{
					connection.Open();
					Console.WriteLine("Database connection opened.");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error: {ex.Message}");
			}
		}

		public void CloseConnection()
		{
			try
			{
				if (connection.State == System.Data.ConnectionState.Open)
				{
					connection.Close();
					Console.WriteLine("Database connection closed.");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error: {ex.Message}");
			}
		}

		public MySqlConnection GetConnection()
		{
			return connection;
		}
	}
}
