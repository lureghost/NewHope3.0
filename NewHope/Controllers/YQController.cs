using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MOD;
using BLL;
using System.Web.Helpers;

namespace NewHope.Controllers
{
    public class YQController : Controller
    {

        // GET: YQ
        /// <summary>
        /// 计量单位
        /// </summary>
        /// <returns></returns>

        public ActionResult jilangdanwei()
        {
            return View();
        }
        //带条件查询
        public ActionResult dtmeasurementQurey(int MID = 0, string MName = "sb")
        {
            return Json(YQmanager.dtmeasurementQurey(MID, MName), JsonRequestBehavior.AllowGet);
        }
        //分页
        public ActionResult fyqureyAll(int pageIndex, int pageSize)
        {
            return Json(YQmanager.fyqureyAll(pageIndex, pageSize), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetCount(int pageSize)
        {
            return Json(YQmanager.GetCount(pageSize), JsonRequestBehavior.AllowGet);
        }
        //删除状态
        public ActionResult jiliangdanwei_Del(int MID, int state)
        {
            return Json(YQmanager.jiliangdanwei_Del(MID, state), JsonRequestBehavior.AllowGet);
        }
        //删除
        public ActionResult Get_jiliangdanweiDel2(int id)
        {
            return Json(YQmanager.Get_jiliangdanweiDel2(id), JsonRequestBehavior.AllowGet);
        }
        //新增
        public ActionResult measurementadd(measurement k)
        {
            k.state = 0;
            k.CreationDate = DateTime.Now;
            return Json(YQmanager.measurementadd(k), JsonRequestBehavior.AllowGet);
        }
        //根据id查询
        public ActionResult Get_jiliangdanweiByid(int MID)
        {
            return Json(YQmanager.Get_jiliangdanweiByid(MID), JsonRequestBehavior.AllowGet);
        }
        //修改
        public ActionResult Get_jiliangdanweiupdate(measurement m)
        {
            return Json(YQmanager.Get_jiliangdanweiupdate(m), JsonRequestBehavior.AllowGet);
        }



        /// <summary>
        /// 产品类别
        /// </summary>
        /// <returns></returns>

        public ActionResult chanpinlb()
        {
            return View();
        }
        //分页查询
        public ActionResult Get_chanpinglbAll(int pageIndex, int pageSize)
        {
            return Json(YQmanager.Get_chanpinglbAll(pageIndex, pageSize), JsonRequestBehavior.AllowGet);
        }
        //获取行
        public ActionResult GetCountlb(int pageSize)
        {
            return Json(YQmanager.GetCountlb(pageSize), JsonRequestBehavior.AllowGet);
        }
        //带条件查询
        public ActionResult Get_chanpinlbmohucha(int PID = 0, string PName = "sb")
        {
            return Json(YQmanager.Get_chanpinlbmohucha(PID, PName), JsonRequestBehavior.AllowGet);
        }
        //产品新增
        public ActionResult Get_chanpinlbAdd(productType p)
        {
            p.UserID = 1;
            p.CreationDate = DateTime.Now;
            p.state = 0;

            return Json(YQmanager.Get_chanpinlbAdd(p), JsonRequestBehavior.AllowGet);
        }
        //删除状态
        public ActionResult Get_chanpinlbDel(int PID, int state)
        {
            return Json(YQmanager.Get_chanpinlbDel(PID, state));
        }
        //修改带id查询
        public ActionResult Get_chanpinlbById(int PID)
        {
            return Json(YQmanager.Get_chanpinlbById(PID), JsonRequestBehavior.AllowGet);
        }
        //修改
        public ActionResult Get_chanpinlbupdate(productType p)
        {
            return Json(YQmanager.Get_chanpinlbupdate(p), JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// 产品管理
        /// </summary>
        /// <returns></returns>

        public ActionResult chanpinguanli()
        {
            return View();
        }
        //分页查询
        public ActionResult Get_chanpingguanliAll(int pageIndex, int pageSize)
        {
            return Json(YQmanager.Get_chanpingguanliAll(pageIndex, pageSize), JsonRequestBehavior.AllowGet);
        }
        //获取行
        public ActionResult GetCountguanli(int pageSize)
        {
            return Json(YQmanager.GetCountguanli(pageSize), JsonRequestBehavior.AllowGet);
        }
        //类别下拉查询
        public ActionResult Get_lbxiala()
        {
            return Json(YQmanager.Get_lbxiala(), JsonRequestBehavior.AllowGet);
        }
        //条件查询
        public ActionResult Get_chanpinguanlimohucha(string cpID, string cpName, int PID)
        {
            return Json(YQmanager.Get_chanpinguanlimohucha(cpID, cpName, PID), JsonRequestBehavior.AllowGet);
        }
        //单位下拉
        public ActionResult Get_dwxiala()
        {
            return Json(YQmanager.Get_dwxiala(), JsonRequestBehavior.AllowGet);
        }
        //客户下拉
        public ActionResult Get_khxiala()
        {
            return Json(YQmanager.Get_khxiala(), JsonRequestBehavior.AllowGet);
        }
        //仓库下拉
        public ActionResult Get_ckxiala()
        {
            return Json(YQmanager.Get_ckxiala(), JsonRequestBehavior.AllowGet);
        }
        //库位下拉
        public ActionResult Get_cwxiala()
        {
            return Json(YQmanager.Get_cwxiala(), JsonRequestBehavior.AllowGet);
        }
        //新增
        public ActionResult Get_guanliAdd(productguanli p)
        {
            //p.specification = " 移动白色4G";
            p.kucun = 100;
            p.state = 0;
            return Json(YQmanager.Get_guanliAdd(p), JsonRequestBehavior.AllowGet);
        }
        //删除
        public ActionResult Get_chanpinguanliDel(string cpID="0", int state=1)
        {
            return Json(YQmanager.Get_chanpinguanliDel(cpID, state),JsonRequestBehavior.AllowGet);
        }
        //修改带id查询
        public ActionResult Get_chanpinglById(string cpID)
        {
            return Json(YQmanager.Get_chanpinglById(cpID),JsonRequestBehavior.AllowGet);
        }
        //修改
        public ActionResult Get_chanpinglupdate(productguanli p)
        {
            //p.specification =" 移动白色4G";
            p.kucun = 100;
            p.state = 0;
            return Json(YQmanager.Get_chanpinglupdate(p),JsonRequestBehavior.AllowGet);
        }
    }
}