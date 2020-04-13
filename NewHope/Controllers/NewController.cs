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
        public ActionResult test2233()
        {

            return View();
        }

        /// <summary>
        /// 库位管理
        /// </summary>
        /// <returns></returns>
        public ActionResult kuwei()
        {
            return View();
        }

        /// <summary>
        /// 供应商管理
        /// </summary>
        /// <returns></returns>
        public ActionResult gongyingshang()
        {
            return View();
        }

        /// <summary>
        /// 客户管理
        /// </summary>
        /// <returns></returns>
        public ActionResult kehu()
        {
            return View();
        }

        /// <summary>
        /// 张志雄的部门管理呀
        /// </summary>
        /// <returns></returns>
        public ActionResult bumen()
        {
            return View();
        }
        /// <summary>
        /// 张志雄的权限分配
        /// </summary>
        /// <returns></returns>
        public ActionResult QuanXianFenPei()
        {
            return View();
        }
        public ActionResult ceshi()
        {
            return View();
        }
        /// <summary>
        /// 张志雄的标识符管理
        /// </summary>
        /// <returns></returns>
        public ActionResult BiaoShiFuGuanLi()
        {
            return View();
        }
    }
}