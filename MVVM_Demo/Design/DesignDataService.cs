using MVVM_Demo.Data;
using MVVM_Demo.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVVM_Demo.Design
{
    public class DesignDataService : IDataService
    {
        public Task<List<ItemModel>> GetItemsAsync()
        {
            return Task.Run(() =>
            {
                List<ItemModel> items = new List<ItemModel>();
                for (int i = 0; i < 10; i++)
                {
                    items.Add(new ItemModel("Item " + i, "Design description text", Math.Floor(i / 10d)));
                }

                return items;
            });
        }
    }
}
