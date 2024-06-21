using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant_Site.server.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("1ce52420-4e88-49c9-b438-565c6fd50be6"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("cb506f9f-69c5-4663-975a-cfa65aa89c0a"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("54311f69-e0fb-4b64-b936-4a2c32a1d053"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Role", "Username", "customerStatus" },
                values: new object[] { new Guid("1ce52420-4e88-49c9-b438-565c6fd50be6"), "Dushanbe", "92-999-99-99", "Customer", "Azizjon", "Azizov", "client1", null, "client", "Aziz", 0 });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "IsAvailable", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[] { new Guid("cb506f9f-69c5-4663-975a-cfa65aa89c0a"), "Asht", "92-977-77-77", "Employee", "Faridun", false, "Ikromzoda", "12", null, 0, "admin", "Faridun" });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "Capacity" },
                values: new object[] { new Guid("54311f69-e0fb-4b64-b936-4a2c32a1d053"), "1" });
        }
    }
}
