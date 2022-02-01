using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryWebsite.Shared;
using FoodDeliveryWebsite.Shared.DTOs;

namespace FoodDeliveryWebsite.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(CartItem item);
        Task<List<CartItem>> GetCartItems();
        Task DeleteCartItem(CartItem item);
        Task EmptyCart();
    }
}
