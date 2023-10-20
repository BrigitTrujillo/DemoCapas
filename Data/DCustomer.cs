using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace Data
{
    public class DCustomer
    {
        private string connection = "Data Source=DESKTOP-90DN5US\\SQLEXPRESS;Initial Catalog=FacturaDB;User ID=brigit;Password=123456";

        public void InsertarCustomer(Customer customer)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("SET IDENTITY_INSERT customers ON", sqlConnection);
                command.ExecuteNonQuery();

                command = new SqlCommand("InsertarCustomers", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@customer_id", customer.customer_id);
                command.Parameters.AddWithValue("@name", customer.name);
                command.Parameters.AddWithValue("@address", customer.address);
                command.Parameters.AddWithValue("@phone", customer.phone);
                command.Parameters.AddWithValue("@active", customer.active);

                command.ExecuteNonQuery();

                command = new SqlCommand("SET IDENTITY_INSERT customers OFF", sqlConnection);
                command.ExecuteNonQuery();
            }
        }

        public List<Customer> ListarCustomer()
        {
            List<Customer> result = new List<Customer>();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
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
    }
}
