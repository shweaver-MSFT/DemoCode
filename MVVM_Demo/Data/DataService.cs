using MVVM_Demo.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVVM_Demo.Data
{
    public class DataService : IDataService
    {
        public Task<List<ItemModel>> GetItemsAsync()
        {
            return Task.Run(() =>
            {
                List<ItemModel> items = new List<ItemModel>();
                for (int i = 0; i < 1000; i++)
                {
                    items.Add(new ItemModel("Item " + i, "Description text", Math.Floor(i / 10d)));
                }

                return items;
            });
        }
    }
}
