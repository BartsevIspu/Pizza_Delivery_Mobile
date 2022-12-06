using PizzaDelivery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaDelivery.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = /*Guid.NewGuid().ToString()*/ 1, Text = "9 Сыров", Cost = 100, 
                    Description="Сочетание мягких молодых сыров с соусом пармеджано и орегано", Quantity = 1 },
                new Item { Id = /*Guid.NewGuid().ToString()*/2, Text = "Чеддер", Cost = 100,
                    Description="Чеддер, хрустящий бекон, говядина, маринованные огурчики и томаты", Quantity = 1  },
                new Item { Id = /*Guid.NewGuid().ToString()*/3, Text = "Пепперони", Cost = 100,
                   Description="Американская классика с Моцареллой и фирменным томатным соусом",  Quantity = 1  },
                new Item { Id = /*Guid.NewGuid().ToString()*/4, Text = "Греческая", Cost = 100,
                   Description="Моцарелла, маслины, лук, сочные томаты и острый халапеньо", Quantity = 1  },
                new Item { Id = /*Guid.NewGuid().ToString()*/5, Text = "Гавайская", Cost = 100,
                   Description="Тропическая классика с кусочками ананаса", Quantity = 1  }
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(int id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}