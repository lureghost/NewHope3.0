using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD;
using DAL;

namespace DAL
{
    public class YQdal
    {
        //计量单位  普通查询
        //public static NewHope4Entities uu = new NewHope4Entities();


        //public static IQueryable measurementQurey()
        //{
        //    //NewHope4Entities uu = new NewHope4Entities()
        //    var obj = from p in uu.measurement

        //              select new
        //              {
        //                  XID = p.XID,
        //                  MID = p.MID,
        //                  MName = p.MName
        //              };
        //    return obj;
        //}

        //条件查询
        //带条件查询
        public static IQueryable dtmeasurementQurey(int MID, string MName)
        {
            NewHope4Entities uu = new NewHope4Entities();
            var obj = from p in uu.measurement
                      orderby p.MID ascending
                      select new
                      {
                          //XID = p.XID,
                          MID = p.MID,
                          MName = p.MName,
                          CreationDate = p.CreationDate,
                      };
            //if (MID != 0)
            //{
            //    obj = obj.Where(p => p.MID == MID);
            //}
            if (MID > 0 || MName != null)
            {
                obj = obj.Where(p => p.MID == MID || p.MName.Contains(MName));
            }
            return obj;
        }
        //普通分页
        public static PageList fyqureyAll(int pageIndex, int pageSize)
        {
            NewHope4Entities uu = new NewHope4Entities();
           
            var obj = from p in uu.measurement
                      orderby p.MID ascending
                      where p.state == 0
                      select new
                      {

                          //XID = p.XID,
                          MID = p.MID,
                          MName = p.MName,
                          CreationDate = p.CreationDate,
                      };

            //设置分页数据
            //var ms = obj.ToString();
            PageList list = new PageList();
            list.DateList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            list.PageCount = obj.Count();
            //设置总页数
            //int rows = uu.measurement.Count();
            //list.PageCount = rows % pageSize == 0 ? rows / pageSize : rows / pageSize + 1;

            return list;
        }
        //获取行
        public static int GetRows()
        {
            NewHope4Entities uu = new NewHope4Entities();
            return uu.measurement.Count();
        }
        //删除状态
        public static int jiliangdanwei_Del(int MID, int state)
        {
            NewHope4Entities uu = new NewHope4Entities();
            var kk = uu.measurement.Find(MID);
            kk.MID = MID;
            kk.state = state;
            return uu.SaveChanges();
        }

        //删除
        public static int Get_jiliangdanweiDel2(int id)
        {
            NewHope4Entities uu = new NewHope4Entities();
            var obj = (from p in uu.measurement
                       where p.MID == id
                       select p).First();
            uu.measurement.Remove(obj);
            return uu.SaveChanges();
            //var oo = uu.measurement.Find(id);
            //uu.measurement.Remove(oo);
        }
        //计量单位 新增
        public static int measurementadd(measurement k)
        {
            NewHope4Entities uu = new NewHope4Entities();
            uu.measurement.Add(k);
            return uu.SaveChanges();
        }
        //根据id修改
        public static IQueryable Get_jiliangdanweiByid(int MID)
        {
            NewHope4Entities uu = new NewHope4Entities();
            var obj = from p in uu.measurement
                      where p.MID == MID
                      select new
                      {
                          MID = p.MID,
                          MName = p.MName,
                          state = p.state,
                          CreationDate = p.CreationDate
                      };
            return obj;

        }
        //修改
        public static int Get_jiliangdanweiupdate(measurement m)
        {
            NewHope4Entities uu = new NewHope4Entities();
            var obj = uu.measurement.Find(m.MID);
            obj.MName = m.MName;
            //obj.CreationDate = m.CreationDate;
            //obj.state = m.state;
            return uu.SaveChanges();

        }




        /// <summary>
        ///  产品类别
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>

