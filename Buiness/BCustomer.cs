using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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


       
        public List<Customer>ListarCustomer(string name)
        {
            var customers = dCustomer.ListarCustomer();
            var result = customers.Where(x => x.name.Contains( name)).ToList();

            return result;
        }

        public Customer GetById(int id)
        {
            DCustomer dCustomer = new DCustomer();
            List<Customer> customers = dCustomer.ListarCustomer();
            Customer customer = new Customer();

            foreach (var item in customers)
            {
                if (item.customer_id == id)
                {
                    customer = item;
                }
            }
            return customer;
        }



        public List<Customer> GetByName(string name)
        {
            List<Customer> result = new List<Customer>();
            DCustomer dCustomer = new DCustomer();
            var customers = dCustomer.ListarCustomer();

            foreach (var customer in customers)
            {
                if (customer.name == name)
                {
                    result.Add(customer);
                }
            }
            return result;
        }


        public void CreateCustomer(Customer customer) 
        {
            DCustomer dCustomer = new DCustomer();
            dCustomer.CreateCustomer(customer);
        }


        public void DeleteCustomer(int customer_id)
        {
            DCustomer dCustomer = new DCustomer();
            dCustomer.DeleteCustomer(customer_id);
        }

        public void UpdateCustomer(Customer customer)
        {
            DCustomer dCustomer = new DCustomer();
            dCustomer.UpdateCustomer(customer);
        }
    }
}
 