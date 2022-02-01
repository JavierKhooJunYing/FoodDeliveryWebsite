using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryWebsite.Server.Data;
using FoodDeliveryWebsite.Shared;
using FoodDeliveryWebsite.Shared.DTOs;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryWebsite.Server.Services.MenuItemService
{
    public class MenuItemService : IMenuItemService
    {
        private readonly ApplicationDbContext _context;

        public MenuItemService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<MenuItem>>> GetFeaturedMenuItems()
        {
            var response = new ServiceResponse<List<MenuItem>>
            {
                Data = await _context.MenuItems
                        .Where(p => p.Featured)
                        .ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<MenuItem>> GetMenuItemById(int id)
        {
            var response = new ServiceResponse<MenuItem>();
            var menuItem = await _context.MenuItems.FindAsync(id);

            if (menuItem == null)
            {
                response.Success = false;
                response.Message = "Sorry, but this item does not exists.";
            }
            else
            {
                response.Data = menuItem;
            }

            return response;
        }

        public async Task<ServiceResponse<List<MenuItem>>> GetMenuItems()
        {
            var menuItems = await _context.MenuItems.ToListAsync();
            var response = new ServiceResponse<List<MenuItem>>
            {
                Data = menuItems
            };

            return response;
        }

        public async Task<ServiceResponse<List<MenuItem>>> GetMenuItemsByCategory(string categoryUrl)
        {
            var response = new ServiceResponse<List<MenuItem>>
            {
                Data = await _context.MenuItems
                        .Where(p => p.Category.Url.ToLower().Equals(categoryUrl.ToLower()))
                        .ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<List<string>>> GetMenuItemSearchSuggestions(string searchText)
        {
            var menuItems = await FindMenuItemsBySearchText(searchText);

            List<string> result = new List<string>();

            foreach (var menuItem in menuItems)
            {
                if (menuItem.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(menuItem.Name);
                }

                if (menuItem.Description != null)
                {
                    var punctuation = menuItem.Description.Where(char.IsPunctuation).Distinct().ToArray();
                    var words = menuItem.Description.Split().Select(w => w.Trim(punctuation));
                    foreach (var word in words)
                    {
                        if (word.Contains(searchText, StringComparison.OrdinalIgnoreCase) && !result.Contains(word))
                        {
                            result.Add(word);
                        }
                    }
                }
            }

            return new ServiceResponse<List<string>> { Data = result };
        }

        public async Task<ServiceResponse<MenuItemSearchResult>> SearchMenuItems(string searchText, int page)
        {
            var pageResults = 3f;
            var pageCount = Math.Ceiling((await FindMenuItemsBySearchText(searchText)).Count / pageResults);

            var menuItems = await _context.MenuItems
                                .Where(p => p.Name.ToLower().Contains(searchText.ToLower())
                                || p.Description.ToLower().Contains(searchText.ToLower()))
                                .Skip((page - 1) * (int)pageResults)
                                .Take((int)pageResults)
                                .ToListAsync();

            var response = new ServiceResponse<MenuItemSearchResult>
            {
                Data = new MenuItemSearchResult
                {
                    MenuItems = menuItems,
                    CurrentPage = page,
                    Pages = (int)pageCount
                }
            };

            return response;
        }

        private async Task<List<MenuItem>> FindMenuItemsBySearchText(string searchText)
        {
            return await _context.MenuItems
                            .Where(p => p.Name.ToLower().Contains(searchText.ToLower())
                            || p.Description.ToLower().Contains(searchText.ToLower()))
                            .ToListAsync();
        }
    }
}
