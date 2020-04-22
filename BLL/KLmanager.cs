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


        public static IQueryable Get_kuweiAllss(int WID, int KuTypeID, string KName)
        {
            return KLdal.Get_kuweiAllss(WID, KuTypeID, KName);
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
        /// 修改状态
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int Get_kuweiupdatestate(int TID,int state)
        {
            return KLdal.Get_kuweiupdatestate(TID,state);
        }

            /// <summary>
            /// 库位根据id查询
            /// </summary>
            /// <param name="ID"></param>
            /// <returns></returns>
        public static IQueryable Get_kuweiByid(int ID)
        {
            return KLdal.Get_kuweiByid(ID);
        }

        /// <summary>
        /// 查询库位类型
        /// </summary>
        /// <returns></returns>
        public static IQueryable Get_kuweiType()
        {
            return KLdal.Get_kuweiType();
        }


        /// <summary>
        /// 库位仓库查询
        /// </summary>
        /// <returns></returns>
        public static IQueryable Get_kuweiwarehouse()
        {
            return KLdal.Get_kuweiwarehouse();
        }



        /// <summary>
        /// 供应商分页
        /// </summary>
        /// <returns></returns>
        public static PageList Get_gongyingshangAll(int PageIndex, int PageSize)
        {
            return KLdal.Get_gongyingshangAll(PageIndex, PageSize);
        }

        /// <summary>
        /// 供应商条件查询
        /// </summary>
        /// <returns></returns>
        public static IQueryable Get_gystiaojiAll(int GID, string gystypeName)
        {
            return KLdal.Get_gystiaojiAll(GID, gystypeName);
        }

        /// <summary>
        /// 查询供应商类型
        /// </summary>
        /// <returns></returns>
        public static IQueryable Get_gysTypeAll()
        {
            return KLdal.Get_gysTypeAll();
        }


        /// <summary>
        /// 修改状态（删除）
        /// </summary>
        /// <returns></returns>
        public static int Get_gysDel(int GID, int state)
        {
            return KLdal.Get_gysDel(GID,state);
        }

        /// <summary>
        /// 新增供应商
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        public static int Get_gysinsert(gysguanli g)
        {
            return KLdal.Get_gysinsert(g);
        }

        /// <summary>
        /// 根据供应商id查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static IQueryable Get_gysByid(int id)
        {
            return KLdal.Get_gysByid(id);
        }

        /// <summary>
        /// 修改供应商
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        public static int Get_gysUpdate(gysguanli g)
        {
            return KLdal.Get_gysUpdate(g);
        }

        /// <summary>
        /// 客户分页
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public static PageList Get_kehuAll(int PageIndex, int PageSize)
        {
            return KLdal.Get_kehuAll(PageIndex,PageSize);
        }

        /// <summary>
        /// 修改客户状态("删除")
        /// </summary>
        /// <param name="kehuID"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static int Get_kehuDel(int kehuID, int state)
        {
            return KLdal.Get_kehuDel(kehuID,state);
        }

        /// <summary>
        /// 新增客户表，和地址表
        /// </summary>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static int Get_kehuinsert(customer c)
        {
            return KLdal.Get_kehuinsert(c);
        }

        /// <summary>
        /// 新增地址表
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static int Get_kehuinsertdizhi(dizhi d)
        {
            return KLdal.Get_kehuinsertdizhi(d);
        }


        /// <summary>
        /// 地址查询
        /// </summary>
        /// <returns></returns>
        public static IQueryable Get_dizhibyid()
        {
            return KLdal.Get_dizhibyid();
        }

        /// <summary>
        /// 根据客户地址id查询地址
        /// </summary>
        /// <param name="dizhiID"></param>
        /// <returns></returns>
        public static IQueryable Get_dizhichaid(int dizhiID)
        {
            return KLdal.Get_dizhichaid(dizhiID);
        }

            /// <summary>
            /// 编辑客户
            /// </summary>
            /// <param name="kehuID"></param>
            /// <returns></returns>
            public static IQueryable Get_kehubyid(int kehuID)
        {
            return KLdal.Get_kehubyid(kehuID);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static int Get_kehuUpdate(customer c)
        {
            return KLdal.Get_kehuUpdate(c);
        }

        /// <summary>
        /// 修改地址状态("删除")
        /// </summary>
        /// <param name="dizhiID"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static int Get_dizhiDel(int dizhiID, int state)
        {
            return KLdal.Get_dizhiDel(dizhiID, state);
        }
        /// <summary>
        /// 修改地址
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static int Get_dizhiUpdate(dizhi d)
        {
            return KLdal.Get_dizhiUpdate(d);
        }

        /// <summary>
        /// 条件查询客户
        /// </summary>
        /// <param name="kehuID"></param>
        /// <param name="KehuName"></param>
        /// <returns></returns>
        public static IQueryable Get_dizhiNamecha(int kehuID, string KehuName)
        {
            return KLdal.Get_dizhiNamecha(kehuID,KehuName);
        }

        }
}
