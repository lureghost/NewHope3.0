using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD;
using DAL;

namespace DAL
{
  public  class YQdal
    {
    
        //public static NewHope4Entities uu = new NewHope4Entities();
        //计量单位  普通查询

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
        public static IQueryable dtmeasurementQurey(/*int MID,*/string MName)
        {
            NewHope4Entities uu = new NewHope4Entities();
            var obj = from p in uu.measurement
                      select new
                      {
                          //XID = p.XID,
                          
                          MID = p.MID,
                          MName = p.MName,
                          createTime = p.createTime,
                      };
            //if (MID != 0)
            //{
            //    obj = obj.Where(p => p.MID == MID);
            //}
            if (!string.IsNullOrEmpty(MName))
            {
                obj = obj.Where(p => p.MName.Contains(MName));
            }
            return obj;
        }
        //普通分页
        public static PageList fyqureyAll(int pageIndex, int pageSize)
        {
            NewHope4Entities uu = new NewHope4Entities();
           PageList list = new PageList();
            var obj = from p in uu.measurement
                      orderby p.MID ascending
                      select new
                      {
                        
                          //XID = p.XID,
                          MID = p.MID,
                          MName = p.MName,
                            createTime = p.createTime,
                      };
            //设置分页数据
            list.DateList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            //设置总页数
            int rows = uu.measurement.Count();
            list.PageCount = rows % pageSize == 0 ? rows / pageSize : rows / pageSize + 1;

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
        }
        //计量单位 新增
        public static int measurementadd(measurement k)
        {
            NewHope4Entities uu = new NewHope4Entities();
            uu.measurement.Add(k);
            return uu.SaveChanges();
        }
        //根据id修改
        public static int Get_jiliangdanweiByid(int ID)
        {
            NewHope4Entities uu = new NewHope4Entities();
            var obj = from p in uu.measurement
                      where p.MID == ID
                      select p;
            return obj.Count();

        }
        //修改
        public static int Get_jiliangdanweiupdate(measurement m)
        {
            NewHope4Entities uu = new NewHope4Entities();
            var obj = uu.measurement.Find(m.MID);
            obj.MName = m.MName;
            obj.createTime = m.createTime;
            obj.state = m.state;
            return uu.SaveChanges();

        }


        //产品类别
        //普通分页
        public static PageList lbqureyAll(int pageIndex, int pageSize)
        {
            NewHope4Entities uu = new NewHope4Entities();
            PageList list = new PageList();
            var obj = from p in uu.productType
                      orderby p.PID ascending
                      select new
                      {

                          //XID = p.XID,
                          PID = p.PID,
                          PName =p.PName,
                          //外键对象
                          UName = p.Admin.UserName,
                          CreationDate = p.CreationDate,
                          remark= p.remark

                      };
            //设置分页数据
            list.DateList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            //设置总页数
            int rows = uu.measurement.Count();
            list.PageCount = rows % pageSize == 0 ? rows / pageSize : rows / pageSize + 1;

            return list;
        }
        //获取行
        public static int GetRowslb()
        {
            NewHope4Entities uu = new NewHope4Entities();
            return uu.productType.Count();
        }


        //产品管理
    }
}
