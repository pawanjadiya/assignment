using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeManagement.Business.Services;

namespace EmployeeManagement.Controllers
{
    public class ValuesController : ApiController
    {

        UsersDetails objUser = new UsersDetails();
        /// <summary>
        /// Get User List API
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage GetUserList()
        {
            var data = objUser.GetUserDeatils();
            return Request.CreateResponse(HttpStatusCode.OK, data, Configuration.Formatters.JsonFormatter);
        }
    }
}