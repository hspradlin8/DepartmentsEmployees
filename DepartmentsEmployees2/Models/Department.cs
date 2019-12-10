using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentsEmployees2.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }

        public string EmployeeName { get; internal set; }
    }
}
