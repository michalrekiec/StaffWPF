using MahApps.Metro.Controls;
using StaffWpf.Models;
using StaffWpf.Models.Wrappers;
using StaffWpf.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StaffWpf.Views
{
    /// <summary>
    /// Interaction logic for DismissView.xaml
    /// </summary>
    public partial class DismissRestoreView : MetroWindow
    {
        public DismissRestoreView(EmployeeWrapper employee = null)
        {
            InitializeComponent();
            DataContext = new DismissRestoreViewModel(employee);
        }
    }
}
