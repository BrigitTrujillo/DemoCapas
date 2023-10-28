using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entity;

namespace Buiness
{
    public class BCustomer
    {
        private DCustomer dCustomer;
        public BCustomer()
        {
            dCustomer = new DCustomer();
        }

        public void InsertarCustomer(Entity.Customer customer)
        {
            dCustomer.InsertarCustomer(customer); 
        }

        public List<Customer>ListarCustomer(string name)
        {
            var customers = dCustomer.ListarCustomer();
            var result = customers.Where(x => x.name.Contains( name)).ToList();

            return result;
        }

    }
}
 