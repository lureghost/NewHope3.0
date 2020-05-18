using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD;
using DAL;
namespace BLL
{
    public class LRJmanager
    {
        //移库模块
        public static IQueryable Getyiku()
        {
            return LRJdal.Getyiku();
        }
        public static int Addyiku(yiku y)
        {
            return LRJdal.Addyiku(y);
        }
        public static IQueryable GetyikuID(int id)
        {
            return LRJdal.GetyikuID(id);
        }
        public static int Edit(yiku y)
        {
            return LRJdal.Edit(y);
        }
        public static int Delyikuxq(int id)
        {
            return LRJdal.Delyikuxq(id);
        }
        public static IQueryable Getyikuxq(string y)
        {
            return LRJdal.Getyikuxq(y);
        }
        public static IQueryable GetByxqId(int id)
        {
            return LRJdal.GetByxqId(id);
        }
        public static IQueryable Getzuheyiku(string id, string startime)
        {
            return LRJdal.Getzuheyiku(id,startime);
        }
        public static IQueryable GetyikuSH() {
            return LRJdal.GetyikuSH();
        }
        public static IQueryable GetyikuSH2()
        {
            return LRJdal.GetyikuSH2();
        }
        public static IQueryable GetyikuSH3()
        {
            return LRJdal.GetyikuSH3();
        }
        public static int Delyiku(int id)
        {
            return LRJdal.Delyiku(id);
        }
        public static PageList GetyikuPage(int PageIndex, int PageSize)
        {
            return LRJdal.GetyikuPage(PageIndex,PageSize);
        }
        //盘点模块
        public static IQueryable Getpandian()
        {
            return LRJdal.Getpandian();
        }
        public static IQueryable GetpandianSH()
        {
            return LRJdal.GetpandianSH();
        }
        public static IQueryable GetpandianSH2()
        {
            return LRJdal.GetpandianSH2();
        }
        public static IQueryable GetpandianSH3()
        {
            return LRJdal.GetpandianSH3();
        }
        public static IQueryable Getzuhepandian(string name, int leibie)
        {
            return LRJdal.Getzuhepandian(name,leibie);
        }
        public static IQueryable GetBypdxqId(int id)
        {
            return LRJdal.GetBypdxqId(id);
        }
        public static int Addpandian(panDian pan)
        {
            return LRJdal.Addpandian(pan);
        }
        public static IQueryable GetpdID(int id)
        {
            return LRJdal.GetpdID(id);
        }
        public static int Edit(panDian pan)
        {
            return LRJdal.Edit(pan);
        }
        public static int Delpandian(int id)
        {
            return LRJdal.Delpandian(id);
        }
        public static PageList GetpdPage(int PageIndex, int PageSize)
        {
            return LRJdal.GetpdPage(PageIndex,PageSize);
        }
        //退货模块
        public static IQueryable Gettuihuo()
        {
            return LRJdal.Gettuihuo();
        }
        public static IQueryable GettuihuoSH()
        {
            return LRJdal.GettuihuoSH();
        }
        public static IQueryable GettuihuoSH2()
        {
            return LRJdal.GettuihuoSH2();
        }
        public static IQueryable GettuihuoSH3()
        {
            return LRJdal.GettuihuoSH3();
        }
        public static IQueryable Getthxq(string name)
        {
            return LRJdal.Getthxq(name);
        }
        public static IQueryable GetBythxqId(int id)
        {
            return LRJdal.GetBythxqId(id);
        }
        public static int Addtuihuo(tuihuo t)
        {
            return LRJdal.Addtuihuo(t);
        }
        public static IQueryable GetthID(int id)
        {
            return LRJdal.GetthID(id);
        }
        public static int Edit(tuihuo t)
        {
            return LRJdal.Edit(t);
        }
        public static int Deltuihuo(int id)
        {
            return LRJdal.Deltuihuo(id);
        }
        public static PageList GetthPage(int PageIndex, int PageSize)
        {
            return LRJdal.GetthPage(PageIndex,PageSize);
        }
        }
}
