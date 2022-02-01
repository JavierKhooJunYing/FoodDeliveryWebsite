using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using FoodDeliveryWebsite.Shared;

namespace FoodDeliveryWebsite.Client.Services.MenuItemService
{
    public class MenuItemService : IMenuItemService
    {
        private readonly HttpClient _http;

        public MenuItemService(HttpClient http)
        {
            _http = http;
        }

        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
        public string Message { get; set; } = "Loading Menu Items...";

        public event Action MenuItemsChanged;

        public async Task<ServiceResponse<MenuItem>> GetMenuItemById(int id)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<MenuItem>>($"api/menuitem/{id}");
            return result;
        }

        public async Task GetMenuItems(string categoryUrl = null)
        {
            var result = categoryUrl == null ?
                await _http.GetFromJsonAsync<ServiceResponse<List<MenuItem>>>("api/MenuItem/featured") :
                await _http.GetFromJsonAsync<ServiceResponse<List<MenuItem>>>($"api/MenuItem/Category/{categoryUrl}");
            MenuItems = result.Data;
            MenuItemsChanged.Invoke();
        }

        public async Task<List<string>> GetMenuItemSearchSuggestions(string searchText)
        {
            var result = await _http
                .GetFromJsonAsync<ServiceResponse<List<string>>>($"api/menuitem/searchsuggestions/{searchText}");

            return result.Data;
        }

        public async Task SearchMenuItems(string searchText)
        {
            var result = await _http
                .GetFromJsonAsync<ServiceResponse<List<MenuItem>>>($"api/menuitem/search/{searchText}");
            MenuItems = result.Data;
            if (MenuItems.Count == 0)
            {
                Message = "No items found.";
            }
            MenuItemsChanged.Invoke();
        }
    }
}
