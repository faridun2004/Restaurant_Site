using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant_Site.server.Migrations
{
    /// <inheritdoc />
    public partial class Changev : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Expense",
                keyColumn: "Id",
                keyValue: new Guid("2cf6655f-a522-4c61-8069-9f81c3068be6"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("456835d8-d434-477a-a762-eb9f368cb668"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8e88e100-4857-44dc-bd9f-e8ca8d297e69"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("0b13548a-7bb4-4c25-b61c-f2baa3898603"));

            migrationBuilder.DeleteData(
                table: "ExpenseCategories",
                keyColumn: "Id",
                keyValue: new Guid("a7c1e803-ffa1-45c5-9b42-8ef83c005f31"));

            migrationBuilder.InsertData(
                table: "ExpenseCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("59375a4b-6663-43f6-8250-d75ff1be86a6"), "Meals" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Role", "Username", "customerStatus" },
                values: new object[] { new Guid("742f7e68-2348-4432-b17b-2ef7949e53b6"), "Dushanbe", "92-999-99-99", "Customer", "Azizjon", "Azizov", "client1", null, "client", "Aziz", 0 });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "IsAvailable", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[] { new Guid("a3c99cc1-5fe4-47e0-aee6-5b3777a2dd74"), "Asht", "92-977-77-77", "Employee", "Faridun", false, "Ikromzoda", "12", null, 0, "admin", "Faridun" });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "Capacity" },
                values: new object[] { new Guid("85d64209-e77e-4cc8-8694-b7b7037627f1"), "1" });

            migrationBuilder.InsertData(
                table: "Expense",
                columns: new[] { "Id", "Amount", "CategoryId", "Description", "ExpenseDateTime" },
                values: new object[] { new Guid("105d6c18-5d78-4533-ab09-6f4e5a7964d4"), 45.67m, new Guid("59375a4b-6663-43f6-8250-d75ff1be86a6"), "Lunch with client", new DateTime(2024, 6, 19, 18, 46, 19, 208, DateTimeKind.Utc).AddTicks(5592) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Expense",
                keyColumn: "Id",
                keyValue: new Guid("105d6c18-5d78-4533-ab09-6f4e5a7964d4"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("742f7e68-2348-4432-b17b-2ef7949e53b6"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("a3c99cc1-5fe4-47e0-aee6-5b3777a2dd74"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("85d64209-e77e-4cc8-8694-b7b7037627f1"));

            migrationBuilder.DeleteData(
                table: "ExpenseCategories",
                keyColumn: "Id",
                keyValue: new Guid("59375a4b-6663-43f6-8250-d75ff1be86a6"));

            migrationBuilder.InsertData(
                table: "ExpenseCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("a7c1e803-ffa1-45c5-9b42-8ef83c005f31"), "Meals" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Role", "Username", "customerStatus" },
                values: new object[] { new Guid("456835d8-d434-477a-a762-eb9f368cb668"), "Dushanbe", "92-999-99-99", "Customer", "Azizjon", "Azizov", "client1", null, "client", "Aziz", 0 });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "IsAvailable", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[] { new Guid("8e88e100-4857-44dc-bd9f-e8ca8d297e69"), "Asht", "92-977-77-77", "Employee", "Faridun", false, "Ikromzoda", "12", null, 0, "admin", "Faridun" });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "Capacity" },
                values: new object[] { new Guid("0b13548a-7bb4-4c25-b61c-f2baa3898603"), "1" });

            migrationBuilder.InsertData(
                table: "Expense",
                columns: new[] { "Id", "Amount", "CategoryId", "Description", "ExpenseDateTime" },
                values: new object[] { new Guid("2cf6655f-a522-4c61-8069-9f81c3068be6"), 45.67m, new Guid("a7c1e803-ffa1-45c5-9b42-8ef83c005f31"), "Lunch with client", new DateTime(2024, 6, 15, 5, 25, 44, 95, DateTimeKind.Utc).AddTicks(5518) });
        }
    }
}
