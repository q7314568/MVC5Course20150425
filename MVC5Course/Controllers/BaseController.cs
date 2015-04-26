using MVC5Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public abstract class BaseController : Controller
    {
        protected ClientRepository repoClient = RepositoryHelper.GetClientRepository();
        protected OccupationRepository occRepo = RepositoryHelper.GetOccupationRepository();
        protected FabricsEntities db = new FabricsEntities();
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
                repoClient.UnitOfWork.Context.Dispose();

            }
            base.Dispose(disposing);
        }
#if DEBUG
        public bool Debug()
        {
            return true;
        }
#endif
       
    }
}