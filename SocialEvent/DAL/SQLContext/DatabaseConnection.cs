﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL.SQLContext
{
    public class DatabaseConnection
    {
        // LUCAS: Data Source=DESKTOP-6R0TNPL;Initial Catalog=Proftaak;Integrated Security=True
        // THOMAS: Data Source=THOMAS-LAPTOP\SQLEXPRESS;Initial Catalog=Proftaakje;Integrated Security=True
        // BART: Data Source=DESKTOP-6RQU3QV\SQLEXPRESS;Initial Catalog = Proftaak; Integrated Security = True
        private const string connectionString = @"Data Source=""192.168.20.18, 1433"";Initial Catalog=Proftaak;Persist Security Info=True;User ID=sa;Password=Welkom10!";

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
                            if (!reader.IsDBNull(i))
                            {
                                list.Add(reader.GetString(i));
                            }
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
                            if (!reader.IsDBNull(i))
                            {
                                list.Add(reader.GetInt32(i));
                            }
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

                    DateTime output = new DateTime();
                    output = Convert.ToDateTime(reader.GetDateTime(0));
                    Console.WriteLine("Execute reader executed");

                    return DateTime.Today;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return new DateTime(2017, 1, 18);
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
        internal List<decimal> executereaderDecimalList(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    List<decimal> list = new List<decimal>();
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(reader.GetDecimal(0));
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
