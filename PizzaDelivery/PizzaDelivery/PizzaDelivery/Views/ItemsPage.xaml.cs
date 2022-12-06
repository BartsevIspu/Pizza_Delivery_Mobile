using PizzaDelivery.Models;
using PizzaDelivery.ViewModels;
using PizzaDelivery.Views;
using PizzaDelivery.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PizzaDelivery.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override async void OnAppearing()
        {
            await App.Database.CreateTable();
            //List<Item> pizzalist = new List<Item>();
            //pizzalist.ItemsSource = App.Database.GetItemsAsync();
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}