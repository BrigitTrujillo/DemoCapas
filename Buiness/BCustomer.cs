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

        public void InsertarCustomer(Entity.Customer customer) // Asegúrate de usar Entity.Customer
        {
            dCustomer.InsertarCustomer(customer); // Pasar el objeto de tipo Entity.Customer
        }

        public List<Customer>ListarCustomer()
        {
            return dCustomer.ListarCustomer();
        }

    }
}
