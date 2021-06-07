using StaffWpf.Models.Domains;
using StaffWpf.Models.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffWpf.Models.Converters
{
    public static class EmployeeConverter
    {
        public static EmployeeWrapper ToWrapper(this Employee model)
        {
            return new EmployeeWrapper
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                EmploymentDate = model.EmploymentDate,
                DismissalDate = model.DismissalDate,
                Salary = model.Salary,
                IsWorking = model.IsWorking,
                EmpDepartment = new DepartmentWrapper 
                { 
                    Id = model.Department.Id,
                    Name = model.Department.Name
                }
            };
        }

        public static Employee ToDao(this EmployeeWrapper model)
        {
            return new Employee
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                DepartmentId = model.EmpDepartment.Id,
                EmploymentDate = model.EmploymentDate,
                DismissalDate = model.DismissalDate,
                Salary = model.Salary,
                IsWorking = model.IsWorking
            };
        }
    }
}
