using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Demo
{
    public class Item
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double GroupId { get; set; }

        public Item(string title, string description, double groupId)
        {
            Title = title;
            Description = description;
            GroupId = groupId;
        }
    }

    public class MainViewModel : INotifyPropertyChanged
    {
        private string _inputText;
        public string InputText
        {
            get => _inputText;
            set => Set(ref _inputText, value);
        }

        private ObservableCollection<Item> _items;
        public ObservableCollection<Item> Items
        {
            get => _items;
            set => Set(ref _items, value);
        }

        public MainViewModel()
        {
            _items = new ObservableCollection<Item>();
            _inputText = "Hello World";
        }

        public void Load()
        {
            for(int i = 0; i < 1000; i++)
            {
                Items.Add(new Item("Item " + i, "Lorem ipsum balh blah", Math.Floor(i / 10d)));
            }
        }

        // Boilerplate code to support the change in properties reflecting in the XAML DOM
        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
