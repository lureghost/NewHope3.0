using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD;
namespace DAL
{
   public class NXdal
    {


        //入库界面修改订单下的关联单号的查询
        public static IQueryable rukucpcha() {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.productguanli
                      select new
                      {

                          cpid = p.cpID
                      };
            return obj;
        }
        //查询所有入库数据
        public static PageList rukuchaall(int pageIndex, int pageSize) {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.ruku orderby p.rukuID descending where p.zt != 4 select new {

                rukuid = p.rukuID,
                rukuType = p.rukuType.rukuName,
                gysname = p.gysguanli.GName,
                cpid = p.cpID,
                sum = p.productguanli.kucun,
                zt = p.rukuZT.rzName,
                userid = p.UserID,
                caozuofs = p.caozuofs,
                time = p.createTime,
                price = p.RKxiang.by4 * p.RKxiang.Pprice,
                rid = p.rid,
                rxid=p.rxID,
                ztid=p.zt
             
            };
            PageList fy = new PageList();
            fy.DateList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            fy.PageCount = obj.Count();
            return fy;
        }

        //审核的方法
        public static int rukusheng(ruku rr) {

            NewHope4Entities context = new NewHope4Entities();
            ruku rk = context.ruku.Find(rr.rukuID);
            rk.zt = rr.zt;
            return context.SaveChanges();

        }

        //修改入库单的方法
        public static int rukugai(ruku rr) {

            NewHope4Entities context = new NewHope4Entities();
            ruku rk = context.ruku.Find(rr.rukuID);
            rk.rukuTypeID = rr.rukuTypeID;
            rk.cpID = rr.cpID;
            rk.gysID = rr.gysID;
            rk.createTime = rr.createTime;
            return context.SaveChanges();
        }
        //入库界面查看的功能-看主表
        public static IQueryable rukuchakan(int rid) {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.ruku
                      where rid == p.rukuID
                      select new
                      {
                          rukuid = p.rukuID,
                          rukuType = p.rukuType.rukuName,
                          gysname = p.gysguanli.GName,
                          gysid=p.gysID,
                          gysman=p.gysguanli.linkman,
                          cpid = p.cpID,
                          sum = p.productguanli.kucun,
                          zt = p.rukuZT.rzName,
                          userid = p.UserID,
                          caozuofs = p.caozuofs,
                          time = p.createTime,
                          price = p.RKxiang.by4 * p.RKxiang.Pprice,
                          rid = p.rid,
                          phone=p.gysguanli.phone,
                          rxid=p.rxID

                      };
            return obj;

        }
        //入库界面查看的功能-看详表
        public static IQueryable rukuchakanx(int rxid) {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.RKxiang where rxid == p.rxID && p.zt!=0 select new {

                rxid = p.rxID,
                pname = p.by1,
                pid = p.Pid,
                pguige = p.Pguige,
                ppici = p.Ppici,
                price = p.Pprice,
                psum = p.by4,
                kuwei = p.by3,
                total = p.by4 * p.Pprice
            };
            return obj;
        }
        //查询所有入库数据-根据单号查询
        public static IQueryable rukuallsou(int rukuid) {
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.ruku
                      where p.rukuID == rukuid && p.zt != 4
                      select new
                      {
                          rukuid = p.rukuID,
                          rukuType = p.rukuType.rukuName,
                          gysname = p.gysguanli.GName,
                          cpid = p.cpID,
                          sum = p.productguanli.kucun,
                          zt = p.rukuZT.rzName,
                          userid = p.UserID,
                          caozuofs = p.caozuofs,
                          time = p.createTime,
                          price = p.RKxiang.by4 * p.RKxiang.Pprice,
                          rid = p.rid,
                          rxid = p.rxID,
                          ztid = p.zt,
                          rukutypeid = p.rukuTypeID,
                          gysid = p.gysID

                      };
            
            //context.Configuration.ProxyCreationEnabled = false;
            return obj;
        }


