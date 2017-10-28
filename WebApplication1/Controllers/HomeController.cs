using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           var t = ControllerContext.RouteData.Values["id"];
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact(string msg)
        {
            ViewBag.Message = msg;
            if (ViewData.Model == null)
            {
                ViewData.Model = new Contact() { Name = msg };
            }
            return View();
        }
        [HttpPost]
        public ActionResult Contact(Contact c)
        {
            ViewBag.Message = c.Name;
            if (ViewData.Model == null) ViewData.Model = c;
            return View();
        }

    }
}