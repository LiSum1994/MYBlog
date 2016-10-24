using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace zkf1017.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Welcome()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        /// <summary>
        /// 新闻列表
        /// </summary>
        /// <returns></returns>
        public ActionResult News()
        {
            // ViewBag.Message = "Your News page.";
            string[] data = new string[] { "sdfsdfsdfsdf", "123132456465", "pppppppppppppp" };
            ViewBag.data = data;
            ViewData["data"] = data;

            return View();
        }
    }
}