using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffWpf.Models.Domains
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DepartmentId { get; set; }
        public DateTime EmploymentDate { get; set; }
        public DateTime? DismissalDate { get; set; }
        public double Salary { get; set; }
        public bool IsWorking { get; set; }

        public Department Department { get; set; }
    }
}
