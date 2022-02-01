using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryWebsite.Shared.DTOs
{
    public class CartItem
    {
        public int MenuItemId { get; set; }
        public string MenuItemName { get; set; }
        public string MenuItemDescription { get; set; }
        public string MenuItemImageUrl { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal MenuItemPrice { get; set; }
        public int Quantity { get; set; }
    }
}
