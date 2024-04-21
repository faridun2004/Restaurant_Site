using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restaurant_Site.Migrations
{
    /// <inheritdoc />
    public partial class ShopingCartAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("640475b6-e6ab-40a5-8f65-dfbaae6aec03"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cfe928e9-9be1-4b93-8bb6-c23e689ac954"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("06f3e35c-3f80-4c57-9d0c-53d7fcb20384"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("542e2d7f-e90b-40e1-861f-51ecac117971"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e04ac40e-4b78-4e6c-839c-e85422d8785a"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "Id", "Description", "HolderId", "MenuId", "Name", "OrderId", "Photo", "Price" },
                values: new object[] { new Guid("640475b6-e6ab-40a5-8f65-dfbaae6aec03"), "gushtin", new Guid("00000000-0000-0000-0000-000000000000"), null, "mantu", null, "a.jpg", 20m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "Status", "TableId" },
                values: new object[] { new Guid("cfe928e9-9be1-4b93-8bb6-c23e689ac954"), null, 0, null });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("06f3e35c-3f80-4c57-9d0c-53d7fcb20384"), null, null, "Employee", "Faridun", "Ikromzoda", "12", null, 0, "admin", "Faridun" },
                    { new Guid("542e2d7f-e90b-40e1-861f-51ecac117971"), null, null, "Employee", "Azamjon", "Soliev", "123", null, 0, "admin", "Azam" },
                    { new Guid("e04ac40e-4b78-4e6c-839c-e85422d8785a"), null, null, "Employee", "nasim", "nasa", "123", null, 0, "admin", "Nasa" }
                });
        }
    }
}
