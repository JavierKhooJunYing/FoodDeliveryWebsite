using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryWebsite.Shared;

namespace FoodDeliveryWebsite.Client.Services.MenuItemService
{
    public interface IMenuItemService
    {
        event Action MenuItemsChanged;
        List<MenuItem> MenuItems { get; set; }
        string Message { get; set; }
        Task GetMenuItems(string categoryUrl = null);
        Task<ServiceResponse<MenuItem>> GetMenuItemById(int id);
        Task SearchMenuItems(string searchText);
        Task<List<string>> GetMenuItemSearchSuggestions(string searchText);
    }
}
