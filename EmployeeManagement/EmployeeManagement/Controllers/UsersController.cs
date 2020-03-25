using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeManagement.Business.Services;
using EmployeeManagement.Model.Models;

namespace EmployeeManagement.Controllers
{
    public class UsersController : Controller
    {
        //
        // GET: /Users/
        UsersDetails objUser = new UsersDetails();
        public ActionResult Index()
        {
            ViewBag.RoleId = Convert.ToString(TempData["UserAccess"]); 
            return View();
        }
        /// <summary>
        /// Open registration page
        /// </summary>
        /// <returns></returns>
        public ActionResult AddUsers() {
            ViewBag.Roles = objUser.GetRoles();
            return View();
        }
        /// <summary>
        /// Register users
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddUsers(UsersModels users)
        {
            objUser.AddUser(users);
            return RedirectToAction("AddUsers");
        }
        /// <summary>
        /// Update Status of users
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult UpdateUser(int userId,string status)
        {
            var data = objUser.UpdateUser(userId, status);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

    }
}
