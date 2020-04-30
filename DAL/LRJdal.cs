using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD;

namespace DAL
{
   public class LRJdal
    {
        static NewHope4Entities entity = new NewHope4Entities ();
        //退货模块
        public static IQueryable Gettuihuo()
        {
            var obj = from p in entity.tuihuo
                      where p.state<3
                      select new
                      {
                          tuihuoID = p.tuihuoID,
                          tuihuoTypeID = p.tuihuoTypeID,
                          chanpinID = p.chanpinID,
                          sum = p.sum,
                          UserID = p.UserID,
                          state = p.state,
                          CreationDate = p.CreationDate
                      };
            return obj;
        }
        public static IQueryable GettuihuoSH()
        {
            var obj = from p in entity.tuihuo
                      where p.state == 1
                      select new
                      {
                          tuihuoID = p.tuihuoID,
                          tuihuoTypeID = p.tuihuoTypeID,
                          chanpinID = p.chanpinID,
                          sum = p.sum,
                          UserID = p.UserID,
                          state = p.state,
                          CreationDate = p.CreationDate
                      };
            return obj;
        }
        public static IQueryable GettuihuoSH2()
        {
            var obj = from p in entity.tuihuo
                      where p.state == 2
                      select new
                      {
                          tuihuoID = p.tuihuoID,
                          tuihuoTypeID = p.tuihuoTypeID,
                          chanpinID = p.chanpinID,
                          sum = p.sum,
                          UserID = p.UserID,
                          state = p.state,
                          CreationDate = p.CreationDate
                      };
            return obj;
        }
        public static IQueryable GettuihuoSH3()
        {
            var obj = from p in entity.tuihuo
                      where p.state == 0
                      select new
                      {
                          tuihuoID = p.tuihuoID,
                          tuihuoTypeID = p.tuihuoTypeID,
                          chanpinID = p.chanpinID,
                          sum = p.sum,
                          UserID = p.UserID,
                          state = p.state,
                          CreationDate = p.CreationDate
                      };
            return obj;
        }
        public static IQueryable Getthxq(string name)
        {
            var obj = from p in entity.tuihuoxq
                      where p.chanpinName.Contains(name)
                      select new
                      {
                          tuihuoxqID = p.tuihuoxqID,
                          chanpinID = p.chanpinID,
                          chanpintiaoma = p.chanpintiaoma,
                          chanpinName = p.chanpinName,
                          chanpinpici = p.chanpinpici,
                          tuihuosum = p.tuihuosum,
                          chanpinPrice = p.chanpinPrice,
                          kehuID = p.kehuID,
                          tuihuoTypeID = p.tuihuoTypeID
                      };
            return obj;
        }
        public static IQueryable GetBythxqId(int id)
        {

            var obj = from p in entity.tuihuoxq
                      where p.tuihuoxqID == id
                      select new
                      {
                          tuihuoxqID = p.tuihuoxqID,
                          chanpinID = p.chanpinID,
                          chanpintiaoma = p.chanpintiaoma,
                          chanpinName = p.chanpinName,
                          chanpinpici = p.chanpinpici,
                          tuihuosum = p.tuihuosum,
                          chanpinPrice = p.chanpinPrice,
                          kehuID = p.kehuID,
                          tuihuoTypeID = p.tuihuoTypeID
                      };
            return obj;
        }
        public static int Addtuihuo(tuihuo t)
        {

            entity.tuihuo.Add(t);


            return entity.SaveChanges();
        }
        public static IQueryable GetthID(int id)
        {
            var obj = from p in entity.tuihuo
                      where p.tuihuoID == id
                      select new
                      {
                          tuihuoID = p.tuihuoID,
                          tuihuoTypeID = p.tuihuoTypeID,
                          chanpinID = p.chanpinID,
                          sum = p.sum,
                          UserID = p.UserID,
                          state = p.state,
                          CreationDate = p.CreationDate
                      };
            return obj;

        }
        public static int Edit(tuihuo t)
        {
            var obj = (from p in entity.tuihuo where p.tuihuoID == t.tuihuoID select p).First();
            obj.tuihuoID = t.tuihuoID;
            obj.tuihuoTypeID = t.tuihuoTypeID;
            obj.chanpinID = t.chanpinID;
            obj.CreationDate = t.CreationDate;
            obj.UserID = t.UserID;
            obj.sum = t.sum;
            return entity.SaveChanges();
        }
        public static int Deltuihuo(int id)
        {
            var obj = (from p in entity.tuihuo where p.tuihuoID == id select p).First();
            entity.tuihuo.Remove(obj);

            return entity.SaveChanges();
        }
        public static PageList GetthPage(int PageIndex, int PageSize)
        {
            PageList list = new PageList();
            var obj = from p in entity.tuihuo
                      orderby p.tuihuoID
                      select new
                      {
                          tuihuoID = p.tuihuoID,
                          tuihuoTypeID = p.tuihuoTypeID,
                          chanpinID = p.chanpinID,
                          sum = p.sum,
                          UserID = p.UserID,
                          state = p.state,
                          CreationDate = p.CreationDate

                      };
            list.DateList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);

