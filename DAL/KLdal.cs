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
            var obj = from p in context.storage
                      orderby p.TID descending
                      where p.state == 0
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
            int rows = context.storage.Count();
            list.PageCount = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
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
                          KID = p.KID,
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
        /// 供应商分页
        /// </summary>
        /// <returns></returns>
        public static PageList Get_gongyingshangAll(int PageIndex,int PageSize)
        {
            PageList list = new PageList();
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.gysguanli
                      orderby p.GID descending   
                      where p.state == 0
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
                          state = p.state,
                          sum = context.gysguanli.Count()
                      };
            list.DateList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows= context.gysguanli.Count();
            list.PageCount = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;

           
        }

        /// <summary>
        /// 供应商条件查询
        /// </summary>
        /// <returns></returns>
        public static IQueryable Get_gystiaojiAll(int GID, string gystypeName) {
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.gysguanli
                      where p.state == 0 
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
            if (GID > 0||gystypeName!=null)
            {
                obj = obj.Where(p => p.GID == GID || p.gystypeName.Contains(gystypeName));
            }
            return obj;
        }

        /// <summary>
        /// 查询供应商类型
        /// </summary>
        /// <returns></returns>
        public static IQueryable Get_gysTypeAll() {
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.gystype
                      select new
                      {
                          gystypeID = p.gystypeID,
                          gystypeName = p.gystypeName,
                          state = p.state
                      };
            return obj; 
        }

        /// <summary>
        /// 修改状态（删除）
        /// </summary>
        /// <returns></returns>
        public static int Get_gysDel(int GID,int state) {
            NewHope4Entities context = new NewHope4Entities();
            var obj = context.gysguanli.Find(GID);
            obj.GID = GID;
            obj.state=state;
            return context.SaveChanges();
        }

        /// <summary>
        /// 新增供应商
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        public static int Get_gysinsert(gysguanli g) {
            NewHope4Entities context = new NewHope4Entities();
            context.gysguanli.Add(g);
            return context.SaveChanges();
        }


        /// <summary>
        /// 根据供应商id查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static IQueryable Get_gysByid(int id) {
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.gysguanli
                      where p.GID==id
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

        /// <summary>
        /// 修改供应商
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        public static int Get_gysUpdate(gysguanli g) {
            NewHope4Entities context = new NewHope4Entities();
            var obj = context.gysguanli.Find(g.GID);
            obj.GID = g.GID;
            obj.GName = g.GName;
            obj.gystypeID = g.gystypeID;
            obj.phone = g.phone;
            obj.faxes = g.faxes;
            obj.Email = g.Email;
            obj.linkman = g.linkman;
            obj.address = g.address;
            obj.describe = g.describe;
            obj.state = g.state;
            return context.SaveChanges();
        }



        /// <summary>
        /// 客户分页
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public static PageList Get_kehuAll(int PageIndex, int PageSize) {
            PageList list = new PageList();
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.customer
                      orderby p.kehuID descending
                      where p.state == 0
                      select new
                      {
                          kehuID = p.kehuID,
                          KehuName = p.KehuName,
                          phone = p.phone,
                          faxes = p.faxes,
                          CreationDate = p.CreationDate,
                          state = p.state,
                          beizhu=p.beizhu,
                          Email= p.Email,
                          //dizhis = from pp in context.dizhi
                          //     select new {
                          //             dizhiIDs = pp.dizhiID,
                          //             dizhiNames = pp.dizhiName,
                          //             linkmans = pp.linkman,
                          //             phones = pp.phone,
                          //             states = pp.state
                          //         },
                          row =context.customer.Count()
                      };
            list.DateList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = context.customer.Count();
            list.PageCount = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }

        /// <summary>
        /// 修改客户状态("删除")
        /// </summary>
        /// <param name="kehuID"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static int Get_kehuDel(int kehuID,int state) {
            NewHope4Entities context = new NewHope4Entities();
            var obj = context.customer.Find(kehuID);
            obj.kehuID = kehuID;
            obj.state = state;
            return context.SaveChanges();
        }


        /// <summary>
        /// 新增客户表
        /// </summary>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static int Get_kehuinsert(customer c) {
            NewHope4Entities context = new NewHope4Entities();
            context.customer.Add(c);
            return context.SaveChanges();
        }

        /// <summary>
        /// 新增地址表
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static int Get_kehuinsertdizhi(dizhi d)
        {
            NewHope4Entities context = new NewHope4Entities();
            context.dizhi.Add(d);
            return context.SaveChanges();
        }

        /// <summary>
        /// 地址查询
        /// </summary>
        /// <returns></returns>
        public static IQueryable Get_dizhibyid() {
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.dizhi
                      orderby p.dizhiID descending
                      where p.state == 0
                      select new
                      {
                          dizhiIDs = p.dizhiID,
                          dizhiNames = p.dizhiName,
                          linkmans = p.linkman,
                          phones = p.phone,
                          states = p.state
                      };
            return obj.Take(1);
        }

        /// <summary>
        /// 根据客户地址id查询地址
        /// </summary>
        /// <param name="dizhiID"></param>
        /// <returns></returns>
        public static IQueryable Get_dizhichaid(int dizhiID) {
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.dizhi
                      where p.dizhiID == dizhiID && p.state == 0
                      select new
                      {
                          dizhiIDs = p.dizhiID,
                          dizhiNames = p.dizhiName,
                          linkmans = p.linkman,
                          phones = p.phone,
                          states = p.state
                      };
           
            return obj;
        }

        /// <summary>
        /// 编辑客户
        /// </summary>
        /// <param name="kehuID"></param>
        /// <returns></returns>
        public static IQueryable Get_kehubyid(int kehuID) {
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.customer
                      orderby p.kehuID descending
                      where p.kehuID == kehuID && p.state==0
                      select new
                      {
                          kehuID = p.kehuID,
                          KehuName = p.KehuName,
                          phone = p.phone,
                          faxes = p.faxes,
                          CreationDate = p.CreationDate,
                         
                          state = p.state,
                          Email= p.Email,
                          beizhu=p.beizhu,
                          dizhiIDs=p.dizhiID,
                          //dizhis = from pp in context.dizhi
                          //         where pp.dizhiID==p.dizhiID
                          //         select new
                          //         {
                          //             dizhiIDs = pp.dizhiID,
                          //             dizhiNames = pp.dizhiName,
                          //             linkmans = pp.linkman,
                          //             phones = pp.phone,
                          //             states = pp.state
                          //         },
                          row = context.customer.Count()
                      };
            return obj;

        }
    

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static int Get_kehuUpdate(customer c)
        {
            NewHope4Entities context = new NewHope4Entities();
            var obj=context.customer.Find(c.kehuID);
            obj.kehuID = c.kehuID;
            obj.KehuName = c.KehuName;
            obj.phone = c.phone;
            obj.faxes = c.faxes;
            obj.state = c.state;
            obj.CreationDate = c.CreationDate;
            obj.Email = c.Email;
            obj.beizhu = c.beizhu;
            return context.SaveChanges();
        }


        /// <summary>
        /// 修改地址状态("删除")
        /// </summary>
        /// <param name="dizhiID"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static int Get_dizhiDel(int dizhiID, int state)
        {
            NewHope4Entities context = new NewHope4Entities();
            var obj = context.dizhi.Find(dizhiID);
            obj.dizhiID = dizhiID;
            obj.state = state;
            return context.SaveChanges();
        }

        /// <summary>
        /// 修改地址
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static int Get_dizhiUpdate(dizhi d) {
            NewHope4Entities context = new NewHope4Entities();
            var obj = context.dizhi.Find(d.dizhiID);
            obj.dizhiID = d.dizhiID;
            obj.dizhiName = d.dizhiName;
            obj.phone = d.phone;
            obj.linkman = d.linkman;
            obj.state = d.state;
            return context.SaveChanges();
        }

        /// <summary>
        /// 条件查询客户
        /// </summary>
        /// <param name="kehuID"></param>
        /// <param name="KehuName"></param>
        /// <returns></returns>
        public static IQueryable Get_dizhiNamecha(int kehuID,string KehuName) {
            NewHope4Entities context = new NewHope4Entities();
            var obj = from p in context.customer
                      orderby p.kehuID descending
                      where p.state == 0
                      select new {
                          kehuID = p.kehuID,
                          KehuName = p.KehuName,
                          phone = p.phone,
                          faxes = p.faxes,
                          CreationDate = p.CreationDate,
                          state = p.state,
                          beizhu = p.beizhu,
                          Email = p.Email,
                          row = context.customer.Count()
                      };
            if (kehuID>0||KehuName!=null)
            {
                obj = obj.Where(p=>p.kehuID==kehuID|| p.KehuName.Contains(KehuName));
            }
            return obj;
        }



     

    }




}


    

