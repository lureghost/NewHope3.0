using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace NewHope.Controllers
{
    public class ZZXController : Controller
    {
        // GET: ZZX
        public ActionResult QuanXianFenPei()
        {
            return View();
        }
        public ActionResult BiaoShiFuGuanLi() {

            return View();
        }
        public ActionResult caidanuanli() {

            return View();
        }
        #region 部门
        public ActionResult bumen()
        {
            return View();
        }
        public ActionResult AdminChaXun()
        {
            return Json(ZZXBLL.AdminChaXun(),JsonRequestBehavior.AllowGet);
        }
        #endregion
        public ActionResult juese() {
        return View();
        }
        public ActionResult yuangong() {

            return View();
        }
    }
}