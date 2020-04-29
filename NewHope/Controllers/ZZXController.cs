using BLL;
using System.Web.Mvc;
using MOD;
using System.Collections.Generic;
using System.Linq;

namespace NewHope.Controllers
{
    public class ZZXController : Controller
    {
        string name;
        public ActionResult Index()
        {
            return View();
        }
        // GET: ZZX
        public ActionResult QuanXianFenPei()
        {
            return View();
        }
        public ActionResult BiaoShiFuGuanLi() {

            return View();
        }

        //首页
        public ActionResult ShouYe()
        {
            name = Request.QueryString["name"];
            ViewBag.name = name;
            return View();
        }
        #region 登录
        //登录
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult LoginBynamepwd(string UserName, int UserPwd)
        {
            return Json(ZZXBLL.Login(UserName, UserPwd), JsonRequestBehavior.AllowGet);//
        }
        public ActionResult IndexByName(string userName)
        {
            return Json(ZZXBLL.IndexByName(userName), JsonRequestBehavior.AllowGet);//
        }
        #endregion

        #region 员工管理(admin)
        public ActionResult yuangong()
        {
            return View();
        }
        public ActionResult AdminChaXun(int pageindex, int pagesize)//
        {
            return Json(ZZXBLL.AdminChaXun(pageindex, pagesize), JsonRequestBehavior.AllowGet);//
        }
        public ActionResult AdminChaXunByIdName(string user2 = "", int pageIndex = 0, int pageSize = 0)//
        {

            return Json(ZZXBLL.AdminChaXunByName(user2, pageIndex, pageSize), JsonRequestBehavior.AllowGet);//
        }
        public ActionResult departmentName()
        {
            return Json(ZZXBLL.departmentName(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult roleName()
        {
            return Json(ZZXBLL.roleName(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult AdminById(int id)
        {
            return Json(ZZXBLL.AdminById(id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult AdminXiuGai(Admin a)
        {
            return Json(ZZXBLL.AdminXiuGai(a), JsonRequestBehavior.AllowGet);
        }
        public ActionResult AdminXinZeng(Admin a)
        {
            return Json(ZZXBLL.AdminXinZeng(a), JsonRequestBehavior.AllowGet);
        }
        public ActionResult AdminDel(int id)
        {
            return Json(ZZXBLL.AdminDel(id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult AdminHouseChaXun(int userId = 0, string name = "klsb", int BuMen = 0, int JueSe = 0, int pageIndex = 0, int pageSize = 0)
        {
            return Json(ZZXBLL.AdminHouseChaXun(userId, name, BuMen, JueSe, pageIndex, pageSize), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 角色管理(role)
        public ActionResult juese() {
            return View();
        }
        public ActionResult roleChaXun(int pageIndex, int pageSize)
        {
            return Json(ZZXBLL.roleChaXun(pageIndex, pageSize), JsonRequestBehavior.AllowGet);
        }
        //菜单栏查询
        public ActionResult menuBarChaXun()// 
        {
            return Json(ZZXBLL.menuBarChaXun(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult menuBarChaXun2(int id)// 
        {
            return Json(ZZXBLL.menuBarChaXun2(id), JsonRequestBehavior.AllowGet);
        }
        //根据角色编号或角色名称查询
        public ActionResult roleChaXunByName(string user2, int pageIndex, int pageSize)// 
        {
            return Json(ZZXBLL.roleChaXunByName(user2, pageIndex, pageSize), JsonRequestBehavior.AllowGet);
        }
        public ActionResult roleXinZeng(role r)
        {
            return Json(ZZXBLL.roleXinZeng(r), JsonRequestBehavior.AllowGet);
        }
        public ActionResult roleShanChu(role r)
        {
            return Json(ZZXBLL.roleShanChu(r), JsonRequestBehavior.AllowGet);
        }
        //根据id查询，进行修改操作
        public ActionResult roleById(int id)
        {
            return Json(ZZXBLL.roleById(id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult roleXiuGai(role r)
        {
            return Json(ZZXBLL.roleXiuGai(r), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 部门管理(department)
        public ActionResult bumen()
        {
            return View();
        }
        public ActionResult departmentChaXun(int pageIndex, int pageSize)
        {
            return Json(ZZXBLL.departmentChaXun(pageIndex, pageSize), JsonRequestBehavior.AllowGet);
        }
        //根据员工名称查询
        public ActionResult departmentChaXunByName(string user2, int pageIndex, int pageSize)// 
        {
            return Json(ZZXBLL.departmentChaXunByName(user2, pageIndex, pageSize), JsonRequestBehavior.AllowGet);
        }
        public ActionResult departmentXinZeng(department d)
        {
            return Json(ZZXBLL.departmentXinZeng(d), JsonRequestBehavior.AllowGet);
        }
        public ActionResult departmentShanChu(department d)
        {
            return Json(ZZXBLL.departmentShanChu(d), JsonRequestBehavior.AllowGet);
        }
        //根据id查询，进行修改操作
        public ActionResult departmentById(int id)
        {
            return Json(ZZXBLL.departmentById(id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult departmentXiuGai(department d)
        {
            return Json(ZZXBLL.departmentXiuGai(d), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 部门管理(department)
        public ActionResult caidanuanli()
        {
            return View();
        }
        public ActionResult menuChaXun(int pageIndex, int pageSize)
        {
            return Json(ZZXBLL.menuChaXun(pageIndex, pageSize), JsonRequestBehavior.AllowGet);
        }
        public ActionResult ParentmenuName()
        {
            return Json(ZZXBLL.ParentmenuName(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult MenuTypeName()
        {
            return Json(ZZXBLL.MenuTypeName(), JsonRequestBehavior.AllowGet);
        }
        //根据员工名称查询
        public ActionResult menuChaXunByName(string user2, int pageIndex, int pageSize)// 
        {
            return Json(ZZXBLL.menuChaXunByName(user2, pageIndex, pageSize), JsonRequestBehavior.AllowGet);
        }
        public ActionResult menuXinZeng(menu m)
        {
            return Json(ZZXBLL.menuXinZeng(m), JsonRequestBehavior.AllowGet);
        }
        public ActionResult ParentmenuXinZeng(Parentmenu p)
        {
            return Json(ZZXBLL.ParentmenuXinZeng(p), JsonRequestBehavior.AllowGet);
        }
        public ActionResult menuShanChu(menu m)
        {
            return Json(ZZXBLL.menuShanChu(m), JsonRequestBehavior.AllowGet);
        }
        //根据id查询，进行修改操作
        public ActionResult menuById(int id)
        {
            return Json(ZZXBLL.menuById(id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult menuXiuGai(menu m)
        {
            return Json(ZZXBLL.menuXiuGai(m), JsonRequestBehavior.AllowGet);
        }
        #endregion
    }
}