        //查询待审核的数据
        public static IQueryable daicha() {
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.ruku
                      where p.zt == 1 
                      select new
                      {
                          rukuid = p.rukuID,
                          rukuType = p.rukuType.rukuName,
                          gysname = p.gysguanli.GName,
                          cpid = p.cpID,
                          sum = p.productguanli.kucun,
                          zt = p.rukuZT.rzName,
                          userid = p.UserID,
                          caozuofs = p.caozuofs,
                          time = p.createTime,
                          price = p.RKxiang.by4 * p.RKxiang.Pprice,
                          rid = p.rid,
                          rxid = p.rxID,
                          ztid = p.zt

                      };
            //context.Configuration.ProxyCreationEnabled = false;
            return obj;
        }

        //查询审核通过的数据
        public static IQueryable tongcha()
        {
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.ruku
                      where p.zt == 2
                      select new
                      {
                          rukuid = p.rukuID,
                          rukuType = p.rukuType.rukuName,
                          gysname = p.gysguanli.GName,
                          cpid = p.cpID,
                          sum = p.productguanli.kucun,
                          zt = p.rukuZT.rzName,
                          userid = p.UserID,
                          caozuofs = p.caozuofs,
                          time = p.createTime,
                          price = p.RKxiang.by4 * p.RKxiang.Pprice,
                          rid = p.rid,
                          rxid = p.rxID,
                          ztid = p.zt

                      };
           // context.Configuration.ProxyCreationEnabled = false;
            return obj;
        }
        //查询审核失败的数据
        public static IQueryable baicha()
        {
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.ruku
                      where p.zt == 3
                      select new
                      {
                          rukuid = p.rukuID,
                          rukuType = p.rukuType.rukuName,
                          gysname = p.gysguanli.GName,
                          cpid = p.cpID,
                          sum = p.productguanli.kucun,
                          zt = p.rukuZT.rzName,
                          userid = p.UserID,
                          caozuofs = p.caozuofs,
                          time = p.createTime,
                          price = p.RKxiang.by4 * p.RKxiang.Pprice,
                          rid = p.rid,
                          rxid = p.rxID,
                          ztid = p.zt

                      };
            //context.Configuration.ProxyCreationEnabled = false;
            return obj;
        }

        //搜索入库单号的功能
        public static IQueryable danhaocha(int rid) {
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.ruku
                      where p.rukuID==rid && p.zt != 4
                      select new
                      {
                          rukuid = p.rukuID,
                          rukuType = p.rukuType.rukuName,
                          gysname = p.gysguanli.GName,
                          cpid = p.cpID,
                          sum = p.RKxiang.by4,
                          zt = p.rukuZT.rzName,
                          userid = p.UserID,
                          caozuofs = p.caozuofs,
                          time = p.createTime,
                          price = p.RKxiang.by4 * p.RKxiang.Pprice,
                          rid = p.rid,
                          rxid = p.rxID,
                          ztid = p.zt

                      };
            //context.Configuration.ProxyCreationEnabled = false;
            return obj;
        }
        //入库管理-高级查询的方法
        public static IQueryable gaojicha(int gysid,int typeid,string cpid) {
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.ruku
                      where gysid == p.gysID && typeid == p.rukuTypeID && cpid == p.cpID
                      select new
                      {
                          rukuid = p.rukuID,
                          rukuType = p.rukuType.rukuName,
                          gysname = p.gysguanli.GName,
                          cpid = p.cpID,
                          sum = p.productguanli.kucun,
                          zt = p.rukuZT.rzName,
                          userid = p.UserID,
                          caozuofs = p.caozuofs,
                          time = p.createTime,
                          price = p.RKxiang.by4 * p.RKxiang.Pprice,
                          rid = p.rid,
                          rxid = p.rxID,
                          ztid = p.zt
                      };
            return obj;

        }
       

