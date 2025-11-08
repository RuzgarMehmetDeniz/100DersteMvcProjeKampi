using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AuthorizationController : Controller
    {
        // GET: Authorization
        AdminManager adminmanager = new AdminManager(new EfAdminDal());
        public ActionResult Index()
        {
            var adminvalues = adminmanager.GetList();
            return View(adminvalues);
        }
    }
}