using Mars_Crud1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mars_Crud1.Controllers
{
    public class ProductsController : Controller
    {
        CRUDEntitiesContext db = new CRUDEntitiesContext();
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult GetProductList()
        {
            var model = db.Products.Select(x => new ProductViewModel
            {
                Id = x.Id,
                PName = x.PName,
                Price = x.Price

            }).ToList();

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult EditProduct(ProductViewModel model)
        {
            var k = db.Products.Where(x => x.Id == model.Id).FirstOrDefault();

            if (k != null)
            {

                k.PName = model.PName;
                k.Price = model.Price;
                //db.Entry(k).State = EntityState.Modified;
                //db.Products.Add(k);


            }
            else
            {
                Product c = new Product();
                c.PName = model.PName;
                c.Price = model.Price;
                db.Products.Add(c);
                db.SaveChanges();

            }
            db.SaveChanges();
            return Json(new { Response = "Error" });

        }

        public ActionResult DeletProduct(int id)
        {
            var k = db.Products.Find(id);
            db.Products.Remove(k);
            db.SaveChanges();
            return Json(new { Response = "Success" });
        }
    
}
}