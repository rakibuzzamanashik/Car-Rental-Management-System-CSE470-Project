using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class RentController : Controller
    {

        supercarEntities db = new supercarEntities();
        //
        // GET: /Rent/
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Getcarfun()
        {
            
            var car = db.carRegs.ToList();

            return Json(car, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Getidk(int id)
        {

            var customer = (from s in db.customers where s.ID == id select s.Name).ToList();

            return Json(customer, JsonRequestBehavior.AllowGet);
        }





        [HttpPost]
        public ActionResult Save(rental rent)
        {

            db.rentals.Add(rent);
            var car = db.carRegs.SingleOrDefault(e => e.Car_Number == rent.carid);


            db.Entry(car).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");

                return View(rent);


            
        }







	}
}