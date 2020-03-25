using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Data;

namespace EmployeeManagement.Business.Services
{
    public class DBInstance
    {
        private static EmployeeManagementEntities edmx = null;
        private static readonly object padlock = new object();

        private DBInstance() { }

        public static EmployeeManagementEntities Edmx
        {
            get
            {
                lock (padlock)
                {
                    if (edmx == null)
                    {
                        edmx = new EmployeeManagementEntities();
                    }
                    return edmx;
                }
            }
        }
    }
}