            int rows = entity.tuihuo.Count();
            list.PageCount = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;


            return list;


        }
        //盘点模块
        public static IQueryable Getpandian()
        {
            var obj = from p in entity.panDian
                      where p.state <3
                      select new
                      {
                          pandianID = p.pandianID,
                          pandianTypeID = p.pandianTypeID,
                          chanpinID = p.chanpinID,
                          caozuofs = p.caozuofs,
                          UserID = p.UserID,
                          state = p.state,
                          CreationDate = p.CreationDate
                      };
            return obj;
        }
        public static IQueryable GetpandianSH()
        {
            var obj = from p in entity.panDian
                      where p.state == 1
                      select new
                      {
                          pandianID = p.pandianID,
                          pandianTypeID = p.pandianTypeID,
                          chanpinID = p.chanpinID,
                          caozuofs = p.caozuofs,
                          UserID = p.UserID,
                          state = p.state,
                          CreationDate = p.CreationDate
                      };
            return obj;
        }
        public static IQueryable GetpandianSH2()
        {
            var obj = from p in entity.panDian
                      where p.state == 2
                      select new
                      {
                          pandianID = p.pandianID,
                          pandianTypeID = p.pandianTypeID,
                          chanpinID = p.chanpinID,
                          caozuofs = p.caozuofs,
                          UserID = p.UserID,
                          state = p.state,
                          CreationDate = p.CreationDate
                      };
            return obj;
        }
        public static IQueryable GetpandianSH3()
        {
            var obj = from p in entity.panDian
                      where p.state == 0
                      select new
                      {
                          pandianID = p.pandianID,
                          pandianTypeID = p.pandianTypeID,
                          chanpinID = p.chanpinID,
                          caozuofs = p.caozuofs,
                          UserID = p.UserID,
                          state = p.state,
                          CreationDate = p.CreationDate
                      };
            return obj;
        }
        public static IQueryable Getzuhepandian(string name, int leibie)
        {
            var obj = from p in entity.pandianxq
                      select new
                      {
                          pandianxqID = p.pandianxqID,
                          pandianTypeID = p.pandianTypeID,
                          chanpinID = p.chanpinID,
                          chanpintiaoma = p.chanpintiaoma,
                          chanpinPrice = p.chanpinPrice,
                          chanpinpici = p.chanpinpici,
                          kehuID = p.kehuID,
                          chanpinName= p.chanpinName,
                          pandiansum = p.pandiansum
                      };
            if (!string.IsNullOrEmpty(name))
            {
                obj = obj.Where(p => p.chanpinName.Contains(name));

            }
            if (leibie!=0)
            {
                obj = obj.Where(p => p.pandianTypeID==leibie);
            }
            return obj;
        }
        public static IQueryable GetBypdxqId(int id)
        {

            var obj = from p in entity.pandianxq
                      where p.pandianxqID == id
                      select new
                      {
                          pandianxqID = p.pandianxqID,
                          pandianTypeID = p.pandianTypeID,
                          chanpinID = p.chanpinID,
                          chanpintiaoma = p.chanpintiaoma,
                          chanpinPrice = p.chanpinPrice,
                          chanpinpici = p.chanpinpici,
                          kehuID = p.kehuID,
                          chanpinName = p.chanpinName,
                          pandiansum = p.pandiansum
                      };
            return obj;
        }
        public static int Addpandian(panDian pan)
        {

            entity.panDian.Add(pan);


            return entity.SaveChanges();
        }
        public static IQueryable GetpdID(int id)
        {
            var obj = from p in entity.panDian
                      where p.pandianID == id
                      select new
                      {
                          pandianID = p.pandianID,
                          pandianTypeID = p.pandianTypeID,
                          chanpinID = p.chanpinID,
                          caozuofs = p.caozuofs,
                          UserID = p.UserID,
                          state = p.state,
                          CreationDate = p.CreationDate
                      };
            return obj;

        }
        public static int Edit(panDian pan)
        {
            var obj = (from p in entity.panDian where p.pandianID == pan.pandianID select p).First();
            obj.pandianID = pan.pandianID;
            obj.pandianTypeID = pan.pandianTypeID;
            obj.chanpinID = pan.chanpinID;
            obj.CreationDate = pan.CreationDate;
            obj.UserID = pan.UserID;
            obj.caozuofs = pan.caozuofs;
            return entity.SaveChanges();
        }
        public static int Delpandian(int id)
        {
            var obj = (from p in entity.panDian where p.pandianID == id select p).First();
            entity.panDian.Remove(obj);

            return entity.SaveChanges();
        }
        public static PageList GetpdPage(int PageIndex, int PageSize)
        {
            PageList list = new PageList();
            var obj = from p in entity.panDian
                      orderby p.pandianID
                      select new
                      {
                          pandianID = p.pandianID,
                          pandianTypeID = p.pandianTypeID,
                          chanpinID = p.chanpinID,
                          caozuofs = p.caozuofs,
                          UserID = p.UserID,
                          state = p.state,
                          CreationDate = p.CreationDate


                      };
            list.DateList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);

