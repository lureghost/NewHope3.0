using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewHope.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult test() {

            return View();
        }

        /// <summary>
        /// 测试
        /// </summary>
        /// <returns></returns>
        public ActionResult ceshi()
        {

            return View();
        }
    }
}