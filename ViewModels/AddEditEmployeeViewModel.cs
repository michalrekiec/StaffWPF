using StaffWpf.Commands;
using StaffWpf.Models;
using StaffWpf.Models.Domains;
using StaffWpf.Models.Wrappers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace StaffWpf.ViewModels
{
    public class AddEditEmployeeViewModel : ViewModelBase
    {
        private Repository _repository = new Repository();

        public AddEditEmployeeViewModel(EmployeeWrapper employee = null)
        {
            CloseCommand = new RelayCommand(Close);
            ConfirmCommand = new RelayCommand(Confirm);


            if (employee == null)
            {
                Employee = new EmployeeWrapper();
                Employee.EmploymentDate = DateTime.Now;                
            }
            else
            {
                Employee = employee;
                IsUpdate = true;

                if (employee.IsWorking == false)
                    CanDismissalDateEdit = true;
                else
                    CanDismissalDateEdit = false;
            }

            InitDepartments();
        }

        public ICommand CloseCommand { get; set; }
        public ICommand ConfirmCommand { get; set; }

        private EmployeeWrapper _employee;
        public EmployeeWrapper Employee
        {
            get { return _employee; }
            set
            {
                _employee = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Department> _departments;
        public ObservableCollection<Department> Departments
        {
            get { return _departments; }
            set
            {
                _departments = value;
                OnPropertyChanged();
            }
        }

        private bool _isUpdate;
        public bool IsUpdate
        {
            get { return _isUpdate; }
            set
            {
                _isUpdate = value;
                OnPropertyChanged();
            }
        }

        private bool _canDismissalDateEdit;
        public bool CanDismissalDateEdit
        {
            get { return _canDismissalDateEdit; }
            set
            {
                _canDismissalDateEdit = value;
                OnPropertyChanged();
            }
        }

        private void Confirm(object obj)
        {
            if (!IsUpdate)
            {
                AddEmployee();
            }
            else
            {
                UpdateEmployee();
            }            

            CloseWindow(obj as Window);
        }

        private void UpdateEmployee()
        {
            _repository.UpdateEmployee(Employee);
        }

        private void AddEmployee()
        {
            _repository.AddEmployee(Employee);
        }

        private void Close(object obj)
        {
            CloseWindow(obj as Window);
        }

        private void CloseWindow(Window window)
        {
            window.Close();
        }

        private void InitDepartments()
        {
            var departments = _repository.GetDepartments();
            departments.Insert(0, new Models.Domains.Department { Id = 0, Name = "-- brak --" });

            Departments = new ObservableCollection<Department>(departments);

            //Employee.EmpDepartment.Id = 0;
            
        }
    }
}