            int rows = entity.panDian.Count();
            list.PageCount = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;


            return list;


        }
        //移库模块
        public static IQueryable Getyiku() {
            var obj = from p in entity.yiku where p.state!=3 select new {
                yikuID =p.yikuID,
                yikuTypeID  =p.yikuTypeID,
                chanpinID =p.chanpinID,
                count = p.count,
                UserID  = p.UserID,
                state  =p.state,
                CreationDate=  p.CreationDate
            };
            return obj;
        }
        public static IQueryable GetyikuSH()
        {
            var obj = from p in entity.yiku
                      where p.state ==1
                      select new
                      {
                          yikuID = p.yikuID,
                          yikuTypeID = p.yikuTypeID,
                          chanpinID = p.chanpinID,
                          count = p.count,
                          UserID = p.UserID,
                          state = p.state,
                          CreationDate = p.CreationDate
                      };
            return obj;
        }
        public static IQueryable GetyikuSH2()
        {
            var obj = from p in entity.yiku
                      where p.state == 2
                      select new
                      {
                          yikuID = p.yikuID,
                          yikuTypeID = p.yikuTypeID,
                          chanpinID = p.chanpinID,
                          count = p.count,
                          UserID = p.UserID,
                          state = p.state,
                          CreationDate = p.CreationDate
                      };
            return obj;
        }
        public static IQueryable GetyikuSH3()
        {
            var obj = from p in entity.yiku
                      where p.state == 0
                      select new
                      {
                          yikuID = p.yikuID,
                          yikuTypeID = p.yikuTypeID,
                          chanpinID = p.chanpinID,
                          count = p.count,
                          UserID = p.UserID,
                          state = p.state,
                          CreationDate = p.CreationDate
                      };
            return obj;
        }
        public static IQueryable Getzuheyiku(string id, string startime )
        {
            var obj = from p in entity.yiku
                      select new
                      {
                          yikuID = p.yikuID,
                          yikuTypeID = p.yikuTypeID,
                          chanpinID = p.chanpinID,
                          count = p.count,
                          UserID = p.UserID,
                          state = p.state,
                          CreationDate = p.CreationDate

                      };
            if (!string.IsNullOrEmpty(id))
            {
                obj = obj.Where(p => p.chanpinID.Contains(id));

            }
            if (!string.IsNullOrEmpty(startime))
            {
                obj = obj.Where(p => p.CreationDate.ToString().Contains(startime));
            }
            return obj;
        }
        public static IQueryable GetByxqId(int id)
        {

            var obj = from p in entity.yikuxq
                      where p.yikuxqID == id 
                      select new
                      {
                          yikuxqID = p.yikuxqID,
                          chanpinID = p.chanpinID,
                          chanpintiaoma = p.chanpintiaoma,
                          chanpinName = p.chanpinName,
                          chanpinpici = p.chanpinpici,
                          yikusum = p.yikusum,
                          chanpinPrice = p.chanpinPrice,
                          kehuID = p.kehuID,
                          yikuTypeID = p.yikuTypeID
                      };
            return obj;
        }
        public static int Addyiku(yiku y) {
           
            entity.yiku.Add(y);
             

            return entity.SaveChanges();
        }
        public static IQueryable Getyikuxq(string y) {
            var obj = from p in entity.yikuxq  where p.chanpintiaoma.Contains(y)
                      select new
                      {
                          yikuxqID = p.yikuxqID        ,
                          chanpinID = p.chanpinID       ,
                          chanpintiaoma = p.chanpintiaoma   ,
                          chanpinName = p.chanpinName     ,
                          chanpinpici = p.chanpinpici     ,
                          yikusum = p.yikusum         ,
                          chanpinPrice = p.chanpinPrice    ,
                          kehuID = p.kehuID          ,
                          yikuTypeID = p.yikuTypeID
                      };
            return obj;
        }

        public static IQueryable GetyikuID(int id) {
            var obj = from p in entity.yiku where p.yikuID == id select new {
                yikuID=  p.yikuID,
                yikuTypeID=   p.yikuTypeID,
                chanpinID=  p.chanpinID,
                CreationDate=p.CreationDate,
                UserID=  p.UserID
            };
            return obj;
           
        }
        public static int Edit(yiku y) {
            var obj = (from p in entity.yiku where p.yikuID == y.yikuID select p).First();
            obj.yikuID = y.yikuID;
            obj.yikuTypeID = y.yikuTypeID;
            obj.chanpinID = y.chanpinID;
            obj.CreationDate = y.CreationDate;
            obj.UserID = y.UserID;
            return entity.SaveChanges();
        }
        public static int Delyiku(int id) {
            var obj = (from p in entity.yiku where p.yikuID == id select p).First();
            entity.yiku.Remove(obj);

            return entity.SaveChanges();
        }
        public static int Delyikuxq(int id)
        {

            var obj = (from p in entity.yikuxq where p.yikuxqID == id select p).First();
            entity.yikuxq.Remove(obj);
            return entity.SaveChanges();
        }
        public static PageList GetyikuPage(int PageIndex, int PageSize)
        {
            PageList list = new PageList();
            var obj = from p in entity.yiku
                      orderby p.yikuID
                      select new
                      {
                          yikuID = p.yikuID,
                          yikuTypeID = p.yikuTypeID,
                          chanpinID = p.chanpinID,
                          count = p.count,
                          UserID = p.UserID,
                          state = p.state,
                          CreationDate = p.CreationDate


                      };
            list.DateList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);

            int rows = entity.yiku.Count();
            list.PageCount = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;


            return list;


        }
    }
}
