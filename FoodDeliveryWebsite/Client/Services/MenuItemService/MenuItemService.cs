﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using FoodDeliveryWebsite.Shared;
using FoodDeliveryWebsite.Shared.DTOs;

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
        public int CurrentPage { get; set; } = 1;
        public int PageCount { get; set; } = 0;
        public string LastSearchText { get; set; } = string.Empty;
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
            CurrentPage = 1;
            PageCount = 0;
            if (MenuItems.Count == 0)
            {
                Message = "No items found.";
            }
            MenuItemsChanged.Invoke();
        }

        public async Task<List<string>> GetMenuItemSearchSuggestions(string searchText)
        {
            var result = await _http
                .GetFromJsonAsync<ServiceResponse<List<string>>>($"api/menuitem/searchsuggestions/{searchText}");

            return result.Data;
        }

        public async Task SearchMenuItems(string searchText, int page)
        {
            LastSearchText = searchText;
            var result = await _http
                .GetFromJsonAsync<ServiceResponse<MenuItemSearchResult>>($"api/menuitem/search/{searchText}/{page}");
            MenuItems = result.Data.MenuItems;
            CurrentPage = result.Data.CurrentPage;
            PageCount = result.Data.Pages;
            if (MenuItems.Count == 0)
            {
                Message = "No items found.";
            }
            MenuItemsChanged.Invoke();
        }
    }
}
