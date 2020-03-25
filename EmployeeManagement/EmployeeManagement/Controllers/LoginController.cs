using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeManagement.Business.Services;
using EmployeeManagement.Model.Models;

namespace EmployeeManagement.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        LoginUsers objLogin = new LoginUsers();
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Check user is exist or not
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(LoginModels login)
        {
            int result = objLogin.CheckLogin(login);
            if (result != 0)
            {
                TempData["UserAccess"] = result;
                return RedirectToAction("Index", "Users");
            }
            else
            {
                return View();
            }
        }

    }
}
