using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD;
using DAL;
namespace BLL
{
  public  class YQmanager
    {
        //计量单位  查询
        //public static IQueryable measurementQurey()
        //{
        //    return YQdal.measurementQurey();
        //}
        //条件查询
        public static IQueryable dtmeasurementQurey(string MName)
        {
            return YQdal.dtmeasurementQurey(MName);
        }
        //分页
        public static PageList fyqureyAll(int pageIndex, int pageSize)
        {
            return YQdal.fyqureyAll(pageIndex, pageSize);
        }
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
            return YQdal.jiliangdanwei_Del(MID,state);
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
        }
}
