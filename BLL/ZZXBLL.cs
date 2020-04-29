using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD;
using DAL;
namespace BLL
{
    public class ZZXBLL
    {

        #region 登录
        public static int Login(string UserName, int UserPwd)
        {
            return DAL.ZZXDAL.Login(UserName, UserPwd);
        }
        public static IQueryable IndexByName(string UserName)
        {
            return DAL.ZZXDAL.IndexByName(UserName);
        }
        #endregion
        #region 员工管理(admin)
        public static HouseFenYe AdminChaXun(int pageIndex, int pageSize)//
        {
            return DAL.ZZXDAL.AdminChaXun(pageIndex, pageSize);//
        }
        //根据员工编号和员工名称查询
        public static HouseFenYe AdminChaXunByName(string user2, int pageIndex, int pageSize)// 
        {
            return DAL.ZZXDAL.AdminChaXunByName(user2, pageIndex, pageSize);//
        }
        public static IQueryable departmentName()
        {
            return ZZXDAL.departmentName();
        }
        public static IQueryable roleName()
        {
            return ZZXDAL.roleName();
        }
        public static IQueryable AdminById(int id)
        {
            return DAL.ZZXDAL.AdminById(id);
        }
        public static int AdminXiuGai(Admin a) {
            return DAL.ZZXDAL.AdminXiuGai(a);
        }
        public static int AdminXinZeng(Admin a)
        {
            return DAL.ZZXDAL.AdminXinZeng(a);
        }
        public static int AdminDel(int id)
        {
            return DAL.ZZXDAL.AdminDel(id);
        }
        public static HouseFenYe AdminHouseChaXun(int userId, string name, int BuMen, int JueSe, int pageIndex, int pageSize)
        {
            return DAL.ZZXDAL.AdminHouseChaXun(userId, name, BuMen, JueSe, pageIndex, pageSize);
        }
        #endregion

        #region 角色管理(role)
        public static HouseFenYe roleChaXun(int pageIndex, int pageSize)// 
        {
            return DAL.ZZXDAL.roleChaXun(pageIndex, pageSize);
        }
        //根据角色编号或角色名称查询
        public static HouseFenYe roleChaXunByName(string user2, int pageIndex, int pageSize)// 
        {
            return DAL.ZZXDAL.roleChaXunByName(user2, pageIndex, pageSize);
        }
        public static int roleXinZeng(role r)
        {
            return DAL.ZZXDAL.roleXinZeng(r);
        }
        //删除
        public static int roleShanChu(role r)
        {
            return DAL.ZZXDAL.roleShanChu(r);
        }
        //根据id查询，进行修改操作
        public static IQueryable roleById(int id)
        {
            return DAL.ZZXDAL.roleById(id);
        }
        public static int roleXiuGai(role r)
        {
            return DAL.ZZXDAL.roleXiuGai(r);
        }
        #endregion

        #region 部门管理(department)
        public static HouseFenYe departmentChaXun(int pageIndex, int pageSize)// 
        {
            return DAL.ZZXDAL.departmentChaXun(pageIndex, pageSize);
        }
        public static int departmentXinZeng(department d)
        {
            return DAL.ZZXDAL.departmentXinZeng(d);
        }
        //根据员工名称查询
        public static HouseFenYe departmentChaXunByName(string user2, int pageIndex, int pageSize)// 
        {
            return DAL.ZZXDAL.departmentChaXunByName(user2, pageIndex, pageSize);
        }
        //删除
        public static int departmentShanChu(department d)
        {
            return DAL.ZZXDAL.departmentShanChu(d);
        }
        //根据id查询，进行修改操作
        public static IQueryable departmentById(int id)
        {
            return DAL.ZZXDAL.departmentById(id);
        }
        public static int departmentXiuGai(department d)
        {
            return DAL.ZZXDAL.departmentXiuGai(d);
        }
        #endregion

        #region 菜单管理(menu)
        public static HouseFenYe menuChaXun(int pageIndex, int pageSize)// 
        {
            return DAL.ZZXDAL.menuChaXun(pageIndex, pageSize);
        }
        //根据员工名称查询
        public static HouseFenYe menuChaXunByName(string user2, int pageIndex, int pageSize)// 
        {
            return DAL.ZZXDAL.menuChaXunByName(user2, pageIndex, pageSize);
        }
        // 父级菜单查询(Parentmenu)
        public static IQueryable ParentmenuName()
        {
            return DAL.ZZXDAL.ParentmenuName();
        }
        //菜单栏查询
        public static IQueryable menuBarChaXun()// 
        {
            return DAL.ZZXDAL.menuBarChaXun();
        }
        public static IQueryable menuBarChaXun2(int id)// 
        {
            return DAL.ZZXDAL.menuBarChaXun2(id);
        }
        // 菜单类型查询(MenuType)
        public static IQueryable MenuTypeName()
        {
            return DAL.ZZXDAL.MenuTypeName();
        }
        public static int menuXinZeng(menu m)
        {
            return DAL.ZZXDAL.menuXinZeng(m);
        }
        // Parentmenu父级表新增
        public static int ParentmenuXinZeng(Parentmenu p)
        {
            return DAL.ZZXDAL.ParentmenuXinZeng(p);
        }
        //删除
        public static int menuShanChu(menu m)
        {
            return DAL.ZZXDAL.menuShanChu(m);
        }
        //根据id查询，进行修改操作
        public static IQueryable menuById(int id)
        {
            return DAL.ZZXDAL.menuById(id);
        }
        public static int menuXiuGai(menu m)
        {
            return DAL.ZZXDAL.menuXiuGai(m);
        }
        #endregion
    }
}
