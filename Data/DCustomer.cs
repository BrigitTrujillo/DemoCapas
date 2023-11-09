using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace Data
{
    public class DCustomer
    {

        public static string connectionString ="Data Source=DESKTOP-90DN5US\\SQLEXPRESS;Initial Catalog=FacturaDB;User ID=brigit;Password=123456";

        public List<Customer> ListarCustomer()
        {
            List<Customer> result = new List<Customer>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("ListarCustomer", sqlConnection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    sqlConnection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Customer customer = new Customer();
                        customer.customer_id = Convert.ToInt32(reader["customer_id"]);
                        customer.name = reader["name"].ToString();
                        customer.address = reader["address"].ToString();
                        customer.phone = reader["phone"].ToString();
                        customer.active = Convert.ToBoolean(reader["active"]);
                        result.Add(customer);
                    }
                    reader.Close();
                }
            }
            return result;
        }

        public void UpdateCustomer(Customer customer)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand("UpdateCustomer", sqlConnection)) // "ActualizarCustomer" é o nome do seu procedimento armazenado
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@customer_id", customer.customer_id);
                    command.Parameters.AddWithValue("@name", customer.name);
                    command.Parameters.AddWithValue("@address", customer.address);
                    command.Parameters.AddWithValue("@phone", customer.phone);
                    command.Parameters.AddWithValue("@active", customer.active);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void CreateCustomer(Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("CreateCustomer", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@customer_id", customer.customer_id);
                    command.Parameters.AddWithValue("@name", customer.name);
                    command.Parameters.AddWithValue("@address", customer.address);
                    command.Parameters.AddWithValue("@phone", customer.phone);
                    command.Parameters.AddWithValue("@active", customer.active);
                    command.ExecuteNonQuery();
                }
            }
        }




        public void DeleteCustomer(int customerId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("DeleteCustomer", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@customer_id", customerId);
                    command.ExecuteNonQuery();
                }
            }
        }




    }
}