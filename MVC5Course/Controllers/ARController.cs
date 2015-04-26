using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class ARController : BaseController
    {
        // GET: AR
        public ActionResult Index()
        {
            return View("View1");
        }
        public ActionResult FileDownload1()
        {
            Byte[] content = System.IO.File.ReadAllBytes(Server.MapPath("~/content/love-bird.jpg"));

            return File(content,"image/jpeg");
        }
        public ActionResult FileDownload2()
        {
            //Byte[] content = System.IO.File.ReadAllBytes(Server.MapPath("~/content/love-bird.jpg"));

            return File(Server.MapPath("~/content/love-bird.jpg"), "image/jpeg");
        }

        public ActionResult FileDownload3()
        {
            //Byte[] content = System.IO.File.ReadAllBytes(Server.MapPath("~/content/love-bird.jpg"));
            
            var wc =new WebClient();
            var content= wc.DownloadData("http://upload.wikimedia.org/wikipedia/commons/0/03/Mountain_Bluebird.jpg");

            return File(content, "image/jpeg","Fil1abc.jpg");
        }

        public ActionResult FileDownload4()
        {
            //Byte[] content = System.IO.File.ReadAllBytes(Server.MapPath("~/content/love-bird.jpg"));

            var wc = new WebClient();
            var content = wc.DownloadData("http://upload.wikimedia.org/wikipedia/commons/0/03/Mountain_Bluebird.jpg");

            return File(content, "text/plain");
        }
        public ActionResult JsonClients1()
        {
            repoClient.UnitOfWork.LazyLoadingEnabled = false;
            var clientData= repoClient.All().Take(10).ToList();

            return Json(clientData,JsonRequestBehavior.AllowGet);
        }

        public ActionResult RedirectAction1()
        {
            return RedirectToAction("FileDownload4");
        }
    }
}