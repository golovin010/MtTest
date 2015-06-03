using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSite.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(object empty)
        {
            ViewBag.Date = DateTime.UtcNow;
            return View("Index");
        }
        [HttpPost]
        public JsonResult GetRequestTimeAjax()
        {
            return Json(DateTime.UtcNow);
        }

    }
}
