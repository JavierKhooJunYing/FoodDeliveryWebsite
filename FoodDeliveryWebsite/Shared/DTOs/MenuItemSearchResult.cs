using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryWebsite.Shared.DTOs
{
    public class MenuItemSearchResult
    {
        public List<MenuItem> MenuItems { get; set; }
        public int Pages { get; set; }
        public int CurrentPage { get; set; }
    }
}
