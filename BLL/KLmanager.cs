using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD;
using DAL;

namespace BLL
{
   public class KLmanager
    {
     
        public static PageList Get_kuweiAll(int PageIndex,int PageSize)
        {
            return KLdal.Get_kuweiAll(PageIndex,PageSize);
        }


        public static IQueryable Get_kuweiAlls()
        {
            return KLdal.Get_kuweiAlls();
        }


        }
}
