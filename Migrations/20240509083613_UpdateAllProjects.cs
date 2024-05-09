using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restaurant_Site.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAllProjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("a93c989b-88b1-4082-a7e4-e9599455ebd8"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e845f5be-5bce-417a-a7c7-c73fc0d49d1d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e875db9-e2fa-4d2d-b4c4-89e51835bbaa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f0a70921-8cd5-49ef-93fe-a1023c7f833c"));

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[] { new Guid("ca3f4a60-ac1f-4399-bce3-5e0952fc3182"), "Asht", "92-977-77-77", "Employee", "Faridun", "Ikromzoda", "12", null, 0, "admin", "Faridun" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Role", "Username", "customerStatus" },
                values: new object[] { new Guid("d4b7d780-1b02-4a02-bbbd-d0d4044e9d25"), "Dushanbe", "92-999-99-99", "Customer", "Azizjon", "Azizov", "client1", null, "client", "Aziz", 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "DishType", "HolderId", "Name", "Photo", "Price", "Status" },
                values: new object[,]
                {
                    { new Guid("549393fc-976c-442a-a986-1c752c64b0f3"), "gushtin", 0, new Guid("00000000-0000-0000-0000-000000000000"), "mantu", "a.jpg", 20.0, 0 },
                    { new Guid("b46182a3-711d-4ab1-afde-f8954707843f"), "ЯК ба як", 0, new Guid("00000000-0000-0000-0000-000000000000"), "Палов", "palov.jpg", 100.0, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("ca3f4a60-ac1f-4399-bce3-5e0952fc3182"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d4b7d780-1b02-4a02-bbbd-d0d4044e9d25"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("549393fc-976c-442a-a986-1c752c64b0f3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b46182a3-711d-4ab1-afde-f8954707843f"));

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Role", "Username", "customerStatus" },
                values: new object[] { new Guid("a93c989b-88b1-4082-a7e4-e9599455ebd8"), "Dushanbe", "92-999-99-99", "Customer", "Azizjon", "Azizov", "client1", null, "client", "Aziz", 0 });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[] { new Guid("e845f5be-5bce-417a-a7c7-c73fc0d49d1d"), "Asht", "92-977-77-77", "Employee", "Faridun", "Ikromzoda", "12", null, 0, "admin", "Faridun" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "DishType", "HolderId", "Name", "Photo", "Price", "Status" },
                values: new object[,]
                {
                    { new Guid("6e875db9-e2fa-4d2d-b4c4-89e51835bbaa"), "gushtin", 0, new Guid("00000000-0000-0000-0000-000000000000"), "mantu", "a.jpg", 20.0, 0 },
                    { new Guid("f0a70921-8cd5-49ef-93fe-a1023c7f833c"), "ЯК ба як", 0, new Guid("00000000-0000-0000-0000-000000000000"), "Палов", "palov.jpg", 100.0, 0 }
                });
        }
    }
}
