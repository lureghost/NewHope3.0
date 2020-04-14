using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD;
using DAL;
namespace BLL
{
   public class ZZXBLL
    {
        #region 用户表操作(Admin)
        public static IQueryable AdminChaXun()
        {
            return ZZXDAL.AdminChaXun();
        }
        #endregion
        }
}
