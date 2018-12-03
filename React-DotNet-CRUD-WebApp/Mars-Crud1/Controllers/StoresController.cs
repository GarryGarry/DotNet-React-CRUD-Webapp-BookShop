using Mars_Crud1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mars_Crud1.Controllers
{
    public class StoresController : Controller
    {
        CRUDEntitiesContext db = new CRUDEntitiesContext();
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult GetStoreList()
        {
            var model = db.Stores.Select(x => new StoreViewModel
            {
                Id = x.Id,
                SName = x.SName,
                Address = x.Address

            }).ToList();

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult EditStore(StoreViewModel model)
        {
            var k = db.Stores.Where(x => x.Id == model.Id).FirstOrDefault();

            if (k != null)
            {

                k.SName = model.SName;
                k.Address = model.Address;
                //db.Entry(k).State = EntityState.Modified;
                //db.Stores.Add(k);


            }
            else
            {
                Store c = new Store();
                c.SName = model.SName;
                c.Address = model.Address;
                db.Stores.Add(c);
                db.SaveChanges();

            }
            db.SaveChanges();
            return Json(new { Response = "Error" });

        }

        public ActionResult DeletStore(int id)
        {
            var k = db.Stores.Find(id);
            db.Stores.Remove(k);
            db.SaveChanges();
            return Json(new { Response = "Success" });
        }

    }
}