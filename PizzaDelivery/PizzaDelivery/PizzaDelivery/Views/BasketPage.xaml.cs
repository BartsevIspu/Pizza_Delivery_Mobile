using PizzaDelivery.Models;
using PizzaDelivery.ViewModels;
using PizzaDelivery.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace PizzaDelivery.Views
{
    public partial class BasketPage : ContentPage
    {
        BasketViewModel _viewModel;
        public ObservableCollection<Item> Items { get; }
        public BasketPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new BasketViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
        //protected async Task OnDeleteItem(object sender, EventArgs args)
        //{
        //    var curItem = ((Xamarin.Forms.ImageButton)sender);
        //    Item listitem = (from itm in Items
        //                     where itm.Text == curItem.CommandParameter.ToString()
        //                     select itm)
        //                     .FirstOrDefault<Item>();
        //    Items.Remove(listitem);
        //}
        protected void OnClickedMinus(object sender, EventArgs args)
        {
            
        }
        protected void OnClickedPlus(object sender, EventArgs args)
        {

        }
    }
}