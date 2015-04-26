using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class MBController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Ms1"] = "test1";
            ViewBag.Ms2 = "test2";
            TempData["Ms3"] = "test3";
            Session["Ms4"] = "test4";
            return RedirectToAction("view1");
        }

        public ActionResult view1()
        {
            //TempData["Ms3"] = "";

            foreach (var s in TempData)
            {
                string aa= s.ToString();
            }
            return View();
        }
    }
}