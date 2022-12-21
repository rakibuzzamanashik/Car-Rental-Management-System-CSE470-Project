using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    
    
    public class returncarController : Controller
    {
        supercarEntities db = new supercarEntities();
        //
        // GET: /returncar/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Getid(String carno)
        {
            var carn = (from s in db.rentals
                        where s.carid == carno
                        select new
                        {
                            StartDate = s.sdate,
                            EndDate = s.edate,
                            Custid = s.custid,
                            CarNo = s.carid,

                            Fee = s.fee,
                            ElapsedDays = SqlFunctions.DateDiff("day", s.edate, DateTime.Now)

                        }).ToArray();

            return Json(carn, JsonRequestBehavior.AllowGet);
                            
                            
                            
                            
                            
        }

	}
}