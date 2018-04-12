using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using CommonServiceLocator;
using AppNavigationMVVM.Views;

namespace AppNavigationMVVM.ViewModels
{
    class ViewModelLocator
    {
        
        public const string FirstPageKey = "FirstPage";
        public const string SecondPageKey = "SecondPage";
        public const string DetailsPageKey = "DetailsPage";
        public ViewModelLocator()
        {
           
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            var nav = new NavigationService();
            nav.Configure(FirstPageKey, typeof(FirstPage));
            nav.Configure(SecondPageKey, typeof(SecondPage));
            nav.Configure(DetailsPageKey, typeof(DisplayDetails));
            if (ViewModelBase.IsInDesignModeStatic)
            {

            }
            else
            {

            }
            //Register your services used here
            SimpleIoc.Default.Register<INavigationService>(() => nav);
            SimpleIoc.Default.Register<FirstPageViewModel>();
            SimpleIoc.Default.Register<SecondPageViewModel>();
            SimpleIoc.Default.Register<DetailsPageViewModel>();

        }
        public FirstPageViewModel FirstPageInstance
        {
            get
            {
                return ServiceLocator.Current.GetInstance<FirstPageViewModel>();
            }
        }

        // <summary>
        // Gets the SecondPage view model.
        // </summary>
        // <value>
        // The SecondPage view model.
        // </value>
        public SecondPageViewModel SecondPageInstance
        {
            get
            {
                return ServiceLocator.Current.GetInstance<SecondPageViewModel>();
            }
        }
        public DetailsPageViewModel DetailsPageInstance
        {
            get
            {
                return ServiceLocator.Current.GetInstance<DetailsPageViewModel>();
            }
        }
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}
