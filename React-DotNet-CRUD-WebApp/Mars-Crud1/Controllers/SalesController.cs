using Mars_Crud1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Mars_Crud1.Controllers
{
    public class SalesController : Controller
    {
        CRUDEntitiesContext db = new CRUDEntitiesContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetProductSoldList()
        {

            var model = db.ProductSolds.Select(x => new ProductSoldViewModel
            {

                Id = x.Id,
                CustomerId = x.CustomerId,
                ProductId = x.ProductId,
                StoreId = x.StoreId,
                CName = x.Customer.CName,
                PName = x.Product.PName,
                SName = x.Store.SName,

                DateSold = x.DateSold.ToString()

            }).ToList();
            return Json(model, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetCustomers()
        {

            var List = db.Customers.Select(x => new CustomerViewModel
            {
                Id = x.Id,
                CName = x.CName,
                Address = x.Address
            }).ToList();

            return Json(List, JsonRequestBehavior.AllowGet);

        }
        public ActionResult GetProducts()
        {

            var List = db.Products.Select(x => new ProductViewModel
            {
                Id = x.Id,
                PName = x.PName,
                Price = x.Price

            }).ToList();

            return Json(List, JsonRequestBehavior.AllowGet);

        }

        public ActionResult GetStores()
        {

            var List = db.Stores.Select(x => new StoreViewModel
            {
                Id = x.Id,
                SName = x.SName,
                Address = x.Address
            }).ToList();

            return Json(List, JsonRequestBehavior.AllowGet);

        }

        public ActionResult SaveEditSale(ProductSoldViewModel model)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB"); //dd/MM/yyyy

            ProductSold k = db.ProductSolds.Where(x => x.Id == model.Id).FirstOrDefault();

            if (k != null)
            {
                k.CustomerId = model.CustomerId;
                k.ProductId = model.ProductId;
                k.StoreId = model.StoreId;
                //k.DateSold = Convert.ToDateTime(model.DateSold);
                k.DateSold = DateTime.Parse(model.DateSold);
                //k.DateSold = DateTime.ParseExact(model.DateSold, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            }
            else
            {
                ProductSold pro = new ProductSold();
                pro.ProductId = model.ProductId;
                pro.CustomerId = model.CustomerId;
                pro.StoreId = model.StoreId;
                pro.StoreId = model.StoreId;
                pro.DateSold = DateTime.Parse(model.DateSold);
                //pro.DateSold = DateTime.ParseExact(model.DateSold, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                db.ProductSolds.Add(pro);
                db.SaveChanges();

            }

            db.SaveChanges();
            return Json(new { Response = "Success" });

        }

        public ActionResult DeleteSale(int id)
        {
            ProductSold k = db.ProductSolds.Find(id);
            db.ProductSolds.Remove(k);
            db.SaveChanges();
            return Json(new { Response = "Success" });
        }
    }

}