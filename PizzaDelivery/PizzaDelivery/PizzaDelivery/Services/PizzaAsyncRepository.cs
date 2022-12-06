using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.Data.SQLite;
using Xamarin.Forms;
using PizzaDelivery.Models;

namespace PizzaDelivery.Services
{
    public class PizzaAsyncRepository
    {
        SQLiteAsyncConnection database;

        public PizzaAsyncRepository(string databasePath)
        {
            database = new SQLiteAsyncConnection(databasePath);
        }

        public async Task CreateTable()
        {
            await database.CreateTableAsync<Item>();
        }
        public async Task<List<Item>> GetItemsAsync()
        {
            return await database.Table<Item>().ToListAsync();

        }
        public async Task<Item> GetItemAsync(int id)
        {
            return await database.GetAsync<Item>(id);
        }
        public async Task<int> DeleteItemAsync(Item item)
        {
            return await database.DeleteAsync(item);
        }
        public async Task<int> SaveItemAsync(Item item)
        {
            if (item.Id != 0)
            {
                await database.UpdateAsync(item);
                return item.Id;
            }
            else
            {
                return await database.InsertAsync(item);
            }
        }
    }
}
