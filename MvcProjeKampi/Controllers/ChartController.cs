using MvcProjeKampi.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ChartController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CategoryChart()
        {
            List<CategoryClass> categoryClasses = new List<CategoryClass>();

            categoryClasses.Add(new CategoryClass()
            {
                CategoryName = "Yazılım",
                CategoryCount = 8
            });
            categoryClasses.Add(new CategoryClass()
            {
                CategoryName = "Seyahat",
                CategoryCount = 4
            });
            categoryClasses.Add(new CategoryClass()
            {
                CategoryName = "Teknoloji",
                CategoryCount = 6
            });
            categoryClasses.Add(new CategoryClass()
            {
                CategoryName = "Spor",
                CategoryCount = 3
            });

            return Json(categoryClasses, JsonRequestBehavior.AllowGet);
        }
    }

    public class CategoryClass
    {
        public string CategoryName { get; set; }
        public int CategoryCount { get; set; }
    }
}
