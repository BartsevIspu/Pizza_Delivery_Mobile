using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace PizzaDelivery.Models
{
    public class Item
    {
        public int Id { get; set; }     //apparently it shouldn't have been string type
        public string Text { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
    }
    
}