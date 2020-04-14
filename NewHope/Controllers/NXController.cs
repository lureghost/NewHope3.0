using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewHope.Controllers
{
    public class NXController : Controller
    {

        
        // GET: NX
        //农翔-入库管理
        public ActionResult ruku()
        {

            return View();
        }
        //农翔-入库新增
        public ActionResult rukuadd()
        {

            return View();
        }
        //农翔-出库管理
        public ActionResult chuku()
        {

            return View();
        }
        //出库新增
        public ActionResult chukuadd()
        {

            return View();
        }
        //农翔-报损管理
        public ActionResult baosun()
        {

            return View();
        }
        //报损新增
        public ActionResult baosunadd()
        {

            return View();
        }
    }
}