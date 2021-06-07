using StaffWpf.Commands;
using StaffWpf.Models;
using StaffWpf.Models.Domains;
using StaffWpf.Models.Wrappers;
using StaffWpf.Views;
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
    public class MainViewModel : ViewModelBase
    {
        private Repository _repository = new Repository();

        public MainViewModel()
        {            
            using (var context = new ApplicationDbContext())
            {
                var employees = context.Employees.ToList();
            }

            AddEmployeeCommand = new RelayCommand(AddEditEmployee);
            EditEmployeeCommand = new RelayCommand(AddEditEmployee, CanEditDismissRestore);
            DismissRestoreEmployeeCommand = new RelayCommand(DismissRestoreEmployee, CanEditDismissRestore);
            RefreshStaffCommand = new RelayCommand(RefreshStaff);
            FilterDataCommand = new RelayCommand(FilterData);
            DeleteFilterCommand = new RelayCommand(DeleteFilter);


            SetMinMaxSalary();
            RefreshList();
            InitDepartments();
        }

        public ICommand AddEmployeeCommand { get; set; }
        public ICommand EditEmployeeCommand { get; set; }
        public ICommand DismissRestoreEmployeeCommand { get; set; }
        public ICommand RefreshStaffCommand { get; set; }
        public ICommand FilterDataCommand { get; set; }
        public ICommand DeleteFilterCommand { get; set; }


        private EmployeeWrapper _selectedEmployee;
        public EmployeeWrapper SelectedEmployee
        {
            get { return _selectedEmployee; }
            set 
            { 
                _selectedEmployee = value;
                OnPropertyChanged();
            }
        }

        private DateTime _dateToSet = DateTime.Now;
        public DateTime DateToSet
        {
            get { return _dateToSet; }
            set
            {
                _dateToSet = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<EmployeeWrapper> _employees;
        public ObservableCollection<EmployeeWrapper> Employees
        {
            get { return _employees; }
            set
            {
                _employees = value;
                OnPropertyChanged();
            }
        }

        private bool _accountancy = true;
        public bool Accountancy
        {
            get { return _accountancy; }
            set
            {
                _accountancy = value;
                OnPropertyChanged();
            }
        }

        private bool _it = true;
        public bool It
        {
            get { return _it; }
            set
            {
                _it = value;
                OnPropertyChanged();
            }
        }

        private bool _management = true;
        public bool Management
        {
            get { return _management; }
            set
            {
                _management = value;
                OnPropertyChanged();
            }
        }

        private bool _marketing = true;
        public bool Marketing
        {
            get { return _marketing; }
            set
            {
                _marketing = value;
                OnPropertyChanged();
            }
        }

        private bool _allEmployees = true;
        public bool AllEmployees
        {
            get { return _allEmployees; }
            set
            {
                _allEmployees = value;
                OnPropertyChanged();
            }
        }

        private bool _currentlyWorking;
        public bool CurrentlyWorking
        {
            get { return _currentlyWorking; }
            set
            {
                _currentlyWorking = value;
                OnPropertyChanged();
            }
        }

        private bool _workingInThePast;
        public bool WorkingInThePast
        {
            get { return _workingInThePast; }
            set
            {
                _workingInThePast = value;
                OnPropertyChanged();
            }
        }

        private double _minimumValue;
        public double MinimumValue
        {
            get { return _minimumValue; }
            set 
            { 
                _minimumValue = value;
                OnPropertyChanged();
            }
        }

        private double _maximumValue;
        public double MaximumValue
        {
            get { return _maximumValue; }
            set
            {
                _maximumValue = value;
                OnPropertyChanged();
            }
        }

        private void SetMinMaxSalary()
        {
            MinimumValue = GetMinValue();
            MaximumValue = GetMaxValue();
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

        private void AddEditEmployee(object obj)
        {
            var addEditEmployeeWindow = new AddEditEmployeeView(obj as EmployeeWrapper);
            addEditEmployeeWindow.Closed += AddEditEmployeeWindow_Closed;
            addEditEmployeeWindow.ShowDialog();
        }

        private void AddEditEmployeeWindow_Closed(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void DismissRestoreEmployee(object obj)
        {
            var dismissRestoreWindow = new DismissRestoreView(obj as EmployeeWrapper);
            dismissRestoreWindow.Closed += DismissRestoreWindow_Closed;
            dismissRestoreWindow.ShowDialog();
        }

        private void DismissRestoreWindow_Closed(object sender, EventArgs e)
        {
            RefreshList();
        }

        private bool CanEditDismissRestore(object obj)
        {
            return SelectedEmployee != null;
        }

        private void RefreshStaff(object obj)
        {
            RefreshList();
        }

        private void FilterData(object obj)
        {
            Employees = 
                new ObservableCollection<EmployeeWrapper>
                (_repository.FilterEmployees(Accountancy, It, Management, Marketing, 
                        MinimumValue, MaximumValue,
                        CurrentlyWorking, WorkingInThePast));
        }

        private void DeleteFilter(object obj)
        {
            Accountancy = true;
            It = true;
            Marketing = true;
            Management = true;
            AllEmployees = true;

            MinimumValue = GetMinValue();
            MaximumValue = GetMaxValue();

            RefreshList();
        }

        private double GetMinValue()
        {
            if (_repository.GetEmployees().Count != 0)
                return _repository.GetMinimum();
            else return 0;
        }

        private double GetMaxValue()
        {
            if (_repository.GetEmployees().Count != 0)
                return _repository.GetMaximum();
            else return 0;
        }

        private void RefreshList()
        {
            Employees = new ObservableCollection<EmployeeWrapper>(_repository.GetEmployees());
        }

        private void InitDepartments()
        {
            var departments = _repository.GetDepartments();

            departments.Insert(0, new Department { Id = 0, Name = "Wszystkie" });

            Departments = new ObservableCollection<Department>(departments);
        }
    }
}