        //入库管理删除的方法（实际为修改状态为3起到隐藏效果）
        public static int rukudel(ruku rr) {

            NewHope4Entities context = new NewHope4Entities();
            ruku rd = context.ruku.Find(rr.rukuID);
            rd.zt = rr.zt;
            return context.SaveChanges();
            
        }



        //入库新增页面-查询入库类型下拉框的方法
        public static IQueryable rukutypecha() {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.rukuType
                      select new
                      {
                          typeid=p.rukuTypeID,
                          typename=p.rukuName
                      };
            return obj;
        }
        //入库新增页面-查询供应商的下拉框
        public static IQueryable rukugys() {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.gysguanli
                      select new
                      {
                          gysid=p.GID,
                          gysname=p.GName,
                          gysman=p.linkman,
                          gysphone=p.phone
                      };
            return obj;
        }
        //入库新增页面-通过供应商id 查询的方法
        public static IQueryable gysidcha(int gysid) {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.gysguanli
                      where gysid == p.GID
                      select new
                      {
                          gysid = p.GID,
                          gysname = p.GName,
                          gysman = p.linkman,
                          gysphone = p.phone
                      };
            return obj;
        }
        //入库新增页面-产品编码的下拉框
        public static IQueryable pbianma() {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.RKxiang
                      select new
                      {
                          downid=p.Pid
                          

                      };
            return obj;
        }
        //入库新增页面-通过产品编码查询的方法
        public static IQueryable pidcha(string pid) {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.RKxiang
                      where pid == p.Pid
                      select new
                      {
                          downid = p.Pid,
                          pandian=from pp in context.pandianxq where pp.chanpinID==p.Pid select new { 
                          pname=pp.chanpinName,
                          kucun=pp.pandiansum
                          },
                         pprice=p.Pprice,
                         pguige=p.Pguige

                      };
            return obj;

        }
        //入库新增页面通过产品编码查询的方法2
        public static IQueryable pidcha2(string pid)
        {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.productguanli
                      where pid == p.cpID
                      select new
                      {
                          pname = p.cpName,
                          kucun = p.kucun
                      };
 
            return obj;

        }

        //库位查询的方法
        public static IQueryable kutype() {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.KuType
                      select new
                      {
                          kuid=p.KuTYpeID,
                          kuname=p.KuName
                      };
            return obj;
        }
        
        //入库新增页面的第一层添加
        public static int RKxiangadd(RKxiang pd) {

            NewHope4Entities context = new NewHope4Entities();
            context.RKxiang.Add(pd);
            return context.SaveChanges();

        }
        //入库新增页面添加后查询所有状态为0的数据
        public static IQueryable T1cha() {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.RKxiang
                      where p.zt == 0
                      select new
                      {
                          rxid=p.rxID,
                          pname=p.by1,
                          pid=p.Pid,
                          pguige=p.Pguige,
                          ppici=p.Ppici,
                          price=p.Pprice,
                          psum=p.by4,
                          kuwei=p.by3,
                         total=p.by4*p.Pprice
                          
                      };
            return obj;
        }
        
        public static int T1del(RKxiang rr) {

            NewHope4Entities context = new NewHope4Entities();
            RKxiang rd = context.RKxiang.Find(rr.rxID);
            rd.zt = 3;
            return context.SaveChanges();
        }



        //入库新增页面第一次查询的修改的查询
        public static IQueryable T1byID(int rxid) {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.RKxiang
                      where rxid == p.rxID
                      select new
                      {

                          kucun = p.by4
                      };
            return obj;

        }
        //入库新增页面第一次查询的修改数量
        public static int T1upd(RKxiang rk) {

            NewHope4Entities context = new NewHope4Entities();
            RKxiang ru = context.RKxiang.Find(rk.rxID);
            ru.by4 = rk.by4;
            return context.SaveChanges();
        }
        //入库新增页面-第二次添加
        public static int T2add(ruku rr) {

            NewHope4Entities context = new NewHope4Entities();
            context.ruku.Add(rr);
            return context.SaveChanges();
        }
        //入库新增页面-第二次添加时修改rkxiang表中的zt为1
        public static int T2ztupd(RKxiang rzt) {

            NewHope4Entities context = new NewHope4Entities();
            RKxiang rz = context.RKxiang.Find(rzt.rxID);
            rz.zt = rzt.zt;
            return context.SaveChanges();
        }


