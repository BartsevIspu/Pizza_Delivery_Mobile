using PizzaDelivery.ViewModels;
using PizzaDelivery.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PizzaDelivery
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
        }

    }
}
