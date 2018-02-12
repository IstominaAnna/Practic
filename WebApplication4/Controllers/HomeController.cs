using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4;
using WebApplication4.Models;
using System.Data.Entity;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        Context db = new Context();

        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult AboutRunners()
        //{
        //    //var Items = db.Runners;
        //    //return View(Items);
        //    var players = db.Runners.Include(p => p.User);
        //    return View(players.ToList());
        //}

        public ActionResult Page1()
        {
            return View();
        }
        public ActionResult Page2()
        {
            return View();
        }
        public ActionResult Page3()
        {
            return View();
        }
        public ActionResult Page4()
        {
            return View();
        }
        //public ActionResult About(int item_id)
        //{
        //    var Item = db.Runners.FirstOrDefault(x => x.RunnerId == item_id);

        //    return View(Item);
        //}


    }
}