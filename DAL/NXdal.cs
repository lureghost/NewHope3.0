using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD;
namespace DAL
{
   public class NXdal
    {
        //查询所有入库数据
        public static IQueryable rukuchaall() {

            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.ruku select new { 
                        
                rukuid=p.rukuID,
                rukuType=p.rukuType.rukuName,
                gysid=p.gysID,
                cpid=p.cpID,
                zt=p.zt,
                userid=p.UserID,
                caozuofs=p.caozuofs,


            
            };
            return obj;
        }
    }
}
