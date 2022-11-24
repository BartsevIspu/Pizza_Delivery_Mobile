using PizzaDelivery.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PizzaDelivery.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}