using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restaurant_Site.Migrations
{
    /// <inheritdoc />
    public partial class DishDTOAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("fa70f727-16d4-48e7-93b2-0b8f163a21e2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3f2ae6d0-81ac-422b-840f-042b7faa76d4"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("67dd4571-749d-49aa-b0ce-9ac2dd43dfe0"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8115dc24-7743-422b-bc61-2021d0ee29b4"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b5941d53-561e-4720-9e70-770c355e19ad"));

            migrationBuilder.AddColumn<int>(
                name: "customerStatus",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "customerType",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "HolderId",
                table: "Dishes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "DishDto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dishType = table.Column<int>(type: "int", nullable: false),
                    HolderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IssuerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    dishStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishDto", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DishDto");

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

            migrationBuilder.DropColumn(
                name: "customerStatus",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "customerType",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "HolderId",
                table: "Dishes");

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "Id", "Description", "MenuId", "Name", "OrderId", "Photo", "Price" },
                values: new object[] { new Guid("fa70f727-16d4-48e7-93b2-0b8f163a21e2"), "gushtin", null, "mantu", null, "a.jpg", 20m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "Status", "TableId" },
                values: new object[] { new Guid("3f2ae6d0-81ac-422b-840f-042b7faa76d4"), null, 0, null });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("67dd4571-749d-49aa-b0ce-9ac2dd43dfe0"), null, null, "Employee", "Azamjon", "Soliev", "123", null, 0, "admin", "Azam" },
                    { new Guid("8115dc24-7743-422b-bc61-2021d0ee29b4"), null, null, "Employee", "Faridun", "Ikromzoda", "12", null, 0, "admin", "Faridun" },
                    { new Guid("b5941d53-561e-4720-9e70-770c355e19ad"), null, null, "Employee", "nasim", "nasa", "123", null, 0, "admin", "Nasa" }
                });
        }
    }
}
