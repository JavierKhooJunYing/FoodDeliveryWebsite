using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryWebsite.Server.Data;
using FoodDeliveryWebsite.Server.Services.MenuItemService;
using FoodDeliveryWebsite.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryWebsite.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        private readonly IMenuItemService _menuItemService;

        public MenuItemController(IMenuItemService menuItemService)
        {
            _menuItemService = menuItemService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<MenuItem>>>> GetMenuItems()
        {
            var response = await _menuItemService.GetMenuItems();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<MenuItem>>> GetMenuItemById(int id)
        {
            var response = await _menuItemService.GetMenuItemById(id);
            return Ok(response);
        }

        [HttpGet("category/{categoryUrl}")]
        public async Task<ActionResult<ServiceResponse<List<MenuItem>>>> GetMenuItemsByCategory(string categoryUrl)
        {
            var response = await _menuItemService.GetMenuItemsByCategory(categoryUrl);
            return Ok(response);
        } 

        [HttpGet("search/{searchText}")]
        public async Task<ActionResult<ServiceResponse<List<MenuItem>>>> SearchMenuItems(string searchText)
        {
            var response = await _menuItemService.SearchMenuItems(searchText);
            return Ok(response);
        }

        [HttpGet("SearchSuggestions/{searchText}")]
        public async Task<ActionResult<ServiceResponse<List<string>>>> GetMenuItemSearchSuggestions(string searchText)
        {
            var response = await _menuItemService.GetMenuItemSearchSuggestions(searchText);
            return Ok(response);
        }

        [HttpGet("featured")]
        public async Task<ActionResult<ServiceResponse<List<MenuItem>>>> GetFeaturedMenuItems()
        {
            var response = await _menuItemService.GetFeaturedMenuItems();
            return Ok(response);
        }
    }
}
