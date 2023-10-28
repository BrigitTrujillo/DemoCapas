using Buiness;
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
            return View();
        }

        // GET: CustomerController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
