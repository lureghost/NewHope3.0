﻿using System;
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
        //农翔-入库管理
        public ActionResult ruku() {

            return View();
        }
        //入库新增
        public ActionResult rukuadd() {

            return View();
        }
        //农翔-出库管理
        public ActionResult chuku() {

            return View();
        }
        //出库新增
        public ActionResult chukuadd() {

            return View();
        }
        //农翔-报损管理
        public ActionResult baosun() {

            return View();
        }
        //报损新增
        public ActionResult baosunadd() {

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
    }
}