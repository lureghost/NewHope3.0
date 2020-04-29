using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MOD;
namespace DAL
{
    public class ZZXDAL
    {
        #region 登录
        public static int Login(string UserName, int UserPwd)
        {
            NewHope4Entities ent = new NewHope4Entities();
            var ojb = from p in ent.Admin
                      where p.UserName == UserName && p.Userpwd == UserPwd
                      select new
                      {
                          UserID = p.UserID,
                          UserName= p.UserName,
                          Userpwd = p.Userpwd
                      };
            if (ojb.Count() > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        //母版页当前用户名
        public static IQueryable IndexByName(string UserName)
        {
            NewHope4Entities ent = new NewHope4Entities();
            var ojb = from p in ent.Admin
                      where p.UserName == UserName
                      select new
                      {
                          UserID = p.UserID,
                          UserName = p.UserName,
                          Userpwd = p.Userpwd
                      };
            return ojb;
        }
        #endregion

        #region 员工管理(admin)
        // admin管理员表查询
        public static HouseFenYe AdminChaXun(int pageIndex, int pageSize)// 
        {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = from p in ent.Admin
                      orderby p.UserID
                      where p.state == 0
                      select new
                      {
                          UserID = p.UserID,
                          UserName = p.UserName,
                          Name = p.Name,
                          Email = p.Email,
                          Phone = p.Phone,
                          LoginNum = p.LoginNum,
                          Did = p.department.DName,
                          RID = p.role.RName,
                          Userpwd = p.Userpwd,
                          UserTypeID = p.UserTypeID,
                          state = p.state
                      };
            var ms = obj.ToString();
            HouseFenYe fy = new HouseFenYe();
            fy.list = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            fy.PageCount = obj.Count();
            return fy;
            //return obj;
        }
        //根据员工名称查询
        public static HouseFenYe AdminChaXunByName(string user2,int pageIndex, int pageSize)// 
        {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = from p in ent.Admin
                      orderby p.UserID
                      where p.state == 0
                      select new
                      {
                          UserID = p.UserID,
                          UserName = p.UserName,
                          Name = p.Name,
                          Email = p.Email,
                          Phone = p.Phone,
                          LoginNum = p.LoginNum,
                          Did = p.department.DName,
                          RID = p.role.RName,
                          Userpwd = p.Userpwd,
                          UserTypeID = p.UserTypeID,
                          state = p.state
                      };
            try
            {
                int num = int.Parse(user2);
                obj = obj.Where(p => p.UserID == num);
            }
            catch (Exception)
            {
                obj = obj.Where(p => p.UserName.Contains(user2));

            }
            //if (user > 0)
            //{
            //    obj = obj.Where(p => p.UserID == user);
            //}
            //else if(!string.IsNullOrEmpty(user2))
            //{
            //    obj = obj.Where(p => p.UserName.Contains(user2));
            //}
            //var ms = obj.ToString();
            HouseFenYe fy = new HouseFenYe();
            fy.list = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            fy.PageCount = obj.Count();
            return fy;
            //return obj;
        }
        // 部门name查询
        public static IQueryable departmentName() {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = from p in ent.department
                      select new
                      {
                          Did=p.Did,
                          DName = p.DName
                      };
            return obj;
        }
        // 角色name查询
        public static IQueryable roleName()
        {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = from p in ent.role
                      select new
                      {
                          RID = p.RID,
                          RName = p.RName
                      };
            return obj;
        }
        // admin管理员表新增
        public static int AdminXinZeng(Admin a)
        {
            NewHope4Entities ent = new NewHope4Entities();
            a.LoginNum = 0;
            a.UserTypeID = 1;
            a.state = 0;
            ent.Admin.Add(a);
            return ent.SaveChanges();
        }
        //根据id查询，进行修改操作
        public static IQueryable AdminById(int id)
        {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = from p in ent.Admin
                      where p.UserID == id
                      select new
                      {
                          UserID = p.UserID,
                          UserName = p.UserName,
                          Name = p.Name,
                          Email = p.Email,
                          Phone = p.Phone,
                          LoginNum = p.LoginNum,
                          Did = p.Did,
                          RID = p.RID,
                          Userpwd = p.Userpwd,
                          UserTypeID = p.UserTypeID,
                          state = p.state
                      };
            return obj;
        }
        //修改
        public static int AdminXiuGai(Admin a) {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = ent.Admin.Find(a.UserID);
            obj.UserName = a.UserName;
            obj.Name = a.Name;
            obj.Email = a.Email;
            obj.Phone = a.Phone;
            obj.Did = a.Did;
            obj.RID = a.RID;
            return ent.SaveChanges();
        }
        // admin管理员表删除
        public static int AdminDel(int id)
        {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = ent.Admin.Find(id);
            obj.state = 1;
            ent.Admin.Remove(obj);
            return ent.SaveChanges();
        }
        //模糊查询
        public static HouseFenYe AdminHouseChaXun(int userId,string name,int BuMen,int JueSe,int pageIndex, int pageSize)
        {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = from p in ent.Admin
                      orderby p.UserID
                      where p.state == 0
                      select new
                      {
                          UserID = p.UserID,
                          UserName = p.UserName,
                          Name = p.Name,
                          Email = p.Email,
                          Phone = p.Phone,
                          LoginNum = p.LoginNum,
                          Did = p.department.DName,
                          RID = p.role.RName,
                          Did2 = p.Did,
                          Rid2 = p.RID,
                          Userpwd = p.Userpwd,
                          UserTypeID = p.UserTypeID,
                          state = p.state
                      };
           
            if (userId!=0)
            {
                obj = obj.Where(p => p.UserID==userId);
            }
            if (!string.IsNullOrEmpty(name))
            {
                obj = obj.Where(p => p.Name.Contains(name));
            }
            if (BuMen != 0)
            {
                obj = obj.Where(p => p.Did2 == BuMen);
            }
            if (JueSe != 0)
            {
                obj = obj.Where(p => p.Rid2 == JueSe);
            }
            var ms = obj.ToString();
            HouseFenYe fy = new HouseFenYe();
            fy.list = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            fy.PageCount = obj.Count();
            return fy;
        }
        #endregion

        #region 角色管理(role)
        /// <summary>
        /// role表查询
        /// </summary>
        /// <returns></returns>
        public static HouseFenYe roleChaXun(int pageIndex, int pageSize)// 
        {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = from p in ent.role
                      orderby p.RID where p.state == 0
                      select new
                      {
                          RID = p.RID,
                          RName = p.RName,
                          CreationDate = p.CreationDate,
                          remark = p.remark,
                          state = p.state
                      };
            var ms = obj.ToString();
            HouseFenYe fy = new HouseFenYe();
            fy.list = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            fy.PageCount = obj.Count();
            return fy;
        }
        /// <summary>
        /// role角色表新增
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int roleXinZeng(role r)
        {
            NewHope4Entities ent = new NewHope4Entities();
            r.CreationDate = DateTime.Now;
            r.state = 0;
            ent.role.Add(r);
            return ent.SaveChanges();
        }
        //根据员工名称查询
        public static HouseFenYe roleChaXunByName(string user2, int pageIndex, int pageSize)// 
        {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = from p in ent.role
                      orderby p.RID
                      select new
                      {
                          RID = p.RID,
                          RName = p.RName,
                          CreationDate = p.CreationDate,
                          remark = p.remark,
                          state = p.state
                      };
            try
            {
                int num = int.Parse(user2);
                obj = obj.Where(p => p.RID == num);
            }
            catch (Exception)
            {
                obj = obj.Where(p => p.RName.Contains(user2));
            }
            HouseFenYe fy = new HouseFenYe();
            fy.list = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            fy.PageCount = obj.Count();
            return fy;
        }
        //删除
        public static int roleShanChu(role r)
        {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = ent.role.Find(r.RID);
            obj.state = 1;
            ent.role.Remove(obj);
            return ent.SaveChanges();
        }
        //根据id查询，进行修改操作
        public static IQueryable roleById(int id)
        {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = from p in ent.role
                      where p.RID == id
                      select new
                      {
                          RID = p.RID,
                          RName = p.RName,
                          CreationDate = p.CreationDate,
                          remark = p.remark,
                          state = p.state
                      };
            return obj;
        }
        //修改
        public static int roleXiuGai(role r)
        {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = ent.role.Find(r.RID);
            obj.RName = r.RName;
            obj.remark = r.remark;
            return ent.SaveChanges();
        }
        #endregion

        #region 部门管理(department)
        // department表查询
        public static HouseFenYe departmentChaXun(int pageIndex, int pageSize)// 
        {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = from p in ent.department
                      orderby p.Did
                      where p.state == 0
                      select new
                      {
                          Did = p.Did,
                          DName = p.DName,
                          CreationDate = p.CreationDate,
                          state = p.state
                      };
            var ms = obj.ToString();
            HouseFenYe fy = new HouseFenYe();
            fy.list = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            fy.PageCount = obj.Count();
            return fy;
        }
        //根据员工名称查询
        public static HouseFenYe departmentChaXunByName(string user2, int pageIndex, int pageSize)// 
        {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = from p in ent.department
                      orderby p.Did
                      where p.state == 0
                      select new
                      {
                          Did = p.Did,
                          DName = p.DName,
                          CreationDate = p.CreationDate,
                          state = p.state
                      };
            try
            {
                int num = int.Parse(user2);
                obj = obj.Where(p => p.Did == num);
            }
            catch (Exception)
            {
                obj = obj.Where(p => p.DName.Contains(user2));
            }
            HouseFenYe fy = new HouseFenYe();
            fy.list = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            fy.PageCount = obj.Count();
            return fy;
        }
        // role角色表新增
        public static int departmentXinZeng(department d)
        {
            NewHope4Entities ent = new NewHope4Entities();
            d.CreationDate = DateTime.Now;
            d.state = 0;
            ent.department.Add(d);
            return ent.SaveChanges();
        }
        //删除
        public static int departmentShanChu(department d)
        {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = ent.department.Find(d.Did);
            obj.state = 1;
            return ent.SaveChanges();
        }
        //根据id查询，进行修改操作
        public static IQueryable departmentById(int id)
        {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = from p in ent.department
                      where p.Did == id
                      select new
                      {
                          Did = p.Did,
                          DName = p.DName,
                          CreationDate = p.CreationDate,
                          state = p.state
                      };
            return obj;
        }
        //修改
        public static int departmentXiuGai(department d)
        {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = ent.department.Find(d.Did);
            obj.DName = d.DName;
            return ent.SaveChanges();
        }
        #endregion

        #region 菜单管理(menu)
        // menu表查询
        public static HouseFenYe menuChaXun(int pageIndex, int pageSize)// 
        {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = from p in ent.menu
                      orderby p.MID
                      where p.state == 0
                      select new
                      {
                          MID = p.MID,
                          MNmae = p.MNmae,
                          PID = p.Parentmenu.UserTypeName,
                          TypeID = p.MenuType.MName,
                          style = p.style,
                          sort = p.sort,
                          path = p.path,
                          CreationDate = p.CreationDate,
                          state = p.state
                      };
            var ms = obj.ToString();
            HouseFenYe fy = new HouseFenYe();
            fy.list = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            fy.PageCount = obj.Count();
            return fy;
        }
        //根据菜单名称查询
        public static HouseFenYe menuChaXunByName(string user2, int pageIndex, int pageSize)// 
        {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = from p in ent.menu
                      orderby p.MID
                      select new
                      {
                          MID = p.MID,
                          MNmae = p.MNmae,
                          PID = p.Parentmenu.UserTypeName,
                          TypeID = p.MenuType.MName,
                          style = p.style,
                          sort = p.sort,
                          path = p.path,
                          CreationDate = p.CreationDate,
                          state = p.state
                      };
            try
            {
                int num = int.Parse(user2);
                obj = obj.Where(p => p.MID == num);
            }
            catch (Exception)
            {
                obj = obj.Where(p => p.MNmae.Contains(user2));
            }
            HouseFenYe fy = new HouseFenYe();
            fy.list = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            fy.PageCount = obj.Count();
            return fy;
        }
        //菜单栏查询
        public static IQueryable menuBarChaXun()// 
        {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = from p in ent.menu
                      where p.state == 0 && p.PID == 0
                      select new
                      {
                          MID = p.MID,
                          MNmae = p.MNmae,
                          PID = p.Parentmenu.UserTypeName,
                          PID2 = p.PID,
                          TypeID = p.MenuType.MName,
                          style = p.style,
                          sort = p.sort,
                          path = p.path,
                          CreationDate = p.CreationDate,
                          state = p.state,
                          obj2 = from pp in ent.menu
                                 orderby pp.PID
                                 where pp.state == 0 && pp.PID == p.MID
                                 select new
                                 {
                                     MID2 = pp.MID,
                                     MNmae2 = pp.MNmae,
                                     PID2 = pp.Parentmenu.UserTypeName,
                                     TypeID2 = pp.MenuType.MName,
                                     style2 = pp.style,
                                     sort2 = pp.sort,
                                     path2 = pp.path,
                                     CreationDate2 = pp.CreationDate,
                                     state2 = pp.state
                                 }
                      };
            return obj;
        }
        public static IQueryable menuBarChaXun2(int id)// 
        {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = from p in ent.menu
                      orderby p.PID
                      where p.state == 0 && p.PID == id
                      select new
                      {
                          MID = p.MID,
                          MNmae = p.MNmae,
                          PID = p.Parentmenu.UserTypeName,
                          TypeID = p.MenuType.MName,
                          style = p.style,
                          sort = p.sort,
                          path = p.path,
                          CreationDate = p.CreationDate,
                          state = p.state
                      };
            return obj;
        }
        // 父级菜单查询(Parentmenu)
        public static IQueryable ParentmenuName()
        {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = from p in ent.Parentmenu
                      select new
                      {
                          ID = p.ID,
                          UserTypeName = p.UserTypeName
                      };
            return obj;
        }
        // 菜单类型查询(MenuType)
        public static IQueryable MenuTypeName()
        {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = from p in ent.MenuType
                      select new
                      {
                          Id = p.Id,
                          MName = p.MName
                      };
            return obj;
        }
        // menu菜单表新增
        public static int menuXinZeng(menu m)
        {
            NewHope4Entities ent = new NewHope4Entities();
            m.CreationDate = DateTime.Now;
            m.state = 0;
            ent.menu.Add(m);
            return ent.SaveChanges();
        }
        // Parentmenu父级表新增
        public static int ParentmenuXinZeng(Parentmenu p)
        {
            NewHope4Entities ent = new NewHope4Entities();
            p.state = 0;
            ent.Parentmenu.Add(p);
            return ent.SaveChanges();
        }
        //删除
        public static int menuShanChu(menu m)
        {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = ent.menu.Find(m.MID);
            obj.state = 1;
            return ent.SaveChanges();
        }
        //根据id查询，进行修改操作
        public static IQueryable menuById(int id)
        {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = from p in ent.menu
                      where p.MID == id
                      select new
                      {
                          MID = p.MID,
                          MNmae = p.MNmae,
                          PID = p.PID,
                          TypeID = p.TypeID,
                          style = p.style,
                          sort = p.sort,
                          path = p.path,
                          CreationDate = p.CreationDate,
                          state = p.state
                      };
            return obj;
        }
        //修改
        public static int menuXiuGai(menu m)
        {
            NewHope4Entities ent = new NewHope4Entities();
            var obj = ent.menu.Find(m.MID);
            obj.MNmae = m.MNmae;
            obj.PID = m.PID;
            obj.TypeID = m.TypeID;
            obj.path = m.path;
            obj.sort = m.sort;
            obj.style = m.style;
            return ent.SaveChanges();
        }
        #endregion
    }
}
