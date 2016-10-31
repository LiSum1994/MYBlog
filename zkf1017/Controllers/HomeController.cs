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
        public ActionResult NewsList(int page = 10)
        {
            string[] data = new string[] { "燃油车的终极黑科技，新能源车平民化时代的开启",
                "为什么马云不上淘宝，而刘强东一天两单？" ,
                "中国人的一天：望女成凤",
                "沈阳最低气温零下 10 摄氏度 道路结冰"};

            ViewBag.data = data;
            ViewBag.Page = page;

            //ViewData["data"] = data;
            //ViewData.Model = data;
            return View();
        }

       


        /// <summary>
        /// 添加新闻
        /// </summary>
        /// <returns></returns>
        public ActionResult Add()
        {
            return View();
        }

        /// <summary>
        /// 保存新闻内容
        /// </summary>
        /// <returns></returns>
        public ActionResult Save(string title, string content)
        {
            ViewBag.Title = title;
            ViewBag.Content = content;
            return View();
        }

    }
}