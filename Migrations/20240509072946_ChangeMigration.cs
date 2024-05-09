using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restaurant_Site.Migrations
{
    /// <inheritdoc />
    public partial class ChangeMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Tables_TableId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_TableId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("678bffca-8c0f-4f61-95cd-109d6362d18b"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("bc42659c-36bd-4d65-ba19-b6175d8260e3"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d2a4583a-f7ba-4716-9b91-6b2cac9d3627"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b959f23-70ec-4c1b-9315-76033a505bc2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fae289b9-a601-4e75-8eba-bfe14bd02912"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("c35ffad2-fb84-4956-b12f-d25aa94f4521"));

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("0983a0f6-25e0-4b30-a792-28de31e5a180"), "Khujand", "92-677-77-77", "Employee", "Azamjon", "Soliev", "123", null, 0, "admin", "Azam" },
                    { new Guid("55c98a29-3f79-4518-b3a2-3749fe564de2"), "Asht", "92-977-77-77", "Employee", "Faridun", "Ikromzoda", "12", null, 0, "admin", "Faridun" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Role", "Username", "customerStatus" },
                values: new object[] { new Guid("e41ecb0c-ca5e-4aa4-a4b6-e9aef45c8c57"), "Dushanbe", "92-999-99-99", "Customer", "Azizjon", "Azizov", "client1", null, "client", "Aziz", 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "DishType", "HolderId", "Name", "Photo", "Price", "Status" },
                values: new object[,]
                {
                    { new Guid("5c8f637e-6547-4038-b237-f6a6b8d21654"), "gushtin", 0, new Guid("00000000-0000-0000-0000-000000000000"), "mantu", "a.jpg", 20.0, 0 },
                    { new Guid("dcdb5e3a-f8dc-48b5-8843-635e03570ec6"), "ЯК ба як", 0, new Guid("00000000-0000-0000-0000-000000000000"), "Палов", "palov.jpg", 100.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "Capacity" },
                values: new object[] { new Guid("53c4a838-6166-4756-9229-ebb173b80718"), "1" });

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_Orders_Id",
                table: "Tables",
                column: "Id",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Orders_Id",
                table: "Tables");

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("0983a0f6-25e0-4b30-a792-28de31e5a180"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("55c98a29-3f79-4518-b3a2-3749fe564de2"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e41ecb0c-ca5e-4aa4-a4b6-e9aef45c8c57"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c8f637e-6547-4038-b237-f6a6b8d21654"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcdb5e3a-f8dc-48b5-8843-635e03570ec6"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("53c4a838-6166-4756-9229-ebb173b80718"));

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("678bffca-8c0f-4f61-95cd-109d6362d18b"), "Khujand", "92-677-77-77", "Employee", "Azamjon", "Soliev", "123", null, 0, "admin", "Azam" },
                    { new Guid("bc42659c-36bd-4d65-ba19-b6175d8260e3"), "Asht", "92-977-77-77", "Employee", "Faridun", "Ikromzoda", "12", null, 0, "admin", "Faridun" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Role", "Username", "customerStatus" },
                values: new object[] { new Guid("d2a4583a-f7ba-4716-9b91-6b2cac9d3627"), "Dushanbe", "92-999-99-99", "Customer", "Azizjon", "Azizov", "client1", null, "client", "Aziz", 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "DishType", "HolderId", "Name", "Photo", "Price", "Status" },
                values: new object[,]
                {
                    { new Guid("3b959f23-70ec-4c1b-9315-76033a505bc2"), "gushtin", 0, new Guid("00000000-0000-0000-0000-000000000000"), "mantu", "a.jpg", 20.0, 0 },
                    { new Guid("fae289b9-a601-4e75-8eba-bfe14bd02912"), "ЯК ба як", 0, new Guid("00000000-0000-0000-0000-000000000000"), "Палов", "palov.jpg", 100.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "Capacity" },
                values: new object[] { new Guid("c35ffad2-fb84-4956-b12f-d25aa94f4521"), "1" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TableId",
                table: "Orders",
                column: "TableId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Tables_TableId",
                table: "Orders",
                column: "TableId",
                principalTable: "Tables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
