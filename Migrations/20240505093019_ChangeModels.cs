using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restaurant_Site.Migrations
{
    /// <inheritdoc />
    public partial class ChangeModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Capacity",
                table: "Tables",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CretionalDate", "customerId", "status", "tableId" },
                values: new object[] { new Guid("57c43782-922c-4db2-bf5f-220ac4596994"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("1e8567ad-e847-4a52-8bf6-8a13bf65d7a8"), "Asht", "92-977-77-77", "Employee", "Faridun", "Ikromzoda", "12", null, 0, "admin", "Faridun" },
                    { new Guid("78b38356-30f7-4d15-8a9d-f76f11c79989"), "Arbob", "92-877-77-77", "Employee", "Nasimjon", "Temurov", "123", null, 0, "admin", "Nasa" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Role", "Username", "customerStatus" },
                values: new object[] { new Guid("df62b514-b858-4ab6-8fdb-07a056d2c612"), "Dushanbe", "92-999-99-99", "Customer", "Azizjon", "Azizov", "client1", null, "client", "Aziz", 0 });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[] { new Guid("e5665008-bb84-4f74-b050-9e67b7adf47a"), "Khujand", "92-677-77-77", "Employee", "Azamjon", "Soliev", "123", null, 0, "admin", "Azam" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "DishType", "HolderId", "MenuId", "Name", "OrderId", "Photo", "Price", "Status" },
                values: new object[,]
                {
                    { new Guid("7cf6ef91-5f6a-464f-9914-96278383e66c"), "ЯК ба як", 0, new Guid("00000000-0000-0000-0000-000000000000"), null, "Палов", null, "palov.jpg", 100m, 0 },
                    { new Guid("8bce2f33-f989-4b81-a70a-78dd2ecd6062"), "gushtin", 0, new Guid("00000000-0000-0000-0000-000000000000"), null, "mantu", null, "a.jpg", 20m, 0 }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "Capacity" },
                values: new object[,]
                {
                    { new Guid("0a7ebca1-343f-46af-96b2-3a8f14dbd912"), "3" },
                    { new Guid("5611e014-64ca-4cbe-bdfc-5028c9f70381"), "2" },
                    { new Guid("764496ee-730e-471d-80e1-cd59b41285ff"), "1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("57c43782-922c-4db2-bf5f-220ac4596994"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("1e8567ad-e847-4a52-8bf6-8a13bf65d7a8"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("78b38356-30f7-4d15-8a9d-f76f11c79989"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("df62b514-b858-4ab6-8fdb-07a056d2c612"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e5665008-bb84-4f74-b050-9e67b7adf47a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7cf6ef91-5f6a-464f-9914-96278383e66c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8bce2f33-f989-4b81-a70a-78dd2ecd6062"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("0a7ebca1-343f-46af-96b2-3a8f14dbd912"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("5611e014-64ca-4cbe-bdfc-5028c9f70381"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("764496ee-730e-471d-80e1-cd59b41285ff"));

            migrationBuilder.AlterColumn<int>(
                name: "Capacity",
                table: "Tables",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
