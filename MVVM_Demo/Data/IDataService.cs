using MVVM_Demo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVVM_Demo.Data
{
    public interface IDataService
    {
        Task<List<ItemModel>> GetItemsAsync();
    }
}
