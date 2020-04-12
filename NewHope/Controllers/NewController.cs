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
        public ActionResult test22()
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
        /// 部门管理呀
        /// </summary>
        /// <returns></returns>
        public ActionResult bumen()
        {
            return View();
        }
        /// <summary>
        /// 移库管理
        /// </summary>
        /// <returns></returns>
        public ActionResult yiku()
        {
            return View();
        }
        /// <summary>
        /// 新增移库单
        /// </summary>
        /// <returns></returns>
        public ActionResult addyikudan()
        {
            return View();
        }
        /// <summary>
        /// 盘点管理
        /// </summary>
        /// <returns></returns>
        public ActionResult pandian()
        {
            return View();
        }
        /// <summary>
        /// 新增盘点
        /// </summary>
        /// <returns></returns>
        public ActionResult addpandian()
        {
            return View();
        }
        /// <summary>
        /// 退货管理
        /// </summary>
        /// <returns></returns>
        public ActionResult tuihuo()
        {
            return View();
        }
        /// <summary>
        /// 新增退货
        /// </summary>
        /// <returns></returns>
        public ActionResult addtuihuo()
        {
            return View();
        }
    }
}