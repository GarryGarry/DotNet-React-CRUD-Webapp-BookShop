using Mars_Crud1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mars_Crud1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        CRUDEntitiesContext db = new CRUDEntitiesContext();
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult GetCustomerList()
        {
            var model = db.Customers.Select(x => new CustomerViewModel
            {
                Id = x.Id,
                CName = x.CName,
                Address = x.Address

            }).ToList();

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult EditCustomer(CustomerViewModel model )
        {
            var k = db.Customers.Where(x => x.Id == model.Id).FirstOrDefault();

            if (k != null)
            {
               
                k.CName = model.CName;
                k.Address = model.Address;
                //db.Entry(k).State = EntityState.Modified;
                //db.Customers.Add(k);


            }
            else
            {
                Customer c = new Customer();
                c.CName = model.CName;
                c.Address = model.Address;               
                db.Customers.Add(c);
                db.SaveChanges();

            }
            db.SaveChanges();
            return Json(new { Response = "Error" });

        }

        public ActionResult DeletCustomer(int id)
        {
            var k = db.Customers.Find(id);
            db.Customers.Remove(k);
            db.SaveChanges();
            return Json(new { Response = "Success" });
        }
    }
}