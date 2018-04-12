using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System.ComponentModel;

namespace AppNavigationMVVM.ViewModels
{
    public class FirstPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public RelayCommand NavigateCommand { get; private set; }
        private string _username;
        private string _password;
        private string _error;

        public string Error
        {
            get { return _error; }
            set
            {

                _error = value;
                RaisePropertyChanged("Error");

            }

        }
        public string Username
        {
            get { return _username; }
            set
            {
                    _username = value;
                    RaisePropertyChanged("Username");
                
            }

        }
        public string Password
        {
            get { return _password; }
            set
            {
                    _password = value;
                    RaisePropertyChanged("Password");
                
            }
        }

    
        public FirstPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
          
            NavigateCommand = new RelayCommand(NavigateCommandAction);
        }
        private void NavigateCommandAction()
        {
            if (Username == "sachin" && Password == "123")
                _navigationService.NavigateTo("SecondPage");
            else
                Error = "Wrong username or password";
        }
    }
}
