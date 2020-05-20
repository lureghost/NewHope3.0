using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD;
using DAL;
using System.ComponentModel.Design;

namespace BLL
{
   public class NXmanager
    {
        //入库界面修改订单下的关联单号的查询
        public static IQueryable rukucpcha()
        {
            return NXdal.rukucpcha();
        }
            //查询所有入库数据
            public static PageList rukuchaall(int pageIndex, int pageSize)
        {
            return NXdal.rukuchaall(pageIndex,pageSize);
        }

        //入库界面查看的功能
        public static IQueryable rukuchakan(int rid)
        {
            return NXdal.rukuchakan(rid);
        }
        //入库界面查看的功能-看详表
        public static IQueryable rukuchakanx(int rxid)
        {
            return NXdal.rukuchakanx(rxid);
        }
        //审核的方法
        public static int rukusheng(ruku rr)
        {
            return NXdal.rukusheng(rr);
        }
        //修改入库单的方法
        public static int rukugai(ruku rr)
        {
            return NXdal.rukugai(rr);
        }
            //查询所有入库数据-根据单号查询
            public static IQueryable rukuallsou(int rukuid)
        {
            return NXdal.rukuallsou(rukuid);
        }
            //查询待审核的数据
            public static IQueryable daicha()
        {
            return NXdal.daicha();
        }
        //查询审核通过的数据
        public static IQueryable tongcha()
        {
            return NXdal.tongcha();
        }
        //查询审核失败的数据
        public static IQueryable baicha()
        {
            return NXdal.baicha();
        }
        //入库管理删除的方法（实际为修改状态为3起到隐藏效果）
        public static int rukudel(ruku rr)
        {
            return NXdal.rukudel(rr);
        }
            //入库新增页面的查询入库类型下拉框的方法
            public static IQueryable rukutypecha()
        {
            return NXdal.rukutypecha();
        }
        //入库新增页面-查询供应商的下拉框
        public static IQueryable rukugys()
        {
            return NXdal.rukugys();
        }
        //入库管理-高级查询的方法
        public static IQueryable gaojicha(int gysid, int typeid, string cpid)
        {
            return NXdal.gaojicha(gysid, typeid, cpid);
        }
        //入库新增页面-通过供应商id 查询的方法
        public static IQueryable gysidcha(int gysid)
        {

            return NXdal.gysidcha(gysid);
        }
        //入库新增页面-产品编码的下拉框
        public static IQueryable pbianma()
        {
            return NXdal.pbianma();
        }
        //入库新增页面-通过产品编码查询的方法
        public static IQueryable pidcha(string pid)
        {
            return NXdal.pidcha(pid);
        }
        public static IQueryable pidcha2(string pid)
        {
            return NXdal.pidcha2(pid);
        }
        //库位查询的方法
        public static IQueryable kutype()
        {
            return NXdal.kutype();
        }
        //入库新增页面添加后查询所有状态为0的数据
        public static IQueryable T1cha()
        {
            return NXdal.T1cha();
        }
            //入库新增页面的第一层添加
            public static int RKxiangadd(RKxiang pd)
        {
            return NXdal.RKxiangadd(pd);
        }
        //入库新增页面第一层查询的删除
        public static int T1del(RKxiang rr)
        {
            return NXdal.T1del(rr);
        }
        //入库新增页面第一次查询的修改的查询
        public static IQueryable T1byID(int rxid)
        {
            return NXdal.T1byID(rxid);
        }
            //入库新增页面第一次查询的修改数量
            public static int T1upd(RKxiang rk)
        {
            return NXdal.T1upd(rk);
        }
        //入库新增页面-第二次添加
        public static int T2add(ruku rr )
        {
            return NXdal.T2add(rr);
        }
        //入库新增页面-第二次添加时修改rkxiang表中的zt为1
        public static int T2ztupd(RKxiang rzt)
        {
            return NXdal.T2ztupd(rzt);
        }





        //出库管理的方法
        //查询所有出库数据
        public static PageList chukuchaall(int pageIndex, int pageSize)
        {
            return NXdal.chukuchaall(pageIndex, pageSize);
        }

        //查询所有出库数据-根据单号查询
        public static IQueryable chukuallsou(int chukuid)
        {
            return NXdal.chukuallsou(chukuid);
        }


        //出库新增页面-查询入库类型下拉框的方法
        public static IQueryable chukutypecha()
        {
            return NXdal.chukutypecha();
        }

