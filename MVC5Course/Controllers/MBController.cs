using MVC5Course.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class MBController : BaseController
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

        public ActionResult SimpleBind1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SimpleBind1(string UserName,string Password)
        {
            ViewBag.result = "SimpleBind1-UserName : " + UserName + ",Password : " + Password;
            return View("ShowBindResult");
        }


        public ActionResult SimpleBind2()
        {
            return View("SimpleBind1");
        }

        [HttpPost]
        public ActionResult SimpleBind2(FormCollection Form)
        {
            ViewBag.result = "SimpleBind2-UserName : " + Form["UserName"] + ",Password : " + Form["Password"];
            return View("ShowBindResult");
        }


        public ActionResult ComplexBind1()
        {
            return View("SimpleBind1");
        }

        [HttpPost]
        public ActionResult ComplexBind1(SimpleViewModel svm)
        {
            ViewBag.result = "ComplexBind1-UserName : " + svm.UserName + ",Password : " + svm.Password;
            return View("ShowBindResult");
        }

        public ActionResult ComplexBind2()
        {
            return View("SimpleBind1");
        }

        [HttpPost]
        public ActionResult ComplexBind2(SimpleViewModel item1, SimpleViewModel item2)
        {
            ViewBag.result = "ComplexBind1-UserName : " + item1.UserName + ",Password : " + item1.Password;
            return View("ShowBindResult");
        }

        public ActionResult ComplexBind3()
        {

            var data = from i in db.Client
                       select new SimpleViewModel
                       {
                            UserName=i.FirstName,
                            Password=i.LastName,
                            age=18
                       };
                     
            return View(data.Take(10));
        }

        [HttpPost]
        public ActionResult ComplexBind3(IList<SimpleViewModel> item)
        {

            return Content("");
        }
    }
}