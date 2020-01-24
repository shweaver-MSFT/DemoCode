using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Demo.Models
{
    public class ItemModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double GroupId { get; set; }

        public ItemModel(string title, string description, double groupId)
        {
            Title = title;
            Description = description;
            GroupId = groupId;
        }
    }
}
