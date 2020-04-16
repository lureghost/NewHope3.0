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
        //计量单位 查询
        public static IQueryable measurementQurey()
        {
            return YQdal.measurementQurey();
        }

        //计量单位 新增
        public static int measurementadd(measurement k)
        {
            return YQdal.measurementadd(k);
        }
        }
}
