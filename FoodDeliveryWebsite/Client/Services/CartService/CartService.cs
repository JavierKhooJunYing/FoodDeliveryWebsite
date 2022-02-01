using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using Blazored.Toast.Services;
using FoodDeliveryWebsite.Client.Services.MenuItemService;
using FoodDeliveryWebsite.Shared;
using FoodDeliveryWebsite.Shared.DTOs;

namespace FoodDeliveryWebsite.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;
        private readonly IToastService _toastService;
        private readonly IMenuItemService _menuItemService;

        public CartService(ILocalStorageService localStorage,
                           IToastService toastService,
                           IMenuItemService menuItemService)                  
        {
            _localStorage = localStorage;
            _toastService = toastService;
            _menuItemService = menuItemService;
        }

        public event Action OnChange;

        public async Task AddToCart(CartItem item)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                cart = new List<CartItem>();
            }

            var sameItem = cart.Find(x => x.MenuItemId == item.MenuItemId);
            
            if (sameItem == null)
            {
                cart.Add(item);
            }
            else
            {
                sameItem.Quantity += item.Quantity;
            }
            
            await _localStorage.SetItemAsync("cart", cart);
            _toastService.ShowSuccess(item.MenuItemName, "ADDED TO CART:");

            OnChange.Invoke();
        }

        public async Task DeleteCartItem(CartItem item)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                return;
            }

            var cartItem = cart.Find(x => x.MenuItemId == item.MenuItemId);
            cart.Remove(cartItem);

            await _localStorage.SetItemAsync("cart", cart);
            _toastService.ShowWarning(cartItem.MenuItemName, "REMOVED FROM CART:");

            OnChange.Invoke();
        }

        public async Task EmptyCart()
        {
            await _localStorage.RemoveItemAsync("cart");
            OnChange.Invoke();
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                return new List<CartItem>();
            }
            return cart;
        }
    }
}
