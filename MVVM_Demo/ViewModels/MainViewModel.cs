using MVVM_Demo.Common;
using MVVM_Demo.Data;
using MVVM_Demo.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace MVVM_Demo.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private IDataService _dataService;

        private string _inputText;
        public string InputText
        {
            get => _inputText;
            set => Set(ref _inputText, value);
        }

        private ObservableCollection<ItemModel> _items;
        public ObservableCollection<ItemModel> Items
        {
            get => _items;
            set => Set(ref _items, value);
        }

        public CollectionViewSource GroupedItems { get; set; }

        public MainViewModel(IDataService dataService)
        {
            _dataService = dataService;

            _items = new ObservableCollection<ItemModel>();
            GroupedItems = new CollectionViewSource()
            {
                IsSourceGrouped = true
            };
            _inputText = "Hello World";
        }

        public override async Task LoadAsync(object parameter)
        {
            List<ItemModel> items = await _dataService.GetItemsAsync();
            GroupedItems.Source = items.ToGroup(item => item.GroupId);
        }
    }
}
