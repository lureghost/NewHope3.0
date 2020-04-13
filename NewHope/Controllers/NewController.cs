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
       
        //农翔-入库页面
        public ActionResult ruku() {

            return View();
        }
        //农翔-入库添加页面
        public ActionResult rukuadd()
        {

            return View();
        }
        //农翔-出库页面
        public ActionResult chuku()
        {

            return View();
        }
        //出库添加页面
        public ActionResult chukuadd()
        {

            return View();
        }
        //农翔-报损管理页面
        public ActionResult baosun()
        {

            return View();
        }
        //农翔-报损添加页面
        public ActionResult baosunadd()
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
        //菜单管理
        public ActionResult caidanuanli()
        {
            return View();
        }
    }
}