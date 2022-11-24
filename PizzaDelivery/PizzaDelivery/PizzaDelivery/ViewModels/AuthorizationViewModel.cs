using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace PizzaDelivery.ViewModels
{
    public class AuthorizationViewModel : BaseViewModel
    {
        public AuthorizationViewModel()
        {
            //NavigationPage.SetHasNavigationBar(, false);
            Title = "Авторизация";
        }

        public ICommand OpenWebCommand { get; }
    }
}