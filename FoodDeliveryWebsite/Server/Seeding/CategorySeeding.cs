using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryWebsite.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodDeliveryWebsite.Server.Seeding
{
    public class CategorySeeding : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Pizzas",
                    Url = "pizzas"
                },
                new Category
                {
                    Id = 2,
                    Name = "Beverages",
                    Url = "beverages"
                },
                new Category
                {
                    Id = 3,
                    Name = "Desserts",
                    Url = "desserts"
                }
            );
        }
    }
}
