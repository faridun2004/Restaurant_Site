using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restaurant_Site.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("34bda8ee-c64b-4164-9785-04f299eaae79"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("6dcfb501-657d-4453-aada-85227b6b5465"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8da8b0e8-fa46-4b69-97ba-3fbcf471061b"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("a0a71583-90d9-493c-b767-3487788c717b"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("adb2f732-7b8c-4c17-8c80-e3ded0c0f9d3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3e989e9c-e2b6-4527-925f-9c279dd4e908"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a75f9da-9a20-46c4-8b8e-5c2a6e098dbd"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("328986cf-9baf-4eb8-b4db-49e55875d92e"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("79b76ef8-5a86-4dab-bff0-bfb4a2ab01ee"));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CretionalDate", "customerId", "status", "tableId" },
                values: new object[] { new Guid("89928762-dacb-403a-b0f8-8fef321365ea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("0340e5f3-2e3a-43cd-a662-48321fee9b63"), "Khujand", "92-677-77-77", "Employee", "Azamjon", "Soliev", "123", null, 0, "admin", "Azam" },
                    { new Guid("2f625f8a-b6f6-4ecc-883e-c3bfecff4ee8"), "Arbob", "92-877-77-77", "Employee", "Nasimjon", "Temurov", "123", null, 0, "admin", "Nasa" },
                    { new Guid("41dd3790-2f9f-48ab-80a7-a5fbb2a1f7b7"), "Asht", "92-977-77-77", "Employee", "Faridun", "Ikromzoda", "12", null, 0, "admin", "Faridun" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Role", "Username", "customerStatus" },
                values: new object[] { new Guid("46acea22-7ddb-4222-a8c5-ac15ad1491c7"), "Dushanbe", "92-999-99-99", "Customer", "Azizjon", "Azizov", "client1", null, "client", "Aziz", 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "DishType", "HolderId", "MenuId", "Name", "OrderId", "Photo", "Price", "Status" },
                values: new object[,]
                {
                    { new Guid("02b45abc-2d9c-46c3-8c2c-206b2b6cdc36"), "gushtin", 0, new Guid("00000000-0000-0000-0000-000000000000"), null, "mantu", null, "a.jpg", 20m, 0 },
                    { new Guid("6d3fd180-c18a-4d6a-a8cd-48f4441b1fd0"), "ЯК ба як", 0, new Guid("00000000-0000-0000-0000-000000000000"), null, "Палов", null, "palov.jpg", 100m, 0 }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "Capacity" },
                values: new object[,]
                {
                    { new Guid("05052943-9de5-4157-9562-78b009034f78"), 2 },
                    { new Guid("3422d8c9-14c6-483a-911d-04933a2afcec"), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("89928762-dacb-403a-b0f8-8fef321365ea"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("0340e5f3-2e3a-43cd-a662-48321fee9b63"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("2f625f8a-b6f6-4ecc-883e-c3bfecff4ee8"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("41dd3790-2f9f-48ab-80a7-a5fbb2a1f7b7"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("46acea22-7ddb-4222-a8c5-ac15ad1491c7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02b45abc-2d9c-46c3-8c2c-206b2b6cdc36"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d3fd180-c18a-4d6a-a8cd-48f4441b1fd0"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("05052943-9de5-4157-9562-78b009034f78"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("3422d8c9-14c6-483a-911d-04933a2afcec"));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CretionalDate", "customerId", "status", "tableId" },
                values: new object[] { new Guid("34bda8ee-c64b-4164-9785-04f299eaae79"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[] { new Guid("6dcfb501-657d-4453-aada-85227b6b5465"), "Asht", "92-977-77-77", "Employee", "Faridun", "Ikromzoda", "12", null, 0, "admin", "Faridun" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Role", "Username", "customerStatus" },
                values: new object[] { new Guid("8da8b0e8-fa46-4b69-97ba-3fbcf471061b"), "Dushanbe", "92-999-99-99", "Customer", "Azizjon", "Azizov", "client1", null, "client", "Aziz", 0 });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("a0a71583-90d9-493c-b767-3487788c717b"), "Arbob", "92-877-77-77", "Employee", "Nasimjon", "Temurov", "123", null, 0, "admin", "Nasa" },
                    { new Guid("adb2f732-7b8c-4c17-8c80-e3ded0c0f9d3"), "Khujand", "92-677-77-77", "Employee", "Azamjon", "Soliev", "123", null, 0, "admin", "Azam" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "DishType", "HolderId", "MenuId", "Name", "OrderId", "Photo", "Price", "Status" },
                values: new object[,]
                {
                    { new Guid("3e989e9c-e2b6-4527-925f-9c279dd4e908"), "ЯК ба як", 0, new Guid("00000000-0000-0000-0000-000000000000"), null, "Палов", null, "palov.jpg", 100m, 0 },
                    { new Guid("8a75f9da-9a20-46c4-8b8e-5c2a6e098dbd"), "gushtin", 0, new Guid("00000000-0000-0000-0000-000000000000"), null, "mantu", null, "a.jpg", 20m, 0 }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "Capacity" },
                values: new object[,]
                {
                    { new Guid("328986cf-9baf-4eb8-b4db-49e55875d92e"), 2 },
                    { new Guid("79b76ef8-5a86-4dab-bff0-bfb4a2ab01ee"), 1 }
                });
        }
    }
}
