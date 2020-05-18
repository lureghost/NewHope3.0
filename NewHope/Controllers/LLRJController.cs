using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MOD;
using BLL;
namespace NewHope.Controllers
{
    public class LLRJController : Controller
    {
        // GET: LRJ
        public ActionResult addpandian()
        {
            return View();
        }
        public ActionResult addtuihuo()
        {
            return View();
        }
        public ActionResult addyikudan()
        {
            return View();
        }
        //盘点模块
        public ActionResult pandian()
        {
            return View();
        }
        public ActionResult Getpandian()
        {
            return Json(LRJmanager.Getpandian(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetpdID(int id)
        {
            return Json(LRJmanager.GetpdID(id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Editpd(panDian pan)
        {
           
            return Json(LRJmanager.Edit(pan), JsonRequestBehavior.AllowGet);
        }
     
        public ActionResult Addpd(panDian pan)
        {
         
            return Json(LRJmanager.Addpandian(pan), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Getzuhepandian(string name,int leibie)
        {
            return Json(LRJmanager.Getzuhepandian(name,leibie), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetBypdxqId(int id)
        {
            return Json(LRJmanager.GetBypdxqId(id), JsonRequestBehavior.AllowGet);
        }
       
        public ActionResult GetpandianSH()
        {
            return Json(LRJmanager.GetpandianSH(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetpandianSH2()
        {
            return Json(LRJmanager.GetpandianSH2(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetpandianSH3()
        {
            return Json(LRJmanager.GetpandianSH3(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Delpandian(int id)
        {
            return Json(LRJmanager.Delpandian(id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetpdPage(int PageIndex, int PageSize)
        {
            return Json(LRJmanager.GetpdPage(PageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }

        //退货模块
        public ActionResult tuihuo()
        {
            return View();
        }
        public ActionResult Gettuihuo()
        {
            return Json(LRJmanager.Gettuihuo(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetthID(int id)
        {
            return Json(LRJmanager.GetthID(id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Editth(tuihuo t)
        {
            t.sum = 1;
            t.state = 0;
            return Json(LRJmanager.Edit(t), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Deltuihuo(int id)
        {
            return Json(LRJmanager.Deltuihuo(id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Addth(tuihuo t)
        {
            t.sum = 1;
            t.state = 0;
            return Json(LRJmanager.Addtuihuo(t), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Getthxq(string n)
        {
            return Json(LRJmanager.Getthxq(n), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetBythxqId(int id)
        {
            return Json(LRJmanager.GetBythxqId(id), JsonRequestBehavior.AllowGet);
        }
     
        public ActionResult GettuihuoSH()
        {
            return Json(LRJmanager.GettuihuoSH(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GettuihuoSH2()
        {
            return Json(LRJmanager.GettuihuoSH2(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GettuihuoSH3()
        {
            return Json(LRJmanager.GettuihuoSH3(), JsonRequestBehavior.AllowGet);
        }
      
        public ActionResult GetthPage(int PageIndex, int PageSize)
        {
            return Json(LRJmanager.GetthPage(PageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }

        //移库模块
        public ActionResult yiku()
        {
            return View();
        }

        public ActionResult yikuSH()
        {
            return View();
        }
        public ActionResult Getyiku()
        {
            return Json(LRJmanager.Getyiku(),JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetyikuID(int id)
        {
            return Json(LRJmanager.GetyikuID(id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Edit(yiku y)
        {
            y.state = 0;
            y.count = 10;
            return Json(LRJmanager.Edit(y), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Del(int id)
        {
            return Json(LRJmanager.Delyikuxq(id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Addyiku(yiku y )
        {
            y.state = 0;
            y.count = 10;
            
            return Json(LRJmanager.Addyiku(y), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Getyikuxq(string y)
        {
            return Json(LRJmanager.Getyikuxq(y), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetyikuxqID(int id)
        {
            return Json(LRJmanager.GetByxqId(id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Getzuheyiku(string id,string startime)
        {
            return Json(LRJmanager.Getzuheyiku(id,startime), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetyikuSH()
        {
            return Json(LRJmanager.GetyikuSH(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetyikuSH2()
        {
            return Json(LRJmanager.GetyikuSH2(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetyikuSH3()
        {
            return Json(LRJmanager.GetyikuSH3(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Delyiku( int id)
        {
            return Json(LRJmanager.Delyiku(id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetyikuPage(int PageIndex,int PageSize)
        {
            return Json(LRJmanager.GetyikuPage(PageIndex,PageSize), JsonRequestBehavior.AllowGet);
        }
    }
}