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


        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public static PageList Get_kuweiAll(int PageIndex, int PageSize)
        {

            NewHope4Entities context = new NewHope4Entities();
            PageList list = new PageList();
            var states = 0;
            var obj = from p in context.storage
                      orderby p.TID descending
                      where p.state == states
                      select new
                      {
                          TID = p.TID,
                          KName = p.KName,
                          WID = p.WID,
                          KID = p.KID,
                          WName = p.warehouse.WName,
                          KuTypeID = p.KuTypeID,
                          KuName = p.KuType.KuName,
                          forbidden = p.forbidden,
                          moren = p.moren,
                          CreationDate = p.CreationDate,
                          state = p.state,
                          rows = context.storage.Count()
                      };

            list.DateList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            list.PageCount = context.storage.Count();
            //list.PageCount = row % PageSize == 0 ? row / PageSize : row / PageSize + 1;
            return list;
        }


        public static IQueryable Get_kuweiAllss(int WID, int KuTypeID, string KName)
        {

            NewHope4Entities entity = new NewHope4Entities();
            var obj = from p in entity.storage
                      where p.state == 0
                      select new
                      {
                          TID = p.TID,
                          KName = p.KName,
                          WID = p.WID,
                          WName = p.warehouse.WName,
                          KuTypeID = p.KuTypeID,
                          KuName = p.KuType.KuName,
                          forbidden = p.forbidden,
                          moren = p.moren,
                          CreationDate = p.CreationDate,
                          state = p.state,
                          rows = entity.storage.Count()
                      };


            if (WID != 0)
            {
                obj = obj.Where(p => p.WID == WID);
            }
            if (KuTypeID != 0)
            {
                obj = obj.Where(p => p.KuTypeID == KuTypeID);
            }
            if (!string.IsNullOrEmpty(KName))
            {
                obj = obj.Where(p => p.KName.Contains(KName));
            }
            return obj;
        }

        /// <summary>
        /// 库位新增
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int Get_kuweiInsert(storage s)
        {
            NewHope4Entities context = new NewHope4Entities();
            context.storage.Add(s);
            return context.SaveChanges();
        }

        /// <summary>
        /// 库位删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int Get_kuweiDel(int id)
        {
            NewHope4Entities context = new NewHope4Entities();
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
        public static int Get_kuweiupdate(storage s)
        {
            NewHope4Entities entities = new NewHope4Entities();
            var obj = entities.storage.Find(s.TID);
            obj.KName = s.KName;
            obj.WID = s.WID;
            obj.KuTypeID = s.KuTypeID;
            obj.forbidden = s.forbidden;
            obj.moren = s.moren;
            obj.CreationDate = s.CreationDate;
            obj.state = s.state;
            return entities.SaveChanges();

        }

        /// <summary>
        /// 修改状态
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int Get_kuweiupdatestate(int TID, int state)
        {
            NewHope4Entities context = new NewHope4Entities();
            var obj = context.storage.Find(TID);
            obj.TID = TID;
            obj.state = state;
            return context.SaveChanges();
        }

        /// <summary>
        /// 库位根据id查询
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static IQueryable Get_kuweiByid(int ID)
        {
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.storage
                      where p.TID == ID
                      select new
                      {
                          TID = p.TID,
                          KID = p.KID,
                          KName = p.KName,
                          WID = p.WID,
                          WName = p.warehouse.WName,
                          KuTypeID = p.KuTypeID,
                          KuName = p.KuType.KuName,
                          forbidden = p.forbidden,
                          moren = p.moren,
                          CreationDate = p.CreationDate,
                          state = p.state,
                      };
            return obj;

        }

        /// <summary>
        /// 查询库位类型
        /// </summary>
        /// <returns></returns>
        public static IQueryable Get_kuweiType()
        {
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.KuType
                      select new
                      {
                          KuTYpeID = p.KuTYpeID,
                          KuName = p.KuName

                      };
            return obj;
        }

        /// <summary>
        /// 库位仓库查询
        /// </summary>
        /// <returns></returns>
        public static IQueryable Get_kuweiwarehouse()
        {
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.warehouse
                      select new
                      {
                          WID = p.WID,
                          WName = p.WName

                      };
            return obj;
        }


       
        



        /// <summary>
        /// 供应商分页1
        /// </summary>
        /// <returns></returns>
        public static IQueryable Get_gongyingshangAll()
        {
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.gysguanli
                      orderby p.GID descending
                      select new
                      {
                          GID = p.GID,
                          GName = p.GName,
                          gystypeID = p.gystypeID,
                          gystypeName = p.gystype.gystypeName,
                          phone = p.phone,
                          faxes = p.faxes,
                          Email = p.Email,
                          linkman = p.linkman,
                          address = p.address,
                          describe = p.describe,
                          state = p.state
                      };
            return obj;
        }

    }

}


    