        //普通分页
        public static PageList Get_chanpinglbAll(int pageIndex, int pageSize)
        {
            NewHope4Entities uu = new NewHope4Entities();
            PageList list = new PageList();
            var obj = from p in uu.productType
                      orderby p.PID ascending
                      where p.state == 0
                      select new
                      {

                          //XID = p.XID,
                          PID = p.PID,
                          PName = p.PName,
                          //外键对象
                          UName = p.Admin.UserName,
                          CreationDate = p.CreationDate,
                          remark = p.remark

                      };
            //设置分页数据
            list.DateList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            list.PageCount = obj.Count();
            //设置总页数
            //int rows = uu.measurement.Count();
            //list.PageCount = rows % pageSize == 0 ? rows / pageSize : rows / pageSize + 1;

            return list;
        }
        //获取行
        public static int GetRowslb()
        {
            NewHope4Entities uu = new NewHope4Entities();
            return uu.productType.Count();
        }
        //模糊查询
        public static IQueryable Get_chanpinlbmohucha(int PID, string PName)
        {
            NewHope4Entities uu = new NewHope4Entities();
            var obj = from p in uu.productType
                      orderby p.PID ascending
                      where p.state == 0
                      select new
                      {
                          PID = p.PID,
                          PName = p.PName,
                          UName = p.Admin.UserName,
                          CreationDate = p.CreationDate,
                          remark = p.remark

                      };
            if (PID > 0 || PName != null)
            {
                obj = obj.Where(p => p.PID == PID || p.PName.Contains(PName));
            }
            return obj;
        }
        //新增
        public static int Get_chanpinlbAdd(productType p)
        {
            NewHope4Entities uu = new NewHope4Entities();
            uu.productType.Add(p);
            return uu.SaveChanges();
        }
        //删除状态
        public static int Get_chanpinlbDel(int PID, int state)
        {
            NewHope4Entities uu = new NewHope4Entities();
            var kk = uu.productType.Find(PID);
            kk.PID = PID;
            kk.state = state;
            return uu.SaveChanges();
        }
        //修改带id查询
        public static IQueryable Get_chanpinlbById(int PID)
        {
            NewHope4Entities uu = new NewHope4Entities();
            var obj = from p in uu.productType
                      where p.PID == PID
                      select new
                      {
                          PID = p.PID,
                          PName = p.PName,
                          //外键对象
                          UName = p.Admin.UserName,
                          CreationDate = p.CreationDate,
                          remark = p.remark
                      };
            return obj;
        }
        //修改
        public static int Get_chanpinlbupdate(productType p)
        {
            NewHope4Entities uu = new NewHope4Entities();
            var obj = uu.productType.Find(p.PID);
            obj.PName = p.PName;
            obj.remark = p.remark;
            //obj.CreationDate = m.CreationDate;
            //obj.state = m.state;
            return uu.SaveChanges();
        }



