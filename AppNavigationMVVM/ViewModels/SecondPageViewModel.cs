using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNavigationMVVM.ViewModels
{
   public class SecondPageViewModel :  ViewModelBase
    {
        private string _name;
        private int _phonenumber;
        private string _email;
        private string _dob;
        private string _address;
        private string _city;
        private int _zipcode;
        private bool _isMaleRadio;
        private bool _isFemaleRadio;
        private string _gender;
        private readonly INavigationService _navigationService;
        public RelayCommand NavigateCommand { get; private set; }
        private bool _isLoading = true;
        public bool IsLoading
        {
            get
            {
                return _isLoading;
            }
            set
            {
                _isLoading = value;
                RaisePropertyChanged("IsLoading");

            }
        }
        public bool IsMaleRadio
        {
            get { return _isMaleRadio; }
            set
            {
                _isMaleRadio = value;
                RaisePropertyChanged("IsMaleRadio");
            }
        }
        public bool IsFemaleRadio
        {
            get { return _isFemaleRadio; }
            set
            {
                _isFemaleRadio = value;
                RaisePropertyChanged("IsFemaleRadio");
            }
        }
        public string Gender
        {
            get { return _gender; }
            set
            {
                _gender = value;
                RaisePropertyChanged("Gender");
            }
        }
       
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged("Name");
            }
        }
        public int Phonenumber
        {
            get { return _phonenumber; }
            set
            {
                _phonenumber = value;
                RaisePropertyChanged("Phonenumber");
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                RaisePropertyChanged("Email");
            }
        }
        public string Dob
        {
            get { return _dob; }
            set
            {
                _dob = value;
                RaisePropertyChanged("Dob");
            }
        }
     
        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
                RaisePropertyChanged("Address");
            }
        }
        public string City
        {
            get { return _city; }
            set
            {
                _city = value;
                RaisePropertyChanged("City");
            }
        }
        public int Zipcode
        {
            get { return _zipcode; }
            set
            {
                _zipcode = value;
                RaisePropertyChanged("Zipcode");
            }
        }


        public SecondPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        
            NavigateCommand = new RelayCommand(NavigateCommandAction);
        }

        private void NavigateCommandAction()
        {
            if (IsMaleRadio == true)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }
            //Do Something
            _navigationService.NavigateTo("FirstPage");
            _navigationService.GoBack();
        }
    }
}
