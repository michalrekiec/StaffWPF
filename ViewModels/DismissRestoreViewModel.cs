using StaffWpf.Commands;
using StaffWpf.Models;
using StaffWpf.Models.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace StaffWpf.ViewModels
{
    public class DismissRestoreViewModel : ViewModelBase
    {
        private Repository _repository = new Repository();

        public DismissRestoreViewModel(EmployeeWrapper employee = null)
        {
            CloseDRCommand = new RelayCommand(Close);
            ConfirmDRCommand = new RelayCommand(Confirm);

            if (employee.IsWorking == false)
            {
                EmployeeStatus = "przywrócić";
            }
            else
            {
                EmployeeStatus = "zwolnić";
            }

            Employee = employee;
            InformationTextBlock = $"Czy na pewno chcesz {EmployeeStatus} pracownika " +
                $"{Employee.FirstName} {Employee.LastName}?";

            
        }

        public ICommand CloseDRCommand { get; set; }
        public ICommand ConfirmDRCommand { get; set; }
        public string EmployeeStatus { get; set; }

        private string _informationTextBlock;
        public string InformationTextBlock
        {
            get { return _informationTextBlock; }
            set
            {
                _informationTextBlock = value;
                OnPropertyChanged();
            }
        }

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

        private DateTime _dismissalOrRestoreDate = DateTime.Now;

        public DateTime DismissalOrRestoreDate
        {
            get { return _dismissalOrRestoreDate; }
            set 
            { 
                _dismissalOrRestoreDate = value;
                OnPropertyChanged();
            }
        }


        private void UpdateEmployee()
        {
            if (Employee.IsWorking == true)
                _repository.DismissEmployee(Employee.Id, DismissalOrRestoreDate);
            else
                _repository.RestoreEmployee(Employee.Id);
        }

        //private void AddEmployee()
        //{
        //    // database
        //}

        private void Confirm(object obj)
        {
            if (Employee.IsWorking == true)
                Employee.DismissalDate = DismissalOrRestoreDate;
            else
                Employee.DismissalDate = null;

            UpdateEmployee();

            CloseWindow(obj as Window);
        }

        private void Close(object obj)
        {
            CloseWindow(obj as Window);
        }

        private void CloseWindow(Window window)
        {
            window.Close();
        }

    }
}