        //出库管理的方法
        //查询所有出库数据
        public static PageList chukuchaall(int pageIndex, int pageSize)
        {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.chuku
                      orderby p.chukuID
                      where p.zt != 4
                      select new
                      {

                          chukuid = p.chukuID,
                          chukuType = p.chukuType.chukuTypeName,
                          kuhu=p.customer.KehuName,
                          cpid = p.cpID,
                          sum = p.productguanli.kucun,
                          zt = p.rukuZT.rzName,
                          userid = p.UserID,
                          caozuofs = p.caozuofs,
                          time = p.createTime,
                          price = p.CKxiang.chuSum * p.CKxiang.Pprice,
                          ckid = p.ckID,
                          ztid = p.zt

                      };
            PageList fy = new PageList();
            fy.DateList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            fy.PageCount = obj.Count();
            return fy;
        }

        //查询所有出库数据-根据单号查询
        public static IQueryable chukuallsou(int chukuid)
        {
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.chuku
                      where p.chukuID == chukuid && p.zt != 4
                      select new
                      {
                          chukuid = p.chukuID,
                          chukuType = p.chukuType.chukuTypeName,
                          kuhu = p.customer.KehuName,
                          cpid = p.cpID,
                          sum = p.productguanli.kucun,
                          zt = p.rukuZT.rzName,
                          userid = p.UserID,
                          caozuofs = p.caozuofs,
                          time = p.createTime,
                          price = p.CKxiang.chuSum * p.CKxiang.Pprice,
                          ckid = p.ckID,
                          ztid = p.zt

                      };

            //context.Configuration.ProxyCreationEnabled = false;
            return obj;
        }

        //出库新增页面-查询入库类型下拉框的方法
        public static IQueryable chukutypecha()
        {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.chukuType
                      select new
                      {
                          typeid = p.chukuTypeID,
                          typename = p.chukuTypeName
                      };
            return obj;
        }

        //出库管理-高级查询的方法
        public static IQueryable chugaojicha(int kehuid, int typeid, string cpid)
        {
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.chuku
                      where kehuid == p.kehuID && typeid == p.chukuTypeID && cpid == p.cpID
                      select new
                      {
                          chukuid = p.chukuID,
                          chukuType = p.chukuType.chukuTypeName,
                          kuhu = p.customer.KehuName,
                          cpid = p.cpID,
                          sum = p.productguanli.kucun,
                          zt = p.rukuZT.rzName,
                          userid = p.UserID,
                          caozuofs = p.caozuofs,
                          time = p.createTime,
                          price = p.CKxiang.chuSum * p.CKxiang.Pprice,
                          ckid = p.ckID,
                          ztid = p.zt
                      };
            return obj;

        }

        //出库新增页面-查询客户的下拉框
        public static IQueryable chukukehu()
        {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.customer
                      select new
                      {
                          kehuid = p.kehuID,
                          kehuname = p.KehuName,
                        
                          kehuphone = p.phone
                      };
            return obj;
        }

