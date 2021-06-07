using StaffWpf.Models.Domains;
using StaffWpf.Models.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using StaffWpf.Models.Converters;

namespace StaffWpf
{
    public class Repository
    {
        public List<Department> GetDepartments()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Departments.ToList();
            }
        }

        public List<EmployeeWrapper> GetEmployees()
        {
            using (var context = new ApplicationDbContext())
            {
                var employees = context
                    .Employees
                    .Include(x => x.Department)
                    .AsQueryable();

                //if (departmentId != 0)
                //    employees = employees.Where(x => x.DepartmentId == departmentId);


                return employees.ToList().Select(x => x.ToWrapper()).ToList();
            }
        }


        public List<EmployeeWrapper> FilterEmployees
            (bool accountancy, bool it, bool management, bool marketing, double minValue, double maxValue,
            bool currentlyWorking, bool workingInThePast)
        {
            using (var context = new ApplicationDbContext())
            {
                var filterEmployees = context
                    .Employees
                    .Include(x => x.Department)
                    .AsQueryable();

                if (accountancy == false)
                    filterEmployees = filterEmployees.Where(x => x.DepartmentId != 1);

                if (it == false)
                    filterEmployees = filterEmployees.Where(x => x.DepartmentId != 2);

                if (management == false)
                    filterEmployees = filterEmployees.Where(x => x.DepartmentId != 3);

                if (marketing == false)
                    filterEmployees = filterEmployees.Where(x => x.DepartmentId != 4);

                filterEmployees = filterEmployees.Where(x => x.Salary >= minValue);
                filterEmployees = filterEmployees.Where(x => x.Salary <= maxValue);

                if (currentlyWorking == true)
                    filterEmployees = filterEmployees.Where(x => x.IsWorking == true);
                else if (workingInThePast == true)
                    filterEmployees = filterEmployees.Where(x => x.IsWorking == false);

                return filterEmployees.ToList().Select(x => x.ToWrapper()).ToList();
            }
        }

        public void DismissEmployee(int id, DateTime dismissalDate)
        {
            using (var context = new ApplicationDbContext())
            {
                var employeeToDismiss = context.Employees.Find(id);
                employeeToDismiss.IsWorking = false;
                employeeToDismiss.DismissalDate = dismissalDate;
                context.SaveChanges();
            }
        }

        public void RestoreEmployee(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                var employeeToRestore = context.Employees.Find(id);
                employeeToRestore.IsWorking = true;
                employeeToRestore.DismissalDate = null;
                context.SaveChanges();
            }
        }

        public void UpdateEmployee(EmployeeWrapper employeeWrapper)
        {
            var employee = employeeWrapper.ToDao();

            using (var context = new ApplicationDbContext())
            {
                UpdateEmployeeProperties(context, employee);

                context.SaveChanges();
            }
        }

        public void AddEmployee(EmployeeWrapper employeeWrapper)
        {
            var employee = employeeWrapper.ToDao();

            using (var context = new ApplicationDbContext())
            {
                var dbEmployee = context.Employees.Add(employee);

                context.SaveChanges();
            }
        }

        public static void UpdateEmployeeProperties(ApplicationDbContext context, Employee employee)
        {
            var employeeToUpdate = context.Employees.Find(employee.Id);

            employeeToUpdate.FirstName = employee.FirstName;
            employeeToUpdate.LastName = employee.LastName;
            employeeToUpdate.EmploymentDate = employee.EmploymentDate;
            employeeToUpdate.DismissalDate = employee.DismissalDate;
            employeeToUpdate.IsWorking = employee.IsWorking;
            employeeToUpdate.Salary = employee.Salary;
            employeeToUpdate.DepartmentId = employee.DepartmentId;
        }

        public double GetMinimum()
        {
            var listOfSalaries = new List<double>();

            using (var context = new ApplicationDbContext())
            {
                foreach(var employee in context.Employees)
                {
                    listOfSalaries.Add(employee.Salary);
                }
            }

            var lowestSalary = listOfSalaries.Min();

            return lowestSalary;
        }

        public double GetMaximum()
        {
            var listOfSalaries = new List<double>();

            using (var context = new ApplicationDbContext())
            {
                foreach (var employee in context.Employees)
                {
                    listOfSalaries.Add(employee.Salary);
                }
            }

            var highestSalary = listOfSalaries.Max();

            return highestSalary;
        }
    }
}
