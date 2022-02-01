using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryWebsite.Shared;

namespace FoodDeliveryWebsite.Server.Services.MenuItemService
{
    public interface IMenuItemService
    {
        Task<ServiceResponse<List<MenuItem>>> GetMenuItems();
        Task<ServiceResponse<MenuItem>> GetMenuItemById(int id);
        Task<ServiceResponse<List<MenuItem>>> GetMenuItemsByCategory(string categoryUrl);
        Task<ServiceResponse<List<MenuItem>>> SearchMenuItems(string searchText);
        Task<ServiceResponse<List<string>>> GetMenuItemSearchSuggestions(string searchText);
        Task<ServiceResponse<List<MenuItem>>> GetFeaturedMenuItems();
    }
}