        //查询待审核的数据
        public static IQueryable chukudaicha()
        {
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.chuku
                      where p.zt == 1
                      select new
                      {
                          chukuid = p.chukuID,
                          chukuType = p.chukuType.chukuTypeName,
                          kuhu = p.customer.KehuName,
                          cpid = p.cpID,
                          sum = p.productguanli.kucun,
                          zt = p.rukuZT.rzName,
                          userid = p.UserID,
                          caozuofs = p.caozuofs,
                          time = p.createTime,
                          price = p.CKxiang.chuSum * p.CKxiang.Pprice,
                          ckid = p.ckID,
                          ztid = p.zt

                      };
            //context.Configuration.ProxyCreationEnabled = false;
            return obj;
        }
        //查询审核通过的数据
        public static IQueryable chutongcha()
        {
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.chuku
                      where p.zt == 2
                      select new
                      {
                          chukuid = p.chukuID,
                          chukuType = p.chukuType.chukuTypeName,
                          kuhu = p.customer.KehuName,
                          cpid = p.cpID,
                          sum = p.productguanli.kucun,
                          zt = p.rukuZT.rzName,
                          userid = p.UserID,
                          caozuofs = p.caozuofs,
                          time = p.createTime,
                          price = p.CKxiang.chuSum * p.CKxiang.Pprice,
                          ckid = p.ckID,
                          ztid = p.zt

                      };
            // context.Configuration.ProxyCreationEnabled = false;
            return obj;
        }

