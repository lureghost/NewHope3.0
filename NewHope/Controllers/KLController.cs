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
       
        // GET: KL
        /// <summary>
        /// 库位管理
        /// </summary>
        /// <returns></returns>
        public ActionResult kuwei()
        {
            return View("/Views/KL/kuwei.cshtml");
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
        /// 库位管理分页
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public ActionResult Get_kuweiAll(int PageIndex,int PageSize)
        {
            return Json(KLmanager.Get_kuweiAll(PageIndex,PageSize),JsonRequestBehavior.AllowGet);
        }
        

        /// <summary>
        /// 库位查询所有
        /// </summary>
        /// <returns></returns>
        public ActionResult Get_kuweiAlls()
        {
            return Json(KLmanager.Get_kuweiAlls(), JsonRequestBehavior.AllowGet);
        }

       
    }
}