using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDeliveryWebsite.Server.Migrations
{
    public partial class MenuItemSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Turkey bacon and sweet pineapples topped with 100% imported Italian mozzarella cheese.", "images/aloha.jpg", "Aloha", 10.90m },
                    { 2, "Beef pepperoni topped with 100% imported Italian mozzarella cheese.", "images/pepperoni.jpg", "Pepperoni", 10.90m },
                    { 3, "Grilled oregano chicken strips loaded with roasted red peppers, parmesa and 100% imported Italian mozzarella cheese.", "images/sanRemo.jpg", "San Remo", 10.90m },
                    { 4, "Home-made teriyaki sauce, oregano chicken, olive oil, white onions with 100% imported Italian mozzarella cheese.", "images/teriyakiChicken.jpg", "Teriyaki Chicken", 10.90m },
                    { 5, "Tomatoes, fresh basil leaves, olive oil, topped with 100% imported Italian mozzarella cheese.", "images/margherita.jpg", "Margherita", 10.90m },
                    { 6, "Made with freshly handmade dough, topped with our handmade pizza sauce and secret spices and completed with 100% imported Italian mozzarella cheese.", "images/cheese.jpg", "Cheese", 10.90m },
                    { 7, "Delicious and refreshing since 1886.", "images/cocaCola.png", "Coca-Cola", 2.90m },
                    { 8, "100% real brewed from selected premium tea leaves, POKKA Jasmine Green Tea delivers the superior taste you have come to love. Its blend of aromatic jasmine with the highest quality green tea promises a refreshing enjoyment with natural antioxidant goodness.", "images/greenTea.jpg", "Green Tea", 2.90m },
                    { 9, "A full-bodied infusion of black tea with rich cocoa undertones.", "images/tea.jpg", "Hot Tea", 2.90m },
                    { 10, "Enjoy our rich, flavorful brewed coffees any time of the day. Easy-drinking on its own and delicious with milk and sugar.", "images/coffee.jpg", "Hot Coffee", 2.90m },
                    { 11, "There’s no question chocolate and coffee are flavors that meant for each other. Both are rich and full of depth. Where one is creamy, the other is roasty. They complement each other perfectly. And when they come together under a fluffy cloud of sweetened whipped cream, you’ll wish their union would last forever.", "images/mocha.jpg", "Caffè Mocha", 5.90m },
                    { 12, "DASANI® combines the process of reverse osmosis filtration with a proprietary blend of minerals to create fresh, clean, and premium tasting water that is pure and delicious.", "images/dasani.jpg", "Dasani Water (600ML)", 1.90m },
                    { 13, "Rich and moist with oozing Belgian chocolate lava inside.", "images/chocLavaCake.jpg", "Hot Chocolate Lava Cake", 8.90m },
                    { 14, "It is made of ladyfingers dipped in coffee, layered with a whipped mixture of eggs, sugar, and mascarpone cheese, flavoured with cocoa.", "images/tiramisu.jpg", "Tiramisu", 8.90m },
                    { 15, "Our delicious take on the lemon meringue pie – A sweet, tangy tango of lemon curd, cheesecake, and a beautifully torched meringue.", "images/lemonMeringue.jpg", "Lemon Meringue Cheesecake", 8.90m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
