using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MOD;
using BLL;
namespace NewHope.Controllers
{
    public class NXController : Controller
    {


        // GET: NX
        //农翔-入库管理

        public ActionResult rukucpcha() {

            return Json(NXmanager.rukucpcha(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult ruku()
        {

            return View();
        }
        //入库删除的方法
        public ActionResult rukudel(ruku rr) {

            return Json(NXmanager.rukudel(rr), JsonRequestBehavior.AllowGet);
        }
        //入库查询所有的方法
        public ActionResult rukuchaall(int pageIndex, int pageSize) {
            

            return Json(NXmanager.rukuchaall(pageIndex,pageSize), JsonRequestBehavior.AllowGet);
        }

        //入库查看的方法
        public ActionResult rukuchakan(int rid) {

            return Json(NXmanager.rukuchakan(rid), JsonRequestBehavior.AllowGet);
        }
        //入库查看的方法-详情
        public ActionResult rukuchakanx(int rxid) {

            return Json(NXmanager.rukuchakanx(rxid), JsonRequestBehavior.AllowGet);
        }
        //入库审核的方法
        public ActionResult rukusheng(ruku rr) {

            return Json(NXmanager.rukusheng(rr), JsonRequestBehavior.AllowGet);
        }

        //入库单号的修改
        public ActionResult rukugai(ruku rr) {

            return Json(NXmanager.rukugai(rr), JsonRequestBehavior.AllowGet);
        }
        //入库查询所有-搜索的方法
        public ActionResult rukuallsou(int rukuid) {

            return Json(NXmanager.rukuallsou(rukuid), JsonRequestBehavior.AllowGet);
        }
        //入库高级查询的方法
        public ActionResult rukugaocha(int gysid, int typeid, string cpid) {

            return Json(NXmanager.gaojicha(gysid, typeid, cpid), JsonRequestBehavior.AllowGet);
        }
        //入库查询所有待审核的方法
        public ActionResult rukudaicha() {

            return Json(NXmanager.daicha(), JsonRequestBehavior.AllowGet);
        }
        //入库查询所有审核成功的方法
        public ActionResult rukutongcha() {

            return Json(NXmanager.tongcha(), JsonRequestBehavior.AllowGet);
        }
        //入库查询所有审核失败的方法
        public ActionResult rukubaicha()
        {

            return Json(NXmanager.baicha(), JsonRequestBehavior.AllowGet);
        }

        //农翔-入库新增
        public ActionResult rukuadd()
        {

            return View();
        }
        //入库新增-入库类型下拉框的方法
        public ActionResult rukutype() {

            return Json(NXmanager.rukutypecha(), JsonRequestBehavior.AllowGet);
        }
        //入库新增-供应商下拉框
        public ActionResult rukugys() {

            return Json(NXmanager.rukugys(), JsonRequestBehavior.AllowGet);
        }
        //入库新增—通过供应商id查询的下拉框联动查询方法
        public ActionResult gysidcha(int gysid) {

            return Json(NXmanager.gysidcha(gysid), JsonRequestBehavior.AllowGet);

        }
        //入库新增-产品编号下拉框的查询
        public ActionResult pbianma() {

            return Json(NXmanager.pbianma(), JsonRequestBehavior.AllowGet);
        }
        //入库新增-通过产品编号查询下拉框的方法
        public ActionResult pidcha(string pid) {

            return Json(NXmanager.pidcha(pid), JsonRequestBehavior.AllowGet);
        }
        public ActionResult pidcha2(string pid)
        {

            return Json(NXmanager.pidcha2(pid), JsonRequestBehavior.AllowGet);
        }
        //库位的下拉框
        public ActionResult kutype() {

            return Json(NXmanager.kutype(), JsonRequestBehavior.AllowGet);
        }
        //入库新增-第一层添加
        public ActionResult RKxiangadd(RKxiang pd) {

           
            return Json(NXmanager.RKxiangadd(pd), JsonRequestBehavior.AllowGet);
        }
        //入库新增-查询第一次新增的数据
        public ActionResult T1cha() {

            return Json(NXmanager.T1cha(), JsonRequestBehavior.AllowGet);
        }
        //入库新增-第一次查询的删除
        public ActionResult T1del(RKxiang rr) {

            return Json(NXmanager.T1del(rr), JsonRequestBehavior.AllowGet);
        }
        //入库新增-修改获取id
        public ActionResult T1byid(int rxid) {

            return Json(NXmanager.T1byID(rxid), JsonRequestBehavior.AllowGet);
        }
        //入库新增-第一次查询的修改
        public ActionResult T1upd(RKxiang rk) {

            return Json(NXmanager.T1upd(rk), JsonRequestBehavior.AllowGet);
        }

        //入库新增-第二次添加
        public ActionResult T2add(ruku rr) {

            return Json(NXmanager.T2add(rr), JsonRequestBehavior.AllowGet);
        }
        //入库新增页面-第二次添加时修改rkxiang表中的zt为1
        public ActionResult T2ztupd(RKxiang rr) {

            return Json(NXmanager.T2ztupd(rr), JsonRequestBehavior.AllowGet);

        }
            //农翔-出库管理
            public ActionResult chuku()
        {

            return View();
        }
        public ActionResult chukuadd() {

            return View();
        }
        public ActionResult chukuchaall(int pageIndex, int pageSize)
        {


            return Json(NXmanager.chukuchaall(pageIndex, pageSize), JsonRequestBehavior.AllowGet);
        }

        //出库查询所有-搜索的方法
        public ActionResult chukuallsou(int chukuid)
        {

            return Json(NXmanager.chukuallsou(chukuid), JsonRequestBehavior.AllowGet);
        }
        //出库类型查询
        public ActionResult chukutype() {

            return Json(NXmanager.chukutypecha(), JsonRequestBehavior.AllowGet);
        }

        //出库高级查询的方法
        public ActionResult chukugaocha(int kehuid, int typeid, string cpid)
        {

            return Json(NXmanager.chugaojicha(kehuid, typeid, cpid), JsonRequestBehavior.AllowGet);
        }
        //出库新增-客户
        public ActionResult chukukehu()
        {

            return Json(NXmanager.chukukehu(), JsonRequestBehavior.AllowGet);
        }

        //出库查询所有待审核的方法
        public ActionResult chukudaicha()
        {

            return Json(NXmanager.chukudaicha(), JsonRequestBehavior.AllowGet);
        }
        //出库查询所有通过审核的方法
        public ActionResult chutongcha()
        {

            return Json(NXmanager.chutongcha(), JsonRequestBehavior.AllowGet);
        }
        //出库删除的方法
        public ActionResult chukudel(chuku cc)
        {

            return Json(NXmanager.chukudel(cc), JsonRequestBehavior.AllowGet);
        }
        //入库查询所有审核失败的方法
        public ActionResult chukubaicha()
        {

            return Json(NXmanager.chubaicha(), JsonRequestBehavior.AllowGet);
        }

        //出库审核的方法
        public ActionResult chukusheng(chuku cc)
        {

            return Json(NXmanager.chukusheng(cc), JsonRequestBehavior.AllowGet);
        }
        //入库单号的修改
        public ActionResult chukugai(chuku cc)
        {

            return Json(NXmanager.chukugai(cc), JsonRequestBehavior.AllowGet);
        }
        //出库查看的方法-详情
        public ActionResult chukuchakanx(int ckid)
        {

            return Json(NXmanager.chukuchakanx(ckid), JsonRequestBehavior.AllowGet);
        }
        //出库查看的方法
        public ActionResult chukuchakan(int ckid)
        {

            return Json(NXmanager.chukuchakan(ckid), JsonRequestBehavior.AllowGet);
        }
        //入库新增-修改获取id
        public ActionResult chuT1byid(int ckid)
        {

            return Json(NXmanager.chuT1byID(ckid), JsonRequestBehavior.AllowGet);
        }
        //入库新增—通过供应商id查询的下拉框联动查询方法
        public ActionResult kehuidcha(int kehuid)
        {

            return Json(NXmanager.kehuidcha(kehuid), JsonRequestBehavior.AllowGet);

        }
        //入库新增-通过产品编号查询下拉框的方法
        public ActionResult chupidcha(string pid)
        {

            return Json(NXmanager.chukupidcha(pid), JsonRequestBehavior.AllowGet);
        }
        public ActionResult chupidcha2(string pid)
        {

            return Json(NXmanager.chupidcha2(pid), JsonRequestBehavior.AllowGet);
        }

        //库位的下拉框
        public ActionResult chukutype1()
        {

            return Json(NXmanager.chukutype(), JsonRequestBehavior.AllowGet);
        }
        //入库新增-第一层添加
        public ActionResult CKxiangadd(CKxiang pd)
        {


            return Json(NXmanager.CKxiangadd(pd), JsonRequestBehavior.AllowGet);
        }
        //出库新增-查询第一次新增的数据
        public ActionResult chuT1cha()
        {

            return Json(NXmanager.chuT1cha(), JsonRequestBehavior.AllowGet);
        }

        //入库新增-第一次查询的删除
        public ActionResult chuT1del(CKxiang rr)
        {

            return Json(NXmanager.chuT1del(rr), JsonRequestBehavior.AllowGet);
        }
        //入库新增-第一次查询的修改
        public ActionResult chuT1upd(CKxiang rk)
        {

            return Json(NXmanager.chuT1upd(rk), JsonRequestBehavior.AllowGet);
        }

        //入库新增-第二次添加
        public ActionResult chuT2add(chuku rr)
        {

            return Json(NXmanager.chuT2add(rr), JsonRequestBehavior.AllowGet);
        }

        //入库新增页面-第二次添加时修改rkxiang表中的zt为1
        public ActionResult chuT2ztupd(CKxiang rr)
        {

            return Json(NXmanager.chuT2ztupd(rr), JsonRequestBehavior.AllowGet);

        }
        //入库新增-产品编号下拉框的查询
        public ActionResult chupbianma()
        {

            return Json(NXmanager.chupbianma(), JsonRequestBehavior.AllowGet);
        }

        //农翔-报损管理
        public ActionResult baosun()
        {

            return View();
        }

        public ActionResult baosunadd() {

            return View();
        }

        //报损查询所有的方法
        public ActionResult baosunchaall(int pageIndex, int pageSize) {

            return Json(NXmanager.baosunchaall(pageIndex, pageSize), JsonRequestBehavior.AllowGet);
        }
        //报损库新增-入库类型下拉框的方法
        public ActionResult baosuntypecha()
        {

            return Json(NXmanager.baosuntypecha(), JsonRequestBehavior.AllowGet);
        }
        //报损查询待审核的方法
        public ActionResult baosundaicha()
        {

            return Json(NXmanager.baosundaicha(), JsonRequestBehavior.AllowGet);
        }
        //报损查询所有审核成功的方法
        public ActionResult baosuntongcha()
        {

            return Json(NXmanager.baosuntongcha(), JsonRequestBehavior.AllowGet);
        }
        //报损删除的方法
        public ActionResult baosundel(baosun rr)
        {

            return Json(NXmanager.baosundel(rr), JsonRequestBehavior.AllowGet);
        }
        //报损查询所有审核失败的方法
        public ActionResult baosunbaicha()
        {

            return Json(NXmanager.baosunbaicha(), JsonRequestBehavior.AllowGet);
        }
        //报损审核的方法
        public ActionResult baosunsheng(baosun rr)
        {

            return Json(NXmanager.baosunsheng(rr), JsonRequestBehavior.AllowGet);
        }
        //报损单号的修改
        public ActionResult baosungai(baosun rr)
        {

            return Json(NXmanager.baosungai(rr), JsonRequestBehavior.AllowGet);
        }
        //报损查看的方法
        public ActionResult baosunchakan(int rid)
        {

            return Json(NXmanager.baosunchakan(rid), JsonRequestBehavior.AllowGet);
        }
        //报损查看的方法
        public ActionResult baosunchakanx(int rid)
        {

            return Json(NXmanager.baosunchakanx(rid), JsonRequestBehavior.AllowGet);
        }
        //报损查询所有-搜索的方法
        public ActionResult baosunallsou(int rukuid)
        {

            return Json(NXmanager.baosunallsou(rukuid), JsonRequestBehavior.AllowGet);
        }
    }
}