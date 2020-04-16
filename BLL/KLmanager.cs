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
     
        public static PageList Get_kuweiAll(int PageIndex, int PageSize)
        {
            return KLdal.Get_kuweiAll(PageIndex, PageSize);
        }

        
        public static IQueryable Get_kuweiAllss()
        {
            return KLdal.Get_kuweiAllss();
        }

        /// <summary>
        /// 库位新增
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int Get_kuweiInsert(storage s)
        {
            return KLdal.Get_kuweiInsert(s);
        }


        /// <summary>
        /// 库位删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int Get_kuweiDel(int id)
        {
            return KLdal.Get_kuweiDel(id);
        }

        /// <summary>
        /// 库位修改
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int Get_kuweiupdate(storage s)
        {
            return KLdal.Get_kuweiupdate(s);
        }


        /// <summary>
        /// 库位根据id查询
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int Get_kuweiByid(int ID)
        {
            return KLdal.Get_kuweiByid(ID);
        }
        }
}
