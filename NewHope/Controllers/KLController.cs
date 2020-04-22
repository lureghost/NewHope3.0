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
            s.CreationDate = DateTime.Now;
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

        /// <summary>
        /// 供应商分页
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="Pagesize"></param>
        /// <returns></returns>
        public ActionResult Get_gongyingshangAll(int PageIndex=1, int PageSize=2)
        {
            return Json(KLmanager.Get_gongyingshangAll(PageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 供应商条件查询
        /// </summary>
        /// <param name="GID"></param>
        /// <param name="gystypeName"></param>
        /// <returns></returns>
        public ActionResult Get_gystiaojiAll(int GID = 0,string gystypeName="sb")
        {
            return Json(KLmanager.Get_gystiaojiAll(GID, gystypeName), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 查询供应商类型
        /// </summary>
        /// <returns></returns>
        public ActionResult Get_gysTypeAll()
        {
            return Json(KLmanager.Get_gysTypeAll(), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// “删除”供应商
        /// </summary>
        /// <param name="GID"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public ActionResult Get_gysDel(int GID, int state)
        {
            return Json(KLmanager.Get_gysDel(GID,state), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 新增供应商
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        public ActionResult Get_gysinsert(gysguanli g)
        {
            return Json(KLmanager.Get_gysinsert(g), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 根据供应商id查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Get_gysByid(int id)
        {
            return Json(KLmanager.Get_gysByid(id), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 修改供应商
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        public ActionResult Get_gysUpdate(gysguanli g)
        {
            return Json(KLmanager.Get_gysUpdate(g), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 客户分页
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public ActionResult Get_kehuAll(int PageIndex=1, int PageSize=2)
        {
            return Json(KLmanager.Get_kehuAll(PageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 客户修改状态("删除")
        /// </summary>
        /// <param name="kehuID"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public ActionResult Get_kehuDel(int kehuID, int state)
        {
            return Json(KLmanager.Get_kehuDel(kehuID, state), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 客户新增
        /// </summary>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public ActionResult Get_kehuinsert(customer c)
        {
            c.CreationDate = DateTime.Now;
            c.state = 0;
            return Json(KLmanager.Get_kehuinsert(c), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 地址新增
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public ActionResult Get_kehuinsertdizhi(dizhi d)
        {
            d.state = 0;
            return Json(KLmanager.Get_kehuinsertdizhi(d), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 查询地址
        /// </summary>
        /// <returns></returns>
        public ActionResult Get_dizhibyid()
        {
            return Json(KLmanager.Get_dizhibyid(), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 根据客户地址id查询地址
        /// </summary>
        /// <param name="dizhiID"></param>
        /// <returns></returns>
        public ActionResult Get_dizhichaid(int dizhiID)
        {
            return Json(KLmanager.Get_dizhichaid(dizhiID), JsonRequestBehavior.AllowGet);
        }
        

        /// <summary>
        /// 根据id查询客户
        /// </summary>
        /// <param name="kehuID"></param>
        /// <returns></returns>
        public ActionResult Get_kehubyid(int kehuID)
        {
            return Json(KLmanager.Get_kehubyid(kehuID), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 修改客户
        /// </summary>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public ActionResult Get_kehuUpdate(customer c)
        {
            c.CreationDate = DateTime.Now;
            return Json(KLmanager.Get_kehuUpdate(c), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 修改地址状态("删除")
        /// </summary>
        /// <param name="dizhiID"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public ActionResult Get_dizhiDel(int dizhiID, int state)
        {
            return Json(KLmanager.Get_dizhiDel(dizhiID,state), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 修改地址
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public ActionResult Get_dizhiUpdate(dizhi d)
        {
            return Json(KLmanager.Get_dizhiUpdate(d), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 根据条件查询客户
        /// </summary>
        /// <param name="kehuID"></param>
        /// <param name="KehuName"></param>
        /// <returns></returns>
        public ActionResult Get_dizhiNamecha(int kehuID=0, string KehuName="hao")
        {
            return Json(KLmanager.Get_dizhiNamecha(kehuID, KehuName), JsonRequestBehavior.AllowGet);
        }
       

    }
}