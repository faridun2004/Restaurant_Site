using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restaurant_Site.Migrations
{
    /// <inheritdoc />
    public partial class AddManyToManyCollection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Persons_customerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Tables_tableId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Menus_MenuId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_MenuId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_OrderId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Orders_customerId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_tableId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("07e9abf9-f124-4246-a6c8-b1a7bc652360"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c3e081f4-7b4e-4992-8f0d-acf701c11b8b"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("6f1bc150-6d33-472c-878d-a8623ad47856"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("7bfcc8e1-3fa1-4dcb-a7df-40c708580ee8"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("93d38cf0-a54e-4541-991d-a83e873a14a9"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d41d1689-d9c3-4b8c-b1e5-b43af3ac4fe5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1e0ee36c-d94f-4d36-addf-da0e673315a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("64e69abf-579e-4b4c-aa6b-c52ac4966193"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("549545d4-a330-4cb4-a4db-7d44c13d30b9"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("6697ebf4-d9c1-48e9-8900-8ee1cc1e40bb"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("c25df09e-e9ea-42af-bc8e-e0ebc5d0046e"));

            migrationBuilder.DropColumn(
                name: "MenuId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "customerId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "tableId",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "EditDate",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "MenuProduct",
                columns: table => new
                {
                    MenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuProduct", x => new { x.MenuId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_MenuProduct_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuProduct_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Role", "Username", "customerStatus" },
                values: new object[] { new Guid("0ce08d29-b08e-4280-a5e7-516aef31ae69"), "Dushanbe", "92-999-99-99", "Customer", "Azizjon", "Azizov", "client1", null, "client", "Aziz", 0 });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("5f0f027b-1b52-48e7-92e2-49695868456f"), "Arbob", "92-877-77-77", "Employee", "Nasimjon", "Temurov", "123", null, 0, "admin", "Nasa" },
                    { new Guid("6c9a713a-d07f-46b8-aafa-d62dfc39c86c"), "Khujand", "92-677-77-77", "Employee", "Azamjon", "Soliev", "123", null, 0, "admin", "Azam" },
                    { new Guid("7f9f8024-c0d5-4338-a424-9ad8559cf334"), "Asht", "92-977-77-77", "Employee", "Faridun", "Ikromzoda", "12", null, 0, "admin", "Faridun" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "DishType", "HolderId", "Name", "Photo", "Price", "Status" },
                values: new object[,]
                {
                    { new Guid("8804f5f5-3b2d-4e22-b1a6-9999fb61408f"), "gushtin", 0, new Guid("00000000-0000-0000-0000-000000000000"), "mantu", "a.jpg", 20.0, 0 },
                    { new Guid("ed1f114a-b312-4ae5-b2e8-9f38a857c37a"), "ЯК ба як", 0, new Guid("00000000-0000-0000-0000-000000000000"), "Палов", "palov.jpg", 100.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "Capacity" },
                values: new object[,]
                {
                    { new Guid("4fb2aa11-6fd5-4ec2-a133-1fda79086900"), "2" },
                    { new Guid("8d6b6065-2278-4eb2-98b0-1c1c4300a441"), "1" },
                    { new Guid("9a8e1fd6-0b46-4213-a22b-61846e9589e7"), "3" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_HolderId",
                table: "Products",
                column: "HolderId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuProduct_ProductId",
                table: "MenuProduct",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Orders_Id",
                table: "Persons",
                column: "Id",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_HolderId",
                table: "Products",
                column: "HolderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_Orders_Id",
                table: "Tables",
                column: "Id",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Orders_Id",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_HolderId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Orders_Id",
                table: "Tables");

            migrationBuilder.DropTable(
                name: "MenuProduct");

            migrationBuilder.DropIndex(
                name: "IX_Products_HolderId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("0ce08d29-b08e-4280-a5e7-516aef31ae69"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("5f0f027b-1b52-48e7-92e2-49695868456f"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("6c9a713a-d07f-46b8-aafa-d62dfc39c86c"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("7f9f8024-c0d5-4338-a424-9ad8559cf334"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8804f5f5-3b2d-4e22-b1a6-9999fb61408f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed1f114a-b312-4ae5-b2e8-9f38a857c37a"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("4fb2aa11-6fd5-4ec2-a133-1fda79086900"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("8d6b6065-2278-4eb2-98b0-1c1c4300a441"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("9a8e1fd6-0b46-4213-a22b-61846e9589e7"));

            migrationBuilder.DropColumn(
                name: "EditDate",
                table: "Orders");

            migrationBuilder.AddColumn<Guid>(
                name: "MenuId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "OrderId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "customerId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "tableId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Menus",
                column: "Id",
                value: new Guid("07e9abf9-f124-4246-a6c8-b1a7bc652360"));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CretionalDate", "customerId", "status", "tableId" },
                values: new object[] { new Guid("c3e081f4-7b4e-4992-8f0d-acf701c11b8b"), new DateTime(2024, 5, 7, 15, 35, 7, 948, DateTimeKind.Local).AddTicks(8327), null, 0, null });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("6f1bc150-6d33-472c-878d-a8623ad47856"), "Khujand", "92-677-77-77", "Employee", "Azamjon", "Soliev", "123", null, 0, "admin", "Azam" },
                    { new Guid("7bfcc8e1-3fa1-4dcb-a7df-40c708580ee8"), "Arbob", "92-877-77-77", "Employee", "Nasimjon", "Temurov", "123", null, 0, "admin", "Nasa" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Role", "Username", "customerStatus" },
                values: new object[] { new Guid("93d38cf0-a54e-4541-991d-a83e873a14a9"), "Dushanbe", "92-999-99-99", "Customer", "Azizjon", "Azizov", "client1", null, "client", "Aziz", 0 });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[] { new Guid("d41d1689-d9c3-4b8c-b1e5-b43af3ac4fe5"), "Asht", "92-977-77-77", "Employee", "Faridun", "Ikromzoda", "12", null, 0, "admin", "Faridun" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "DishType", "HolderId", "MenuId", "Name", "OrderId", "Photo", "Price", "Status" },
                values: new object[,]
                {
                    { new Guid("1e0ee36c-d94f-4d36-addf-da0e673315a4"), "ЯК ба як", 0, new Guid("00000000-0000-0000-0000-000000000000"), null, "Палов", null, "palov.jpg", 100.0, 0 },
                    { new Guid("64e69abf-579e-4b4c-aa6b-c52ac4966193"), "gushtin", 0, new Guid("00000000-0000-0000-0000-000000000000"), null, "mantu", null, "a.jpg", 20.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "Capacity" },
                values: new object[,]
                {
                    { new Guid("549545d4-a330-4cb4-a4db-7d44c13d30b9"), "2" },
                    { new Guid("6697ebf4-d9c1-48e9-8900-8ee1cc1e40bb"), "3" },
                    { new Guid("c25df09e-e9ea-42af-bc8e-e0ebc5d0046e"), "1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_MenuId",
                table: "Products",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderId",
                table: "Products",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_customerId",
                table: "Orders",
                column: "customerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_tableId",
                table: "Orders",
                column: "tableId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Persons_customerId",
                table: "Orders",
                column: "customerId",
                principalTable: "Persons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Tables_tableId",
                table: "Orders",
                column: "tableId",
                principalTable: "Tables",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Menus_MenuId",
                table: "Products",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
