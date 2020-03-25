using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Model.Models
{
    public class UsersModels
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "Title is required.")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Title is required.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Title is required.")]
        public string Address { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        [Required(ErrorMessage = "Title is required.")]
        public string Password { get; set; }
        public bool Status { get; set; }
    }
}
