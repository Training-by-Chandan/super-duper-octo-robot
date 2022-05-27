using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Viewmodel
{
    public class InventoryListViewModel : InventoryBaseViewModel
    {
        public string CategoryName { get; set; }
    }

    public class InventoryCreateEditViewModel : InventoryBaseViewModel
    {
        public int CategoryId { get; set; }
    }

    public class InventoryBaseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Stock { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public DateTime DateOfPurchase { get; set; }
    }
}