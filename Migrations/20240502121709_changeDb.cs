using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restaurant_Site.Migrations
{
    /// <inheritdoc />
    public partial class changeDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ad3d4f8b-4a5a-4b79-83c7-8abb1c747c08"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("42a2422e-06bc-4520-b455-f2c05fd67ad9"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("79ce2018-b792-4ae1-bf70-4697966c048b"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("bd0cd23f-059c-4c53-85e6-b5b6e11c9bd0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("686e8d14-4e8a-40bf-8f81-f083656f031c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba0caf2f-3fd0-4bb1-a977-a0e4d834484d"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("637e4064-f0af-43f2-867a-e88039fcea29"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("e4ac66ea-4d89-46dd-ac88-32eb9c962957"));

            migrationBuilder.DropColumn(
                name: "customerType",
                table: "Persons");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "customerType",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CretionalDate", "customerId", "status", "tableId" },
                values: new object[] { new Guid("ad3d4f8b-4a5a-4b79-83c7-8abb1c747c08"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("42a2422e-06bc-4520-b455-f2c05fd67ad9"), null, null, "Employee", "nasim", "nasa", "123", null, 0, "admin", "Nasa" },
                    { new Guid("79ce2018-b792-4ae1-bf70-4697966c048b"), null, null, "Employee", "Azamjon", "Soliev", "123", null, 0, "admin", "Azam" },
                    { new Guid("bd0cd23f-059c-4c53-85e6-b5b6e11c9bd0"), null, null, "Employee", "Faridun", "Ikromzoda", "12", null, 0, "admin", "Faridun" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "DishType", "HolderId", "MenuId", "Name", "OrderId", "Photo", "Price", "Status" },
                values: new object[,]
                {
                    { new Guid("686e8d14-4e8a-40bf-8f81-f083656f031c"), "gushtin", 0, new Guid("00000000-0000-0000-0000-000000000000"), null, "mantu", null, "a.jpg", 20m, 0 },
                    { new Guid("ba0caf2f-3fd0-4bb1-a977-a0e4d834484d"), "ЯК ба як", 0, new Guid("00000000-0000-0000-0000-000000000000"), null, "Палов", null, "palov.jpg", 100m, 0 }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "Capacity" },
                values: new object[,]
                {
                    { new Guid("637e4064-f0af-43f2-867a-e88039fcea29"), 2 },
                    { new Guid("e4ac66ea-4d89-46dd-ac88-32eb9c962957"), 1 }
                });
        }
    }
}
