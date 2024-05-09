using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restaurant_Site.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDataTypeInfrastructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuProduct_Menus_MenuId",
                table: "MenuProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuProduct_Products_ProductId",
                table: "MenuProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Orders_Id",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Orders_Id",
                table: "Tables");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MenuProduct",
                table: "MenuProduct");

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

            migrationBuilder.RenameTable(
                name: "MenuProduct",
                newName: "ProductMenu");

            migrationBuilder.RenameIndex(
                name: "IX_MenuProduct_ProductId",
                table: "ProductMenu",
                newName: "IX_ProductMenu_ProductId");

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TableId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductMenu",
                table: "ProductMenu",
                columns: new[] { "MenuId", "ProductId" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("678bffca-8c0f-4f61-95cd-109d6362d18b"), "Khujand", "92-677-77-77", "Employee", "Azamjon", "Soliev", "123", null, 0, "admin", "Azam" },
                    { new Guid("bc42659c-36bd-4d65-ba19-b6175d8260e3"), "Asht", "92-977-77-77", "Employee", "Faridun", "Ikromzoda", "12", null, 0, "admin", "Faridun" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Role", "Username", "customerStatus" },
                values: new object[] { new Guid("d2a4583a-f7ba-4716-9b91-6b2cac9d3627"), "Dushanbe", "92-999-99-99", "Customer", "Azizjon", "Azizov", "client1", null, "client", "Aziz", 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "DishType", "HolderId", "Name", "Photo", "Price", "Status" },
                values: new object[,]
                {
                    { new Guid("3b959f23-70ec-4c1b-9315-76033a505bc2"), "gushtin", 0, new Guid("00000000-0000-0000-0000-000000000000"), "mantu", "a.jpg", 20.0, 0 },
                    { new Guid("fae289b9-a601-4e75-8eba-bfe14bd02912"), "ЯК ба як", 0, new Guid("00000000-0000-0000-0000-000000000000"), "Палов", "palov.jpg", 100.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "Capacity" },
                values: new object[] { new Guid("c35ffad2-fb84-4956-b12f-d25aa94f4521"), "1" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TableId",
                table: "Orders",
                column: "TableId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Persons_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Tables_TableId",
                table: "Orders",
                column: "TableId",
                principalTable: "Tables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductMenu_Menus_MenuId",
                table: "ProductMenu",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductMenu_Products_ProductId",
                table: "ProductMenu",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Persons_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Tables_TableId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductMenu_Menus_MenuId",
                table: "ProductMenu");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductMenu_Products_ProductId",
                table: "ProductMenu");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_TableId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductMenu",
                table: "ProductMenu");

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("678bffca-8c0f-4f61-95cd-109d6362d18b"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("bc42659c-36bd-4d65-ba19-b6175d8260e3"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d2a4583a-f7ba-4716-9b91-6b2cac9d3627"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b959f23-70ec-4c1b-9315-76033a505bc2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fae289b9-a601-4e75-8eba-bfe14bd02912"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("c35ffad2-fb84-4956-b12f-d25aa94f4521"));

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "TableId",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "ProductMenu",
                newName: "MenuProduct");

            migrationBuilder.RenameIndex(
                name: "IX_ProductMenu_ProductId",
                table: "MenuProduct",
                newName: "IX_MenuProduct_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MenuProduct",
                table: "MenuProduct",
                columns: new[] { "MenuId", "ProductId" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_MenuProduct_Menus_MenuId",
                table: "MenuProduct",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuProduct_Products_ProductId",
                table: "MenuProduct",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Orders_Id",
                table: "Persons",
                column: "Id",
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
    }
}
