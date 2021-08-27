using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCReactPart2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult getEmployeeList()
        {
            using (MyDatabaseEntities dc = new MyDatabaseEntities())
            {
                var data = dc.Employees.OrderBy(a => a.FirstName).ToList();
                return new JsonResult { Data = data,  JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }
	}
}