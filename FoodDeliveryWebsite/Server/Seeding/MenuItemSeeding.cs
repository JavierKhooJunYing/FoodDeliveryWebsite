using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryWebsite.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodDeliveryWebsite.Server.Seeding
{
    public class MenuItemSeeding : IEntityTypeConfiguration<MenuItem>
    {
        public void Configure(EntityTypeBuilder<MenuItem> builder)
        {
            builder.HasData(
                new MenuItem
                {
                    Id = 1,
                    Name = "Aloha",                  
                    Description = "Turkey bacon and sweet pineapples topped with 100% imported Italian mozzarella cheese.",
                    ImageUrl = "images/aloha.jpg",
                    Price = 10.90M,
                    Featured = true,
                    CategoryId = 1
                },
                new MenuItem
                {
                    Id = 2,
                    Name = "Pepperoni",
                    Description = "Beef pepperoni topped with 100% imported Italian mozzarella cheese.",
                    ImageUrl = "images/pepperoni.jpg",
                    Price = 10.90M,
                    CategoryId = 1
                },
                new MenuItem
                {
                    Id = 3,
                    Name = "San Remo",                  
                    Description = "Grilled oregano chicken strips loaded with roasted red peppers, parmesa and 100% imported Italian mozzarella cheese.",
                    ImageUrl = "images/sanRemo.jpg",
                    Price = 10.90M,
                    CategoryId = 1
                },
                new MenuItem
                {
                    Id = 4,
                    Name = "Teriyaki Chicken",                 
                    Description = "Home-made teriyaki sauce, oregano chicken, olive oil, white onions with 100% imported Italian mozzarella cheese.",
                    ImageUrl = "images/teriyakiChicken.jpg",
                    Price = 10.90M,
                    CategoryId = 1
                },
                new MenuItem
                {
                    Id = 5,
                    Name = "Margherita",                  
                    Description = "Tomatoes, fresh basil leaves, olive oil, topped with 100% imported Italian mozzarella cheese.",
                    ImageUrl = "images/margherita.jpg",
                    Price = 10.90M,
                    CategoryId = 1
                },
                new MenuItem
                {
                    Id = 6,
                    Name = "Cheese",                   
                    Description = "Made with freshly handmade dough, topped with our handmade pizza sauce and secret spices and completed with 100% imported Italian mozzarella cheese.",
                    ImageUrl = "images/cheese.jpg",
                    Price = 10.90M,
                    CategoryId = 1
                },
                new MenuItem
                {
                    Id = 7,
                    Name = "Coca-Cola",                  
                    Description = "Delicious and refreshing since 1886.",
                    ImageUrl = "images/cocaCola.png",
                    Price = 2.90M,
                    CategoryId = 2
                },
                new MenuItem
                {
                    Id = 8,
                    Name = "Green Tea",                 
                    Description = "100% real brewed from selected premium tea leaves, POKKA Jasmine Green Tea delivers the superior taste you have come to love. Its blend of aromatic jasmine with the highest quality green tea promises a refreshing enjoyment with natural antioxidant goodness.",
                    ImageUrl = "images/greenTea.jpg",
                    Price = 2.90M,
                    CategoryId = 2
                },
                new MenuItem
                {
                    Id = 9,
                    Name = "Hot Tea",               
                    Description = "A full-bodied infusion of black tea with rich cocoa undertones.",
                    ImageUrl = "images/tea.jpg",
                    Price = 2.90M,
                    CategoryId = 2
                },
                new MenuItem
                {
                    Id = 10,
                    Name = "Hot Coffee",                 
                    Description = "Enjoy our rich, flavorful brewed coffees any time of the day. Easy-drinking on its own and delicious with milk and sugar.",
                    ImageUrl = "images/coffee.jpg",
                    Price = 2.90M,
                    CategoryId = 2
                },
                new MenuItem
                {
                    Id = 11,
                    Name = "Caffè Mocha",                  
                    Description = "There’s no question chocolate and coffee are flavors that meant for each other. Both are rich and full of depth. Where one is creamy, the other is roasty. They complement each other perfectly. And when they come together under a fluffy cloud of sweetened whipped cream, you’ll wish their union would last forever.",
                    ImageUrl = "images/mocha.jpg",
                    Price = 5.90M,
                    Featured = true,
                    CategoryId = 2
                },
                new MenuItem
                {
                    Id = 12,
                    Name = "Dasani Water (600ML)",                 
                    Description = "DASANI® combines the process of reverse osmosis filtration with a proprietary blend of minerals to create fresh, clean, and premium tasting water that is pure and delicious.",
                    ImageUrl = "images/dasani.jpg",
                    Price = 1.90M,
                    CategoryId = 2
                },
                new MenuItem
                {
                    Id = 13,
                    Name = "Hot Chocolate Lava Cake",
                    Description = "Rich and moist with oozing Belgian chocolate lava inside.",
                    ImageUrl = "images/chocLavaCake.jpg",
                    Price = 8.90M,
                    Featured = true,
                    CategoryId = 3
                },
                new MenuItem
                {
                    Id = 14,
                    Name = "Tiramisu",                  
                    Description = "It is made of ladyfingers dipped in coffee, layered with a whipped mixture of eggs, sugar, and mascarpone cheese, flavoured with cocoa.",
                    ImageUrl = "images/tiramisu.jpg",
                    Price = 8.90M,
                    CategoryId = 3
                },
                new MenuItem
                {
                    Id = 15,
                    Name = "Lemon Meringue Cheesecake",
                    Description = "Our delicious take on the lemon meringue pie – A sweet, tangy tango of lemon curd, cheesecake, and a beautifully torched meringue.",
                    ImageUrl = "images/lemonMeringue.jpg",
                    Price = 8.90M,
                    CategoryId = 3
                }
            );
        }
    }
}
