using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MOD;
using BLL;
namespace NewHope.Controllers
{
    public class YQController : Controller
    {

        // GET: YQ
        //计量单位
        public ActionResult jilangdanwei()
        {
            return View();
        }
        //查询
        public ActionResult measurementQurey()
        {
            return Json(YQmanager.measurementQurey(),JsonRequestBehavior.AllowGet);
        }
        //新增
        public ActionResult measurementadd(measurement k)
        {
            return Json(YQmanager.measurementadd(k),JsonRequestBehavior.AllowGet);
        }




        //产品类别
        public ActionResult chanpinlb()
        {
            return View();
        }
        //产品管理
        public ActionResult chanpinguanli()
        {
            return View();
        }
    }
}