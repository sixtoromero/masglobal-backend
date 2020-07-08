using System;
using System.Collections.Generic;
using System.Text;

namespace masglobal.ApplicationDTO
{
    public class EmployeesDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string contractTypeName { get; set; }
        public int roleId { get; set; }
        public string roleDescription { get; set; }
        public decimal hourlySalary { get; set; }
        public decimal monthlySalary { get; set; }

        /// <summary>
        /// Property to calculate annual salary
        /// </summary>
        public decimal annualSalary { get; set; }
    }
}
