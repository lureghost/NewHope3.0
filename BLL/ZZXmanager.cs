using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD;
using DAL;
namespace BLL
{
    public class ZZXmanager
    {
        #region 登录
        public static int Login(string UserName, int UserPwd)
        {
            return DAL.ZZXdal.Login(UserName, UserPwd);
        }
        public static IQueryable IndexByName(string UserName)
        {
            return DAL.ZZXdal.IndexByName(UserName);
        }
        #endregion
        #region 员工管理(admin)
        public static HouseFenYe AdminChaXun(int pageIndex, int pageSize)//
        {
            return DAL.ZZXdal.AdminChaXun(pageIndex, pageSize);//
        }
        //根据员工编号和员工名称查询
        public static HouseFenYe AdminChaXunByName(string user2, int pageIndex, int pageSize)// 
        {
            return DAL.ZZXdal.AdminChaXunByName(user2, pageIndex, pageSize);//
        }
        public static IQueryable departmentName()
        {
            return ZZXdal.departmentName();
        }
        public static IQueryable roleName()
        {
            return ZZXdal.roleName();
        }
        public static IQueryable AdminById(int id)
        {
            return DAL.ZZXdal.AdminById(id);
        }
        public static int AdminXiuGai(Admin a)
        {
            return DAL.ZZXdal.AdminXiuGai(a);
        }
        public static int AdminXinZeng(Admin a)
        {
            return DAL.ZZXdal.AdminXinZeng(a);
        }
        public static int AdminDel(int id)
        {
            return DAL.ZZXdal.AdminDel(id);
        }
        public static HouseFenYe AdminHouseChaXun(int userId, string name, int BuMen, int JueSe, int pageIndex, int pageSize)
        {
            return DAL.ZZXdal.AdminHouseChaXun(userId, name, BuMen, JueSe, pageIndex, pageSize);
        }
        #endregion

        #region 角色管理(role)
        public static HouseFenYe roleChaXun(int pageIndex, int pageSize)// 
        {
            return DAL.ZZXdal.roleChaXun(pageIndex, pageSize);
        }
        //根据角色编号或角色名称查询
        public static HouseFenYe roleChaXunByName(string user2, int pageIndex, int pageSize)// 
        {
            return DAL.ZZXdal.roleChaXunByName(user2, pageIndex, pageSize);
        }
        public static int roleXinZeng(role r)
        {
            return DAL.ZZXdal.roleXinZeng(r);
        }
        //删除
        public static int roleShanChu(role r)
        {
            return DAL.ZZXdal.roleShanChu(r);
        }
        //根据id查询，进行修改操作
        public static IQueryable roleById(int id)
        {
            return DAL.ZZXdal.roleById(id);
        }
        public static int roleXiuGai(role r)
        {
            return DAL.ZZXdal.roleXiuGai(r);
        }
        #endregion

        #region 部门管理(department)
        public static HouseFenYe departmentChaXun(int pageIndex, int pageSize)// 
        {
            return DAL.ZZXdal.departmentChaXun(pageIndex, pageSize);
        }
        public static int departmentXinZeng(department d)
        {
            return DAL.ZZXdal.departmentXinZeng(d);
        }
        //根据员工名称查询
        public static HouseFenYe departmentChaXunByName(string user2, int pageIndex, int pageSize)// 
        {
            return DAL.ZZXdal.departmentChaXunByName(user2, pageIndex, pageSize);
        }
        //删除
        public static int departmentShanChu(department d)
        {
            return DAL.ZZXdal.departmentShanChu(d);
        }
        //根据id查询，进行修改操作
        public static IQueryable departmentById(int id)
        {
            return DAL.ZZXdal.departmentById(id);
        }
        public static int departmentXiuGai(department d)
        {
            return DAL.ZZXdal.departmentXiuGai(d);
        }
        #endregion

        #region 菜单管理(menu)
        public static HouseFenYe menuChaXun(int pageIndex, int pageSize)// 
        {
            return DAL.ZZXdal.menuChaXun(pageIndex, pageSize);
        }
        //根据员工名称查询
        public static HouseFenYe menuChaXunByName(string user2, int pageIndex, int pageSize)// 
        {
            return DAL.ZZXdal.menuChaXunByName(user2, pageIndex, pageSize);
        }
        // 父级菜单查询(Parentmenu)
        public static IQueryable ParentmenuName()
        {
            return DAL.ZZXdal.ParentmenuName();
        }
        //菜单栏查询
        public static IQueryable menuBarChaXun()// 
        {
            return DAL.ZZXdal.menuBarChaXun();
        }
        public static IQueryable menuBarChaXun2(int id)// 
        {
            return DAL.ZZXdal.menuBarChaXun2(id);
        }
        // 菜单类型查询(MenuType)
        public static IQueryable MenuTypeName()
        {
            return DAL.ZZXdal.MenuTypeName();
        }
        public static int menuXinZeng(menu m)
        {
            return DAL.ZZXdal.menuXinZeng(m);
        }
        // Parentmenu父级表新增
        public static int ParentmenuXinZeng(Parentmenu p)
        {
            return DAL.ZZXdal.ParentmenuXinZeng(p);
        }
        //删除
        public static int menuShanChu(menu m)
        {
            return DAL.ZZXdal.menuShanChu(m);
        }
        //根据id查询，进行修改操作
        public static IQueryable menuById(int id)
        {
            return DAL.ZZXdal.menuById(id);
        }
        public static int menuXiuGai(menu m)
        {
            return DAL.ZZXdal.menuXiuGai(m);
        }
        #endregion
    }
}
