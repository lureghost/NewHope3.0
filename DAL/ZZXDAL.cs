using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD;
namespace DAL
{
   public class ZZXDAL
    {
        #region 用户表操作(Admin)
        public static IQueryable AdminChaXun()
        {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = from p in ent.Admin
                      select new
                      {
                          Did = p.Did,
                          Email = p.Email,
                          LoginNum = p.LoginNum,
                          UserID = p.UserID,
                          UserName = p.UserName,
                          Name = p.Name,
                          Phone = p.Phone,
                          RID = p.RID,
                          Userpwd = p.Userpwd,
                          UserTypeID = p.UserTypeID,
                          state = p.state,
                      };
            return obj;
        }
        #endregion
    }
}
