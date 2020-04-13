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
        public ActionResult ruku() {

            return View();
        }
        public ActionResult rukuadd()
        {

            return View();
        }
        public ActionResult chuku()
        {

            return View();
        }
        public ActionResult chukuadd()
        {

            return View();
        }
        public ActionResult baosun()
        {

            return View();
        }
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