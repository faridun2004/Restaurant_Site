using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant_Site.server.Migrations
{
    /// <inheritdoc />
    public partial class AddedFinances : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("808b4afe-b0fe-4fec-bbab-55a19241d824"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("fb6789fa-8c83-4706-8a96-db7ed630084e"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("7091dc0a-862d-491f-be0f-381058bf59c1"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Role", "Username", "customerStatus" },
                values: new object[] { new Guid("808b4afe-b0fe-4fec-bbab-55a19241d824"), "Dushanbe", "92-999-99-99", "Customer", "Azizjon", "Azizov", "client1", null, "client", "Aziz", 0 });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "IsAvailable", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[] { new Guid("fb6789fa-8c83-4706-8a96-db7ed630084e"), "Asht", "92-977-77-77", "Employee", "Faridun", false, "Ikromzoda", "12", null, 0, "admin", "Faridun" });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "Capacity" },
                values: new object[] { new Guid("7091dc0a-862d-491f-be0f-381058bf59c1"), "1" });
        }
    }
}