        //出库管理删除的方法（实际为修改状态为3起到隐藏效果）
        public static int chukudel(chuku cc)
        {

            NewHope4Entities context = new NewHope4Entities();
            chuku rd = context.chuku.Find(cc.chukuID);
            rd.zt = cc.zt;
            return context.SaveChanges();

        }
        //查询审核失败的数据
        public static IQueryable chubaicha()
        {
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.chuku
                      where p.zt == 3
                      select new
                      {
                          chukuid = p.chukuID,
                          chukuType = p.chukuType.chukuTypeName,
                          kuhu = p.customer.KehuName,
                          cpid = p.cpID,
                          sum = p.productguanli.kucun,
                          zt = p.rukuZT.rzName,
                          userid = p.UserID,
                          caozuofs = p.caozuofs,
                          time = p.createTime,
                          price = p.CKxiang.chuSum * p.CKxiang.Pprice,
                          ckid = p.ckID,
                          ztid = p.zt

                      };
            //context.Configuration.ProxyCreationEnabled = false;
            return obj;
        }
        //审核的方法
        public static int chukusheng(chuku cc)
        {

            NewHope4Entities context = new NewHope4Entities();
            chuku rk = context.chuku.Find(cc.chukuID);
            rk.zt = cc.zt;
            return context.SaveChanges();

        }
        //修改入库单的方法
        public static int chukugai(chuku cc)
        {

            NewHope4Entities context = new NewHope4Entities();
            chuku rk = context.chuku.Find(cc.chukuID);
            rk.chukuTypeID = cc.chukuTypeID;
            rk.cpID = cc.cpID;
            rk.kehuID = cc.kehuID;
            rk.createTime = cc.createTime;
            return context.SaveChanges();
        }
        //出库界面查看的功能-看详表
        public static IQueryable chukuchakanx(int ckid)
        {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.CKxiang
                      where ckid == p.ckID && p.zt != 0
                      select new
                      {

                          ckid = p.ckID,
                          pname = p.by2,
                          pid = p.Ptiaoma,
                          pguige = p.Pguige,
                          ppici = p.ckpici,
                          price = p.Pprice,
                          psum = p.chuSum,
                          kuwei = p.chukuType.chukuTypeName,
                          total = p.chuSum * p.Pprice
                          
                      };
            return obj;
        }
        //出库界面查看的功能-看主表
        public static IQueryable chukuchakan(int ckid)
        {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.chuku
                      where ckid == p.chukuID
                      select new
                      {
                          rukuid = p.chukuID,
                          rukuType = p.chukuType.chukuTypeName,
                          gysname = p.customer.KehuName,
                          gysid = p.kehuID,
                          gysman = p.customer.KehuName,
                          cpid = p.cpID,
                          sum = p.productguanli.kucun,
                          zt = p.rukuZT.rzName,
                          userid = p.UserID,
                          caozuofs = p.caozuofs,
                          time = p.createTime,
                          price = p.CKxiang.chuSum * p.CKxiang.Pprice,
                          phone = p.customer.phone,
                          ckid = p.ckID

                      };
            return obj;

        }
        //出库新增页面第一次查询的修改的查询
        public static IQueryable chuT1byID(int ckid)
        {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.CKxiang
                      where ckid == p.ckID
                      select new
                      {

                          kucun = p.chuSum
                      };
            return obj;

        }
        //入库新增页面-通过供应商id 查询的方法
        public static IQueryable kehuidcha(int kehuid)
        {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.customer
                      where kehuid == p.kehuID
                      select new
                      {
                          gysman=p.faxes,
                          gysid = p.kehuID,
                          gysname = p.KehuName,
                          gysphone = p.phone
                      };
            return obj;
        }
        //入库新增页面-产品编码的下拉框
        public static IQueryable chupbianma()
        {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.CKxiang
                      select new
                      {
                          downid = p.Ptiaoma


                      };
            return obj;
        }
        //入库新增页面-通过产品编码查询的方法
        public static IQueryable chukupidcha(string pid)
        {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.CKxiang
                      where pid == p.Ptiaoma
                      select new
                      {
                          downid = p.Ptiaoma,
                          pandian = from pp in context.pandianxq
                                    where pp.chanpinID == p.Ptiaoma
                                    select new
                                    {
                                        pname = pp.chanpinName,
                                        kucun = pp.pandiansum
                                    },
                          pprice = p.Pprice,
                          pguige = p.Pguige

                      };
            return obj;

        }
        //入库新增页面通过产品编码查询的方法2
        public static IQueryable chupidcha2(string pid)
        {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.productguanli
                      where pid == p.cpID
                      select new
                      {
                          pname = p.cpName,
                          kucun = p.kucun
                      };

            return obj;

        }
        //库位查询的方法
        public static IQueryable chukutype()
        {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.chukuType
                      select new
                      {
                          kuid = p.chukuTypeID,
                          kuname = p.chukuTypeName
                      };
            return obj;
        }
        //出库新增页面的第一层添加
        public static int CKxiangadd(CKxiang pd)
        {

            NewHope4Entities context = new NewHope4Entities();
            context.CKxiang.Add(pd);
            return context.SaveChanges();

        }
        //出库新增页面添加后查询所有状态为0的数据
        public static IQueryable chuT1cha()
        {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.CKxiang
                      where p.zt == 0
                      select new
                      {
                          rxid = p.ckID,
                          pname = p.by2,
                          pid = p.Ptiaoma,
                          pguige = p.Pguige,
                          ppici = p.ckpici,
                          price = p.Pprice,
                          psum = p.by4,
                          kuwei = p.chukuType.chukuTypeName,
                          total = p.chuSum * p.Pprice,
                          chuSum=p.chuSum
                      };
            return obj;
        }
        public static int chuT1del(CKxiang rr)
        {

            NewHope4Entities context = new NewHope4Entities();
            CKxiang cc = context.CKxiang.Find(rr.ckID);
            cc.zt = 3;
            return context.SaveChanges();
        }
        //出库新增页面第一次查询的修改数量
        public static int chuT1upd(CKxiang rk)
        {

            NewHope4Entities context = new NewHope4Entities();
            CKxiang ru = context.CKxiang.Find(rk.ckID);
            ru.chuSum = rk.chuSum;
            return context.SaveChanges();
        }
        //入库新增页面-第二次添加
        public static int chuT2add(chuku rr)
        {

            NewHope4Entities context = new NewHope4Entities();
            context.chuku.Add(rr);
            return context.SaveChanges();
        }
        //入库新增页面-第二次添加时修改rkxiang表中的zt为1
        public static int chuT2ztupd(CKxiang rzt)
        {

            NewHope4Entities context = new NewHope4Entities();
            CKxiang rz = context.CKxiang.Find(rzt.ckID);
            rz.zt = rzt.zt;
            return context.SaveChanges();
        }





