using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD;
using DAL;
namespace BLL
{
    public class YQmanager
    {
        //条件查询
        public static IQueryable dtmeasurementQurey(int MID, string MName)
        {
            return YQdal.dtmeasurementQurey(MID, MName);
        }
        //分页
        public static PageList fyqureyAll(int pageIndex, int pageSize)
        {
            return YQdal.fyqureyAll(pageIndex, pageSize);
        }
        //获取行
        public static int GetCount(int pageSize)
        {
            int rows = YQdal.GetRows();
            if (rows % pageSize == 0)
            {
                return rows / pageSize;
            }
            return rows / pageSize + 1;
        }
        //删除状态
        public static int jiliangdanwei_Del(int MID, int state)
        {
            return YQdal.jiliangdanwei_Del(MID, state);
        }
        //删除
        public static int Get_jiliangdanweiDel2(int id)
        {
            return YQdal.Get_jiliangdanweiDel2(id);
        }

        //计量单位 新增
        public static int measurementadd(measurement k)
        {
            return YQdal.measurementadd(k);
        }
        //带id查询
        public static IQueryable Get_jiliangdanweiByid(int MID)
        {
            return YQdal.Get_jiliangdanweiByid(MID);
        }
        //修改
        public static int Get_jiliangdanweiupdate(measurement m)
        {
            return YQdal.Get_jiliangdanweiupdate(m);
        }





        //产品类别
        //分页查询
        public static PageList Get_chanpinglbAll(int pageIndex, int pageSize)
        {
            return YQdal.Get_chanpinglbAll(pageIndex, pageSize);
        }
        //获取行
        public static int GetCountlb(int pageSize)
        {
            int rows = YQdal.GetRowslb();
            if (rows % pageSize == 0)
            {
                return rows / pageSize;
            }
            return rows / pageSize + 1;
        }
        //模糊查询
        public static IQueryable Get_chanpinlbmohucha(int PID, string PName)
        {
            return YQdal.Get_chanpinlbmohucha(PID, PName);
        }
        //新增
        public static int Get_chanpinlbAdd(productType p)
        {
            return YQdal.Get_chanpinlbAdd(p);
        }
        //删除状态
        public static int Get_chanpinlbDel(int PID, int state)
        {
            return YQdal.Get_chanpinlbDel(PID, state);
        }
        //修改带id查询
        public static IQueryable Get_chanpinlbById(int PID)
        {
            return YQdal.Get_chanpinlbById(PID);
        }
        //修改
        public static int Get_chanpinlbupdate(productType p)
        {
            return YQdal.Get_chanpinlbupdate(p);
        }





        //产品管理
        //分页查询
        public static PageList Get_chanpingguanliAll(int pageIndex, int pageSize)
        {
            return YQdal.Get_chanpingguanliAll(pageIndex, pageSize);

        }
        //获取行
        public static int GetCountguanli(int pageSize)
        {
            int rows = YQdal.Get_Rowsguanli();
            if (rows % pageSize == 0)
            {
                return rows / pageSize;
            }
            return rows / pageSize + 1;
        }
        //类别下拉查询
        public static IQueryable Get_lbxiala()
        {
            return YQdal.Get_lbxiala();
        }
        //条件查询
        public static IQueryable Get_chanpinguanlimohucha(string cpID, string cpName, int PID)
        {
            return YQdal.Get_chanpinguanlimohucha(cpID, cpName, PID);
        }
        //单位下拉
        public static IQueryable Get_dwxiala()
        {
            return YQdal.Get_dwxiala();
        }
        //客户下拉
        public static IQueryable Get_khxiala()
        {
            return YQdal.Get_khxiala();
        }
        //仓库下拉
        public static IQueryable Get_ckxiala()
        {
            return YQdal.Get_ckxiala();
        }
        //库位下拉
        public static IQueryable Get_cwxiala()
        {
            return YQdal.Get_cwxiala();
        }
        //新增
        public static int Get_guanliAdd(productguanli p)
        {
            return YQdal.Get_guanliAdd(p);
        }
        //删除状态
        public static int Get_chanpinguanliDel(string cpID, int state) {
            return YQdal.Get_chanpinguanliDel(cpID, state);
        }
        //修改带id查询
        public static IQueryable Get_chanpinglById(string cpID)
        {
            return YQdal.Get_chanpinglById(cpID);
        }
        //修改
        public static int Get_chanpinglupdate(productguanli p)
        {
            return YQdal.Get_chanpinglupdate(p);
        }
    }
}


