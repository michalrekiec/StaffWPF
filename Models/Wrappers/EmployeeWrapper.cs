using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffWpf.Models.Wrappers
{
    public class EmployeeWrapper
    {
        public EmployeeWrapper()
        {
            EmpDepartment = new DepartmentWrapper();

            IsWorking = true;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DepartmentWrapper EmpDepartment { get; set; }
        public DateTime EmploymentDate { get; set; }
        public DateTime? DismissalDate { get; set; }
        public double Salary { get; set; }
        public bool IsWorking { get; set; }


    }
}
