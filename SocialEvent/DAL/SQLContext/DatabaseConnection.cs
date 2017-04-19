using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL.SQLContext
{
    public class DatabaseConnection
    {
        private const string connectionString = @"Data Source=THOMAS-LAPTOP\SQLEXPRESS;Initial Catalog=Proftaakje;Integrated Security=True";

        internal bool executeNonQuery(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Connection established");

                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Execute reader executed");

                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return false;
        }

        internal string executeReaderString(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Connection established");

                    SqlCommand command = new SqlCommand(query, connection);
                    if (command.ExecuteScalar() != null)
                    {
                        Console.WriteLine("Execute reader executed");
                        return Convert.ToString(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return null;
        }

        internal List<string> executeReaderStringList(string query, int amount)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    List<string> list = new List<string>();
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < amount; i++)
                        {
                            list.Add(reader.GetString(i));
                        }
                    }
                    return list;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }
            return null;
        }

        internal int executeReaderInt(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Connection established");

                    SqlCommand command = new SqlCommand(query, connection);
                    if (command.ExecuteScalar() != null)
                    {
                        Console.WriteLine("Execute reader executed");
                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return -1;
        }

        internal List<int> executeReaderIntList(string query, int amount)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    List<int> list = new List<int>();
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < amount; i++)
                        {
                            list.Add(reader.GetInt32(i));
                        }
                    }
                    return list;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }
            return null;
        }

        internal DateTime? executeReaderDateTime(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Connection established");

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                        Console.WriteLine("Execute reader executed");
                    return Convert.ToDateTime(reader.GetSqlDateTime(5));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return null;
        }

        internal List<double> executeReaderDoubleList(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    List<double> list = new List<double>();
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(reader.GetDouble(0));
                    }
                    return list;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }
            return null;
        }
    }
}