        //报损的方法
        //报损查询所有的方法
        //查询所有报损数据
        public static PageList baosunchaall(int pageIndex, int pageSize)
        {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.baosun
                      orderby p.baosunID descending
                      where p.zt != 4
                      select new
                      {

                          rukuid = p.baosunID,
                          rukuType = p.baosunType.baosunTypeName,
                          cpid = p.cpid,
                          sum = p.baosunSum,
                          userid = p.UserID,
                          caozuofs = p.caozuofs,
                          time = p.createTime,
                          rxid = p.bsID,
                          zt = p.rukuZT.rzName,
                          ztid=p.zt
                      };
            PageList fy = new PageList();
            fy.DateList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            fy.PageCount = obj.Count();
            return fy;
        }
        //查询所有报损数据-根据单号查询
        public static IQueryable baosunallsou(int rukuid)
        {
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.baosun
                      where p.baosunID == rukuid && p.zt != 4
                      select new
                      {
                          rukuid = p.baosunID,
                          rukuType = p.baosunType.baosunTypeName,
                          cpid = p.cpid,
                          sum = p.baosunSum,
                          userid = p.UserID,
                          caozuofs = p.caozuofs,
                          time = p.createTime,
                          rxid = p.bsID,
                          zt = p.zt

                      };

            //context.Configuration.ProxyCreationEnabled = false;
            return obj;
        }
        //报损新增页面-查询入库类型下拉框的方法
        public static IQueryable baosuntypecha()
        {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.baosunType
                      select new
                      {
                          typeid = p.baosunTypeID,
                          typename = p.baosunTypeName
                      };
            return obj;
        }
        //查询待审核的数据
        public static IQueryable baosundaicha()
        {
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.baosun
                      where p.zt == 1
                      select new
                      {
                          rukuid = p.baosunID,
                          rukuType = p.baosunType.baosunTypeName,
                          cpid = p.cpid,
                          sum = p.baosunSum,
                          userid = p.UserID,
                          caozuofs = p.caozuofs,
                          time = p.createTime,
                          rxid = p.bsID,
                          zt = p.zt

                      };
            //context.Configuration.ProxyCreationEnabled = false;
            return obj;
        }
        //查询审核通过的数据
        public static IQueryable baosuntongcha()
        {
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.baosun
                      where p.zt == 2
                      select new
                      {
                          rukuid = p.baosunID,
                          rukuType = p.baosunType.baosunTypeName,
                          cpid = p.cpid,
                          sum = p.baosunSum,
                          userid = p.UserID,
                          caozuofs = p.caozuofs,
                          time = p.createTime,
                          rxid = p.bsID,
                          zt = p.zt

                      };
            // context.Configuration.ProxyCreationEnabled = false;
            return obj;
        }
        //报损管理删除的方法（实际为修改状态为3起到隐藏效果）
        public static int baosundel(baosun rr)
        {

            NewHope4Entities context = new NewHope4Entities();
            baosun rd = context.baosun.Find(rr.zt);
            rd.zt = rr.zt;
            return context.SaveChanges();

        }
        //查询审核失败的数据
        public static IQueryable baosunbaicha()
        {
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.baosun
                      where p.zt == 3
                      select new
                      {
                          rukuid = p.baosunID,
                          rukuType = p.baosunType.baosunTypeName,
                          cpid = p.cpid,
                          sum = p.baosunSum,
                          userid = p.UserID,
                          caozuofs = p.caozuofs,
                          time = p.createTime,
                          rxid = p.bsID,
                          zt = p.zt

                      };
            //context.Configuration.ProxyCreationEnabled = false;
            return obj;
        }
        //审核的方法
        public static int baosunsheng(baosun rr)
        {

            NewHope4Entities context = new NewHope4Entities();
            baosun rk = context.baosun.Find(rr.baosunID);
            rk.zt = rr.zt;
            return context.SaveChanges();

        }
        //修改报损单的方法
        public static int baosungai(baosun rr)
        {

            NewHope4Entities context = new NewHope4Entities();
            baosun rk = context.baosun.Find(rr.baosunID);
            rk.baosunTypeID = rr.baosunTypeID;
            rk.cpid = rr.cpid;
          
            rk.createTime = rr.createTime;
            return context.SaveChanges();
        }
        //报损界面查看的功能-看主表
        public static IQueryable baosunchakan(int rid)
        {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.baosun
                      where rid == p.baosunID
                      select new
                      {
                          rukuid = p.baosunID,
                          rukuType = p.baosunType.baosunTypeName,
                          cpid = p.cpid,
                          sum = p.baosunSum,
                          userid = p.UserID,
                          caozuofs = p.caozuofs,
                          time = p.createTime,
                          rxid = p.bsID,
                          zt = p.zt

                      };
            return obj;

        }
        //报损界面查看的功能-看详表
        public static IQueryable baosunchakanx(int rxid)
        {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.BSxiang
                      where rxid == p.bsID && p.zt != 0
                      select new
                      {

                          rxid = p.bsID,
                          pname = p.by2,
                          pid = p.Pid,
                          pguige = p.Pguige,
                          ppici = p.bspici,
                          price = p.Pprice,
                          psum = p.by4,
                          kuwei = p.by3
                      };
            return obj;
        }
        //报损新增页面的第一层添加
        public static int BSxiangadd(BSxiang pd)
        {

            NewHope4Entities context = new NewHope4Entities();
            context.BSxiang.Add(pd);
            return context.SaveChanges();

        }
        //报损新增页面添加后查询所有状态为0的数据
        public static IQueryable bsT1cha()
        {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.BSxiang
                      where p.zt == 0
                      select new
                      {
                          rxid = p.bsID,
                          pname = p.Ptiaoma,
                          pid = p.Pid,
                          pguige = p.Pguige,
                          ppici = p.bspici,
                          price = p.Pprice,
                          bssum = p.bsSum,
                          kuwei = p.by3,
                          total = p.bsSum * p.Pprice

                      };
            return obj;
        }
        public static int bsT1del(BSxiang rr)
        {

            NewHope4Entities context = new NewHope4Entities();
            BSxiang rd = context.BSxiang.Find(rr.bsID);
            rd.zt = 3;
            return context.SaveChanges();
        }
        //报损新增页面第一次查询的修改数量
        public static int bsT1upd(BSxiang rk)
        {

            NewHope4Entities context = new NewHope4Entities();
            BSxiang ru = context.BSxiang.Find(rk.bsID);
            ru.bsSum = rk.bsSum;
            return context.SaveChanges();
        }
        //报损新增页面-第二次添加
        public static int bsT2add(baosun rr)
        {

            NewHope4Entities context = new NewHope4Entities();
            context.baosun.Add(rr);
            return context.SaveChanges();
        }
        //报损新增页面-第二次添加时修改rkxiang表中的zt为1
        public static int bsT2ztupd(BSxiang rzt)
        {

            NewHope4Entities context = new NewHope4Entities();
            BSxiang rz = context.BSxiang.Find(rzt.bsID);
            rz.zt = rzt.zt;
            return context.SaveChanges();
        }

        //入库审核成功后修改产品管理表的库存
        public static int rukuSH(string rr,int count) {

            NewHope4Entities context = new NewHope4Entities();
            productguanli obj = (from p in context.productguanli where p.cpID == rr select p).First();
            obj.kucun += count;
            return context.SaveChanges();   

        }
        //出库,报损审核成功后修改产品管理表的库存
        public static int CBSH(string rr, int count)
        {

            NewHope4Entities context = new NewHope4Entities();
            productguanli obj = (from p in context.productguanli where p.cpID == rr select p).First();
            obj.kucun -= count;
            return context.SaveChanges();

        }

    }
}
