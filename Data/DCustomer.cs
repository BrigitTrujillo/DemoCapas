using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Data
{
    public class DCustomer
    {
        
         string connection = "Data Source=LAB1504-16\\SQLEXPRESS;Initial Catalog=FacturaDB;User ID=brigit;Password=123456";
        
        
        
        public List<Customer> GetByName(string name)
        {
            List<Customer> result = new List<Customer>();

            DCustomer data = new DCustomer();

            var customers = data.GetType();
           
            return null;
        }

    }
}
