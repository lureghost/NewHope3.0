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
    
        public static NewHope4Entities uu = new NewHope4Entities();
        //计量单位 查询
        public static IQueryable measurementQurey()
        {
            var obj = from p in uu.measurement
                      orderby p.MID ascending
                      select new
                      {
                          //XID = p.XID,
                          MID = p.MID,
                          MName = p.MName
                      };
            return obj;
        }
        //计量单位 新增
        public static int measurementadd(measurement k)
        {
            uu.measurement.Add(k);
            return uu.SaveChanges();
        }

    }
}
