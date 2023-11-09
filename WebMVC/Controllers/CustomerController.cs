using Buiness;
using Data;
using Entity;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Serialization.Json;
using System.Xml.Linq;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: CustomerController1
        public ActionResult Index()
        {
           

            BCustomer bCustomer = new BCustomer();
            List<Customer> customers = bCustomer.ListarCustomer("");

            List<CustomerModel> models = new List<CustomerModel>();
            models= customers.Select(x=>new CustomerModel
            {
                customer_id= x.customer_id,
                name = x.name,
                phone = x.phone,

            }).ToList();

            return View(models);
        }


        // GET: CustomerController1/Details/5
        public ActionResult Details(int id)
        {

            BCustomer bCustomer = new BCustomer();
            Customer customer = bCustomer.GetById(id);
            CustomerModel customerModel = new CustomerModel
            {
                customer_id =customer.customer_id,
                name = customer.name,
                phone = customer.phone

            };
            return View(customerModel);
        }



        public ActionResult Create()
        {
           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerModel model)
        {

            Customer customer1 = new Customer
            {
                customer_id = model.customer_id,
                name = model.name,
                phone = model.phone,

            };
            try
            {
                BCustomer customer = new BCustomer();
                customer.CreateCustomer(customer1);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return View();
            }
        }


    // GET: ProductController/Edit/5
    public ActionResult Edit(int id)
        {
            BCustomer bCustomer = new BCustomer();
            Customer customer = bCustomer.GetById(id);
            CustomerModel customerModel = new CustomerModel

            {
                customer_id = customer.customer_id,
                name= customer.name,
                phone = customer.phone

            };

            return View(customerModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CustomerModel model)
        {
            Customer customer = new Customer
            {
                customer_id = model.customer_id,
                name = model.name,
                phone = model.phone
            };

            try
            {
                BCustomer bCustomer = new BCustomer();
                bCustomer.UpdateCustomer(customer);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return View();
            }
        }


        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            BCustomer bCustomer = new BCustomer();
            Customer customer = bCustomer.GetById(id);
            Console.WriteLine(customer);
            CustomerModel customerModel = new CustomerModel
            {
                customer_id = customer.customer_id,
                name = customer.name,
                phone = customer.phone
            };

            return View(customerModel);
        }





        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, CustomerModel model)
        {
            try
            {
                BCustomer bCustomer = new BCustomer();
                bCustomer.DeleteCustomer(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }






   

    }


}

