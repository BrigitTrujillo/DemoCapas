using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Data
{
    public class DProduct
    {
        private string connection = "Data Source=LAB1504-06\\SQLEXPRESS;Initial Catalog=FacturaDB;User ID=brigit;Password=123456";

       

        public List<Product> ListarProduct()
        {
            List<Product> result = new List<Product>();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                using (SqlCommand command = new SqlCommand("ListarProduct", sqlConnection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    sqlConnection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Product product = new Product();
                        product.product_id = Convert.ToInt32(reader["product_id"]);
                        product.name = reader["name"].ToString();
                        product.price = Convert.ToDecimal(reader["price"]);
                        product.stock = Convert.ToInt32(reader["stock"]);
                        product.active = Convert.ToBoolean(reader["active"]);
                        result.Add(product);
                    }
                    reader.Close();
                }
            }
            return result;
        }
    }
}
