using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryWebsite.Shared;
using FoodDeliveryWebsite.Shared.DTOs;

namespace FoodDeliveryWebsite.Server.Services.MenuItemService
{
    public interface IMenuItemService
    {
        Task<ServiceResponse<List<MenuItem>>> GetMenuItems();
        Task<ServiceResponse<MenuItem>> GetMenuItemById(int id);
        Task<ServiceResponse<List<MenuItem>>> GetMenuItemsByCategory(string categoryUrl);
        Task<ServiceResponse<MenuItemSearchResult>> SearchMenuItems(string searchText, int page);
        Task<ServiceResponse<List<string>>> GetMenuItemSearchSuggestions(string searchText);
        Task<ServiceResponse<List<MenuItem>>> GetFeaturedMenuItems();
    }
}
