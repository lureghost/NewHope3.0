using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
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