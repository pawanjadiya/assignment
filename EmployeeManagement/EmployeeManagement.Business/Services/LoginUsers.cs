using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Model.Models;

namespace EmployeeManagement.Business.Services
{
    public class LoginUsers
    {
        /// <summary>
        /// Check user login
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public int CheckLogin(LoginModels login) {
            int result = 0;
            string password = login.Password;
            var checkUser = (from data in DBInstance.Edmx.UserDetails where data.FullName == login.UserName && data.Password == password select data).FirstOrDefault();
            if (checkUser != null)
            {
                result = checkUser.RoleId;
            }
            return result;
        }
    }
}
