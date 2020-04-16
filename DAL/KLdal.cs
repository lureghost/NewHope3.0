using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD;


namespace DAL
{
   public class    KLdal
    {
        static NewHope4Entities context = new NewHope4Entities();

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public static PageList Get_kuweiAll(int PageIndex,int PageSize)
        {
            PageList list = new PageList();
            var obj = from p in context.storage
                       orderby p.TID descending
                       select new
                       {
                           TID = p.TID,
                           KName = p.KName,
                           WID = p.WID,
                           WName = p.warehouse.WName,
                           KuTypeID = p.KuTypeID,
                           KuName = p.KuType.KuName,
                           forbidden = p.forbidden,
                           defaults = p.@default,
                           CreationDate = p.CreationDate,
                           state = p.state,
                           rows=context.storage.Count()
                       };
            list.DateList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            list.PageCount = context.storage.Count();
            //list.PageCount = row % PageSize == 0 ? row / PageSize : row / PageSize + 1;

            return list;
        }


        public static IQueryable Get_kuweiAlls()
        {
            
            var obj = from p in context.storage
                      orderby p.TID descending
                      select new
                      {
                          TID = p.TID,
                          KName = p.KName,
                          WID = p.WID,
                          WName = p.warehouse.WName,
                          KuTypeID = p.KuTypeID,
                          KuName = p.KuType.KuName,
                          forbidden = p.forbidden,
                          defaults = p.@default,
                          CreationDate = p.CreationDate,
                          state = p.state,
                          rows = context.storage.Count()
                      };
           
            return obj;
        }
    }
}
