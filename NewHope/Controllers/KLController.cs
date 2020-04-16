using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MOD;
using BLL;

namespace NewHope.Controllers
{
    public class KLController : Controller
    {
        public ActionResult ddd()
        {

            return View();
        }
        // GET: KL
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

        public ActionResult Get_kuweiAll(int PageIndex, int PageSize)
        {
            return Json(KLmanager.Get_kuweiAll(PageIndex,PageSize),JsonRequestBehavior.AllowGet);
        }
    }
}