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
        //带条件查询
        public ActionResult dtmeasurementQurey(string MName)
        {
            return Json(YQmanager.dtmeasurementQurey(MName), JsonRequestBehavior.AllowGet);
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
        public ActionResult jiliangdanwei_Del(int MID, int state) {
            return Json(YQmanager.jiliangdanwei_Del(MID,state),JsonRequestBehavior.AllowGet);
        }
        //删除
        public ActionResult Get_jiliangdanweiDel2(int id) {
            return Json(YQmanager.Get_jiliangdanweiDel2(id),JsonRequestBehavior.AllowGet);
        }
        //新增
        public ActionResult measurementadd(measurement k)
        {
            k.state = 0;
            k.CreationDate = DateTime.Now;
            return Json(YQmanager.measurementadd(k),JsonRequestBehavior.AllowGet);
        }
        //根据id查询
        public ActionResult Get_jiliangdanweiByid(int MID) {
            return Json(YQmanager.Get_jiliangdanweiByid(MID),JsonRequestBehavior.AllowGet);
        }
        //修改
        public ActionResult Get_jiliangdanweiupdate(measurement m) {
            return Json(YQmanager.Get_jiliangdanweiupdate(m), JsonRequestBehavior.AllowGet);
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