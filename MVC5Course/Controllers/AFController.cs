using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class AFController : Controller
    {
        // GET: AF
        public ActionResult Index()
        {
            return View();
        }

        [HandleError(Master="",ExceptionType=typeof(ArgumentException),View="Error.Argument")]
        public ActionResult ErrorTest(string t)
        {
            if (t == "test")
            {
                throw new ArgumentException("test");
            }
            else
            {
                throw new Exception("test");

            }
        }
    }
}