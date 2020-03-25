using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Data;
using EmployeeManagement.Model.Models;

namespace EmployeeManagement.Business.Services
{
    public class UsersDetails
    {
        public UsersDetails() { }
        /// <summary>
        /// Get user list function
        /// </summary>
        /// <returns></returns>
        public List<UsersModels> GetUserDeatils()
        {
            //DBInstance is object of entity. I have created that with the use of singleton class
            return DBInstance.Edmx.UserDetails.Select(x => new UsersModels()
            {
                UserId = x.UserId,
                FullName = x.FullName,
                Phone = x.Phone,
                Address = x.Address,
                Status = x.Status ?? false,
                RoleName = (from role in DBInstance.Edmx.RoleDetails where role.RoleId == x.RoleId select role.RoleName).FirstOrDefault()
            }).ToList();

        }
        /// <summary>
        /// Update user status function
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public List<UsersModels> UpdateUser(int userId, string status)
        {
            int result = 0;
            var data = (from user in DBInstance.Edmx.UserDetails where user.UserId == userId select user).FirstOrDefault();
            if (data != null)
            {
                data.Status = Convert.ToBoolean(status);
                data.UpdatedDate = DateTime.Now;
                result = DBInstance.Edmx.SaveChanges();
            }
            return GetUserDeatils();
        }
        /// <summary>
        /// Add user's
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public List<UsersModels> AddUser(UsersModels user)
        {
            UserDetail objUser = new UserDetail();
            objUser.FullName = user.FullName;
            objUser.Address = user.Address;
            objUser.RoleId = user.RoleId;
            objUser.Status = true;
            objUser.Phone = user.Phone;
            objUser.Password = user.Password;
            objUser.CreatedDate = DateTime.Now;
            DBInstance.Edmx.UserDetails.Add(objUser);
            DBInstance.Edmx.SaveChanges();
            return GetUserDeatils();
        }
        /// <summary>
        /// Bind the drop down list with role's
        /// </summary>
        /// <returns></returns>
        public List<RolesModel> GetRoles()
        {
            return (from user in DBInstance.Edmx.RoleDetails select new RolesModel() { RoleId = user.RoleId, RoleName = user.RoleName }).ToList();
        }
    }
}
