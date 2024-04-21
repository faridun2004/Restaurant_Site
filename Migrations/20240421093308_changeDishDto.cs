using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restaurant_Site.Migrations
{
    /// <inheritdoc />
    public partial class changeDishDto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("6a28f62c-1149-4a2c-87c4-7d26e355b025"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ab199fb5-d206-4aeb-88c5-85ac99a9527e"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("14407e65-5c4a-46d9-93e2-3e318835ae87"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("88a87c39-b4a6-494f-84d6-72040e4bf6b6"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d47c4ce0-71b9-485c-a621-82651dcad5d0"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("6a28f62c-1149-4a2c-87c4-7d26e355b025"), "gushtin", new Guid("00000000-0000-0000-0000-000000000000"), null, "mantu", null, "a.jpg", 20m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "Status", "TableId" },
                values: new object[] { new Guid("ab199fb5-d206-4aeb-88c5-85ac99a9527e"), null, 0, null });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("14407e65-5c4a-46d9-93e2-3e318835ae87"), null, null, "Employee", "Azamjon", "Soliev", "123", null, 0, "admin", "Azam" },
                    { new Guid("88a87c39-b4a6-494f-84d6-72040e4bf6b6"), null, null, "Employee", "Faridun", "Ikromzoda", "12", null, 0, "admin", "Faridun" },
                    { new Guid("d47c4ce0-71b9-485c-a621-82651dcad5d0"), null, null, "Employee", "nasim", "nasa", "123", null, 0, "admin", "Nasa" }
                });
        }
    }
}