        /// <summary>
        ///产品管理
        /// </summary> 
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        //分页查询
        public static PageList Get_chanpingguanliAll(int pageIndex, int pageSize)
        {
            NewHope4Entities uu = new NewHope4Entities();
            PageList list = new PageList();
            var obj = from p in uu.productguanli
                      orderby p.ID ascending
                      where p.state == 0
                      select new
                      {
                          ID = p.ID,//序号
                          cpID = p.cpID, //产品编号 条码
                          cpName = p.cpName,//显示名 产品名称
                          upper = p.upper,//上限
                          floor = p.floor,//下限
                          price = p.price,//价格
                          PID = p.PID,
                          WID = p.WID,
                          kehuID = p.kehuID,
                          defaultstorage = p.defaultstorage,
                          specification = p.specification,//规格
                          PNames = p.productType.PName, //类别 产品类别
                          MNames = p.measurement.MName,//单位 
                          remark = p.remark,//备注
                          KehuNames = p.customer.KehuName,//客户
                          WNames = p.warehouse.WName,//默认仓库
                          KuNames = p.KuType.KuName,//默认库位
                          kucun=p.kucun
                          /* XID = p.XID,*///
                          //p.state,
                      };
            //设置分页数据
            list.DateList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            list.PageCount = obj.Count();
            //设置总页数
            //int rows = uu.measurement.Count();
            //list.PageCount = rows % pageSize == 0 ? rows / pageSize : rows / pageSize + 1;

            return list;
        }
        //获取行
        public static int Get_Rowsguanli()
        {
            NewHope4Entities uu = new NewHope4Entities();
            return uu.productguanli.Count();
        }
        //类别下拉
        public static IQueryable Get_lbxiala()
        {
            NewHope4Entities uu = new NewHope4Entities();
            var obj = from p in uu.productType
                      orderby p.PID ascending
                      select new
                      {
                          PID = p.PID,
                          PName = p.PName
                      };
            return obj;
        }
        //条件查询
        public static IQueryable Get_chanpinguanlimohucha(string cpID, string cpName, int PID)
        {
            NewHope4Entities uu = new NewHope4Entities();
            var obj = from p in uu.productguanli
                      orderby p.ID ascending
                      where p.state == 0
                      select new
                      {
                          ID = p.ID,//序号
                          cpID = p.cpID, //产品编号 条码
                          cpName = p.cpName,//显示名 产品名称
                          upper = p.upper,//上限
                          floor = p.floor,//下限
                          price = p.price,//价格
                          specification = p.specification,//规格
                          PID = p.PID,
                          PNames = p.productType.PName, //类别 产品类别
                          MNames = p.measurement.MName,//单位 
                          remark = p.remark,//备注
                          KehuNames = p.customer.KehuName,//客户
                          WNames = p.warehouse.WName,//默认仓库
                          KuNames = p.KuType.KuName,//默认库位
                          kucun = p.kucun
                      };
            if (cpID != null || cpName != null)
            {
                obj = obj.Where(p => p.cpID.Contains(cpID) || p.cpName.Contains(cpName));
            }
            if (PID > 0)
            {
                obj = obj.Where(p => p.PID == PID);
            }
            return obj;
        }
        //单位下拉
        public static IQueryable Get_dwxiala()
        {
            NewHope4Entities uu = new NewHope4Entities();
            var obj = from p in uu.measurement
                      orderby p.MID ascending
                      select new
                      {
                          MID = p.MID,
                          MName = p.MName
                      };
            return obj;
        }
        //客户下拉
        public static IQueryable Get_khxiala()
        {
            NewHope4Entities uu = new NewHope4Entities();
            var obj = from p in uu.customer
                      orderby p.kehuID ascending
                      select new
                      {
                          kehuID = p.kehuID,
                          KehuName = p.KehuName
                      };
            return obj;
        }
        //仓库下拉
        public static IQueryable Get_ckxiala()
        {
            NewHope4Entities uu = new NewHope4Entities();
            var obj = from p in uu.warehouse
                      orderby p.WID ascending
                      select new
                      {
                          WID = p.WID,
                          WName = p.WName
                      };
            return obj;
        }
        //库位下拉
        public static IQueryable Get_cwxiala()
        {
            NewHope4Entities uu = new NewHope4Entities();
            var obj = from p in uu.KuType
                      orderby p.KuTYpeID ascending
                      select new
                      {
                          KuTYpeID = p.KuTYpeID,
                          KuName = p.KuName
                      };
            return obj;
        }
        //新增
        public static int Get_guanliAdd(productguanli p)
        {
            NewHope4Entities uu = new NewHope4Entities();
            uu.productguanli.Add(p);
            return uu.SaveChanges();
        }
        //删除状态
        public static int Get_chanpinguanliDel(string cpID, int state)
        {
            NewHope4Entities uu = new NewHope4Entities();
            var kk = uu.productguanli.Find(cpID);
            kk.cpID = cpID;
            kk.state = state;
            return uu.SaveChanges();
        }
        //修改带id查询
        public static IQueryable Get_chanpinglById(string cpID)
        {
            NewHope4Entities uu = new NewHope4Entities();
            var obj = from p in uu.productguanli
                      where p.cpID == cpID
                      select new
                      {
                          ID = p.ID,//序号
                          cpID = p.cpID, //产品编号 条码
                          cpName = p.cpName,//显示名 产品名称
                          upper = p.upper,//上限
                          floor = p.floor,//下限
                          price = p.price,//价格
                          PID = p.PID,//类别
                          WID = p.WID,//仓库
                                       //库位
                          defaultstorage = p.defaultstorage,
                          specification = p.specification,//规格
                          PNames = p.productType.PName, //类别 产品类别
                          MNames = p.measurement.MName,//单位 
                          MID= p.MID,//单位
                          kehuID = p.kehuID,//客户
                          remark = p.remark,//备注
                          KehuNames = p.customer.KehuName,//客户
                          WNames = p.warehouse.WName,//默认仓库
                          KuNames = p.KuType.KuName//默认库位

                      };
            return obj;
        }
        //修改
        public static int Get_chanpinglupdate(productguanli p)
        {
            NewHope4Entities uu = new NewHope4Entities();
            var obj = uu.productguanli.Find(p.cpID);
            obj.cpName = p.cpName;//显示名 产品名称
            obj.upper = p.upper;//上限
            obj.floor = p.floor;//下限
            obj.price = p.price;//价格
            obj.specification = p.specification;//规格
            obj.PID = p.PID;//类别 产品类别
            obj.MID = p.MID;//单位 
            obj.remark = p.remark;//备注
            obj.kehuID = p.kehuID;//客户
            obj.WID = p.WID;//默认仓库
            obj.defaultstorage = p.defaultstorage;//默认库位
            return uu.SaveChanges();
        }

    }
}

