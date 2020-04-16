using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD;


namespace DAL
{
    public class KLdal
    {
        static NewHope4Entities context = new NewHope4Entities();

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public static PageList Get_kuweiAll(int PageIndex, int PageSize)
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
                          //defaults = p.@default,
                          CreationDate = p.CreationDate,
                          state = p.state,
                          rows = context.storage.Count()
                      };
            list.DateList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            list.PageCount = context.storage.Count();
            //list.PageCount = row % PageSize == 0 ? row / PageSize : row / PageSize + 1;
            return list;
        }


        public static IQueryable Get_kuweiAllss()
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
                          //defaults = p.@default,
                          CreationDate = p.CreationDate,
                          state = p.state,
                          rows = context.storage.Count()
                      };
            return obj;
        }

        /// <summary>
        /// 库位新增
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int Get_kuweiInsert(storage s) {
            context.storage.Add(s);
            return context.SaveChanges();
        }

        /// <summary>
        /// 库位删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int Get_kuweiDel(int id) {
            var obj = (from p in context.storage
                      where p.TID == id
                      select p).First();
            context.storage.Remove(obj);
            return context.SaveChanges();
        }


        /// <summary>
        /// 库位修改
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int Get_kuweiupdate(storage s) {
            var obj= context.storage.Find(s.TID);
            obj.KName = s.KName;
            obj.WID = s.WID;
            obj.KuTypeID = s.KuTypeID;
            obj.forbidden = s.forbidden;
            //obj.defaults =s.
            obj.CreationDate = s.CreationDate;
            obj.state = s.state;
            return context.SaveChanges();
          
        }

        /// <summary>
        /// 库位根据id查询
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int Get_kuweiByid(int ID) {
            var obj = from p in context.storage
                      where p.TID == ID
                      select p;
            return obj.Count();
        
        }

    }
}
