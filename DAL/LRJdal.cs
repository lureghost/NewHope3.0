using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD;
namespace DAL
{
  public  class LrjDAL
    {
        public static NewHope4Entities entity = new NewHope4Entities();
        public static IQueryable Getyiku() {
            var obj = from p in entity.yiku select new {
                yikuID= p.yikuID,
                yikuTypeID=   p.yikuTypeID,
                chanpinID=  p.chanpinID,
                count = p.count,
                UserID= p.UserID,
                state= p.state,
                CreationDate= p.CreationDate
            };
            return obj;
        }
    }
}
