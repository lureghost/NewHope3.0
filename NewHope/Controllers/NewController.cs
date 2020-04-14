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
       
        

        /// <summary>
        /// 部门管理
        /// </summary>
        /// <returns></returns>
        public ActionResult bumen()
        {
            return View();
        }


       
        //菜单管理
        public ActionResult caidanuanli()
        {
            return View();
        }
        //zzx标识符管理
        public ActionResult BiaoShiFuGuanLi()
        {
            return View();
        }
        //zzx权限分配
        public ActionResult QuanXianFenPei()
        {
            return View();
        }
    }
}