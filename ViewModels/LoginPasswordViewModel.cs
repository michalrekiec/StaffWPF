using StaffWpf.Commands;
using StaffWpf.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace StaffWpf.ViewModels
{
    public class LoginPasswordViewModel : ViewModelBase
    {
        private const string _correctLogin = "admin";
        private const string _correctPassword = "a";

        public LoginPasswordViewModel()
        {
            CloseCommand = new RelayCommand(Close);
            ConfirmCommand = new RelayCommand(Confirm);
        }

        public ICommand CloseCommand { get; set; }
        public ICommand ConfirmCommand { get; set; }


        private string _login;
        public string Login
        {
            get { return _login; }
            set 
            { 
                _login = value;
                OnPropertyChanged();
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set 
            { 
                _password = value;
                OnPropertyChanged();
            }
        }


        private void Confirm(object obj)
        {
            if (Login == _correctLogin && Password == _correctPassword)
            {
                var mainWindow = new MainWindow();

                mainWindow.ShowDialog();
                CloseWindow(obj as Window);
            }
            else
            {
                MessageBox.Show("Brak dostępu!");
            }
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
