using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restaurant_Site.Migrations
{
    /// <inheritdoc />
    public partial class AddedOtherModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("91957608-d629-445e-8e22-36db8b9b1e04"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("273c339e-1b91-4927-9b07-d94e65e7b231"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("92a25848-4ea9-49e4-8470-029fda531c52"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("cb407245-1a89-4e0c-a647-31b5a02ab8b6"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("fa6c062f-67e4-4402-9e0f-6ac60bdaf61b"));

            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeliveryDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    OrderId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deliveries_Orders_OrderId1",
                        column: x => x.OrderId1,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "shopingCartItems",
                columns: table => new
                {
                    MenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shopingCartItems", x => x.MenuId);
                });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "Id", "Description", "HolderId", "MenuId", "Name", "OrderId", "Photo", "Price" },
                values: new object[] { new Guid("afd5eeaa-76b7-4ca0-88e0-c9e254fd0879"), "gushtin", new Guid("00000000-0000-0000-0000-000000000000"), null, "mantu", null, "a.jpg", 20m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "Status", "TableId" },
                values: new object[] { new Guid("68f03490-70bb-46e1-a990-e57d54516e89"), null, 0, null });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("9468dc1c-c27f-49d0-bed5-adeebedc17f9"), null, null, "Employee", "nasim", "nasa", "123", null, 0, "admin", "Nasa" },
                    { new Guid("c507ab68-9507-443c-8461-a683b7887ba6"), null, null, "Employee", "Faridun", "Ikromzoda", "12", null, 0, "admin", "Faridun" },
                    { new Guid("e80bce8c-c510-4fcb-99a5-756bfd35c3f6"), null, null, "Employee", "Azamjon", "Soliev", "123", null, 0, "admin", "Azam" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_OrderId1",
                table: "Deliveries",
                column: "OrderId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deliveries");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "shopingCartItems");

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("afd5eeaa-76b7-4ca0-88e0-c9e254fd0879"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("68f03490-70bb-46e1-a990-e57d54516e89"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("9468dc1c-c27f-49d0-bed5-adeebedc17f9"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("c507ab68-9507-443c-8461-a683b7887ba6"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e80bce8c-c510-4fcb-99a5-756bfd35c3f6"));

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "Id", "Description", "HolderId", "MenuId", "Name", "OrderId", "Photo", "Price" },
                values: new object[] { new Guid("91957608-d629-445e-8e22-36db8b9b1e04"), "gushtin", new Guid("00000000-0000-0000-0000-000000000000"), null, "mantu", null, "a.jpg", 20m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "Status", "TableId" },
                values: new object[] { new Guid("273c339e-1b91-4927-9b07-d94e65e7b231"), null, 0, null });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("92a25848-4ea9-49e4-8470-029fda531c52"), null, null, "Employee", "nasim", "nasa", "123", null, 0, "admin", "Nasa" },
                    { new Guid("cb407245-1a89-4e0c-a647-31b5a02ab8b6"), null, null, "Employee", "Azamjon", "Soliev", "123", null, 0, "admin", "Azam" },
                    { new Guid("fa6c062f-67e4-4402-9e0f-6ac60bdaf61b"), null, null, "Employee", "Faridun", "Ikromzoda", "12", null, 0, "admin", "Faridun" }
                });
        }
    }
}
