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
        public ActionResult ddd()
        {

            return View();
        }
        // GET: KL
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
        /// 库位管理分页
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public ActionResult Get_kuweiAll(int PageIndex=1, int PageSize=2)
        {
            return Json(KLmanager.Get_kuweiAll(PageIndex,PageSize),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 库位管理查询
        /// </summary>
        /// <returns></returns>
        public ActionResult Get_kuweiAllss(int WID=0,int KuTypeID=0, string KName=null)
        {
            return Json(KLmanager.Get_kuweiAllss(WID,KuTypeID, KName), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 新增库位管理
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public ActionResult Get_kuweiInsert(storage s)
        {
            s.forbidden = "否";
            s.CreationDate = DateTime.Now;
            s.state = 0;
            return Json(KLmanager.Get_kuweiInsert(s), JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// 库位删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Get_kuweiDel(int id)
        {
            return Json(KLmanager.Get_kuweiDel(id), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 修改状态
        /// </summary>
        /// <param name="TID"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public ActionResult Get_kuweiupdatestate(int TID, int state)
        {
            return Json(KLmanager.Get_kuweiupdatestate(TID,state), JsonRequestBehavior.AllowGet);
        }

       

        /// <summary>
        /// 库位修改
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public ActionResult Get_kuweiupdate(storage s)
        {
            
            return Json(KLmanager.Get_kuweiupdate(s), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 库位根据id查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Get_kuweiByid(int ID)
        {
            return Json(KLmanager.Get_kuweiByid(ID), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 库位类型查询
        /// </summary>
        /// <returns></returns>
        public ActionResult Get_kuweiType()
        {
            return Json(KLmanager.Get_kuweiType(), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 库位仓库查询
        /// </summary>
        /// <returns></returns>
        public ActionResult Get_kuweiwarehouse()
        {
            return Json(KLmanager.Get_kuweiwarehouse(), JsonRequestBehavior.AllowGet);
        }


    }
}