        //出库管理-高级查询的方法
        public static IQueryable chugaojicha(int kehuid, int typeid, string cpid)
        {
            return NXdal.chugaojicha(kehuid, typeid, cpid);
        }
        //出库新增页面-查询客户的下拉框
        public static IQueryable chukukehu()
        {
            return NXdal.chukukehu();
        }
        //查询待审核的数据
        public static IQueryable chukudaicha()
        {
            return NXdal.chukudaicha();
        }
        //查询审核通过的数据
        public static IQueryable chutongcha()
        {
            return NXdal.chutongcha();
        }
        //出库管理删除的方法（实际为修改状态为3起到隐藏效果）
        public static int chukudel(chuku cc)
        {
            return NXdal.chukudel( cc);
        }
        //查询审核失败的数据
        public static IQueryable chubaicha()
        {
            return NXdal.chubaicha();
        }
        //审核的方法
        public static int chukusheng(chuku cc)
        {
            return NXdal.chukusheng(cc);
        }
        //修改入库单的方法
        public static int chukugai(chuku cc)
        {
            return NXdal.chukugai(cc);
        }
        //出库界面查看的功能-看详表
        public static IQueryable chukuchakanx(int ckid)
        {
            return NXdal.chukuchakanx(ckid);
        }
        //出库界面查看的功能-看主表
        public static IQueryable chukuchakan(int ckid)
        {
            return NXdal.chukuchakan(ckid);
        }
        //出库新增页面第一次查询的修改的查询
        public static IQueryable chuT1byID(int ckid)
        {
            return NXdal.chuT1byID(ckid);
        }
        //入库新增页面-通过供应商id 查询的方法
        public static IQueryable kehuidcha(int kehuid)
        {
            return NXdal.kehuidcha(kehuid);
        }
        //入库新增页面-产品编码的下拉框
        public static IQueryable chupbianma()
        {
            return NXdal.chupbianma();
        }
        //入库新增页面-通过产品编码查询的方法
        public static IQueryable chukupidcha(string pid)
        {
            return NXdal.chukupidcha(pid);
        }
        //入库新增页面通过产品编码查询的方法2
        public static IQueryable chupidcha2(string pid)
        {
            return NXdal.chupidcha2(pid);
        }
        //库位查询的方法
        public static IQueryable chukutype()
        {
            return NXdal.chukutype();
        }
        //出库新增页面的第一层添加
        public static int CKxiangadd(CKxiang pd)
        {
            return NXdal.CKxiangadd(pd);
        }
        //入库新增页面添加后查询所有状态为0的数据
        public static IQueryable chuT1cha()
        {
            return NXdal.chuT1cha();
        }
        public static int chuT1del(CKxiang rr)
        {
            return NXdal.chuT1del(rr);
        }
        //出库新增页面第一次查询的修改数量
        public static int chuT1upd(CKxiang rk)
        {
            return NXdal.chuT1upd(rk);
        }
        //出库新增页面-第二次添加
        public static int chuT2add(chuku rr)
        {
            return NXdal.chuT2add(rr);
        }
        //出库新增页面-第二次添加时修改ckxiang表中的zt为1
        public static int chuT2ztupd(CKxiang rzt)
        {
            return NXdal.chuT2ztupd(rzt);
        }

        //报损的方法

       
        //查询所有报损数据
        public static PageList baosunchaall(int pageIndex, int pageSize)
        {
            return NXdal.baosunchaall(pageIndex, pageSize);
        }
        //查询所有报损数据-根据单号查询
        public static IQueryable baosunallsou(int rukuid)
        {
            return NXdal.baosunallsou(rukuid);
        }
        //报损新增页面-查询入库类型下拉框的方法
        public static IQueryable baosuntypecha()
        {
            return NXdal.baosuntypecha();
        }
        //查询待审核的数据
        public static IQueryable baosundaicha()
        {
            return NXdal.baosundaicha();
        }
        //查询审核通过的数据
        public static IQueryable baosuntongcha()
        {
            return NXdal.baosundaicha();
        }
        //入库管理删除的方法（实际为修改状态为3起到隐藏效果）
        public static int baosundel(baosun rr)
        {
            return NXdal.baosundel(rr);
        }
        //查询审核失败的数据
        public static IQueryable baosunbaicha()
        {
            return NXdal.baosunbaicha();
        }
        //审核的方法
        public static int baosunsheng(baosun rr)
        {
            return NXdal.baosunsheng(rr);
        }
        //修改报损单的方法
        public static int baosungai(baosun rr)
        {
            return NXdal.baosungai(rr);
        }
        //报损界面查看的功能-看主表
        public static IQueryable baosunchakan(int rid)
        {
            return NXdal.baosunchakan(rid);
        }
        //报损界面查看的功能-看详表
        public static IQueryable baosunchakanx(int rxid)
        {
            return NXdal.baosunchakanx(rxid);
        }
        //报损新增页面的第一层添加
        public static int BSxiangadd(BSxiang pd)
        {
            return NXdal.BSxiangadd(pd);
        }
        //报损新增页面添加后查询所有状态为0的数据
        public static IQueryable bsT1cha()
        {
            return NXdal.bsT1cha();
        }
        public static int bsT1del(BSxiang rr)
        {
            return NXdal.bsT1del(rr);
        }
        //报损新增页面第一次查询的修改数量
        public static int bsT1upd(BSxiang rk)
        {
            return NXdal.bsT1upd(rk);
        }
        //报损新增页面-第二次添加
        public static int bsT2add(baosun rr)
        {
            return NXdal.bsT2add(rr);
        }
        //报损新增页面-第二次添加时修改rkxiang表中的zt为1
        public static int bsT2ztupd(BSxiang rzt)
        {
            return NXdal.bsT2ztupd(rzt);
        }
        }
}
