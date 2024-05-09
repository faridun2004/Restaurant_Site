using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restaurant_Site.Migrations
{
    /// <inheritdoc />
    public partial class changeInfrastructures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("f09d5684-065a-474a-a798-05c31656e0f3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("941eebbf-5e16-4ebd-9783-88b8d8e6c3bd"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("3974b763-51f0-464e-b34c-7aa8723bb450"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("a535b82e-2f85-40f4-b1b2-e708084a6b30"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d07a6eff-abdf-44ca-a9f0-c5e37e448575"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e3c5cffe-6ae3-4d81-9ca2-0f1e18cccd4e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dd90b3e3-c133-42b0-a509-b2f962f26cbb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0875dc8-d7e1-4f28-8171-80a5d707ad42"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("143ea5f7-8cab-49d8-9bfa-d8b4a277721d"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("3fcd75bb-9b1d-437b-abce-2a83b12ef67c"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("a14be8f3-b712-4d97-bda8-94440cebede4"));

            migrationBuilder.InsertData(
                table: "Menus",
                column: "Id",
                value: new Guid("afa46186-5deb-4ad6-883f-0d247ef83100"));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CretionalDate", "customerId", "status", "tableId" },
                values: new object[] { new Guid("2882ec65-549c-4b4f-83f7-77fef6b1223c"), new DateTime(2024, 5, 5, 18, 57, 31, 262, DateTimeKind.Local).AddTicks(5052), null, 0, null });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("7140b4f1-d0a9-48ec-80e1-bafc14db1fb2"), "Asht", "92-977-77-77", "Employee", "Faridun", "Ikromzoda", "12", null, 0, "admin", "Faridun" },
                    { new Guid("d736831e-623d-413f-bbc3-5391884298d2"), "Arbob", "92-877-77-77", "Employee", "Nasimjon", "Temurov", "123", null, 0, "admin", "Nasa" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Role", "Username", "customerStatus" },
                values: new object[] { new Guid("db15d0c4-b691-4942-9e51-86ff246746ce"), "Dushanbe", "92-999-99-99", "Customer", "Azizjon", "Azizov", "client1", null, "client", "Aziz", 0 });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[] { new Guid("e74fcac2-a8bc-4e63-8852-0647085c4755"), "Khujand", "92-677-77-77", "Employee", "Azamjon", "Soliev", "123", null, 0, "admin", "Azam" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "DishType", "HolderId", "MenuId", "Name", "OrderId", "Photo", "Price", "Status" },
                values: new object[,]
                {
                    { new Guid("1f18eb5f-973e-4183-80f0-57f9195decde"), "gushtin", 0, new Guid("00000000-0000-0000-0000-000000000000"), null, "mantu", null, "a.jpg", 20m, 0 },
                    { new Guid("41bb5799-c109-4571-aa3c-8a76286795fd"), "ЯК ба як", 0, new Guid("00000000-0000-0000-0000-000000000000"), null, "Палов", null, "palov.jpg", 100m, 0 }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "Capacity" },
                values: new object[,]
                {
                    { new Guid("024117ae-1ea4-44bf-a8cd-fe48df1981fd"), "2" },
                    { new Guid("58064d5a-01aa-44c7-9a90-d837f24bbcc8"), "1" },
                    { new Guid("5829c1c3-a923-42ad-93a3-7c01badcbbca"), "3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("afa46186-5deb-4ad6-883f-0d247ef83100"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2882ec65-549c-4b4f-83f7-77fef6b1223c"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("7140b4f1-d0a9-48ec-80e1-bafc14db1fb2"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d736831e-623d-413f-bbc3-5391884298d2"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("db15d0c4-b691-4942-9e51-86ff246746ce"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e74fcac2-a8bc-4e63-8852-0647085c4755"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f18eb5f-973e-4183-80f0-57f9195decde"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("41bb5799-c109-4571-aa3c-8a76286795fd"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("024117ae-1ea4-44bf-a8cd-fe48df1981fd"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("58064d5a-01aa-44c7-9a90-d837f24bbcc8"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("5829c1c3-a923-42ad-93a3-7c01badcbbca"));

            migrationBuilder.InsertData(
                table: "Menus",
                column: "Id",
                value: new Guid("f09d5684-065a-474a-a798-05c31656e0f3"));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CretionalDate", "customerId", "status", "tableId" },
                values: new object[] { new Guid("941eebbf-5e16-4ebd-9783-88b8d8e6c3bd"), new DateTime(2024, 5, 5, 18, 42, 6, 80, DateTimeKind.Local).AddTicks(2397), null, 0, null });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[] { new Guid("3974b763-51f0-464e-b34c-7aa8723bb450"), "Arbob", "92-877-77-77", "Employee", "Nasimjon", "Temurov", "123", null, 0, "admin", "Nasa" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Role", "Username", "customerStatus" },
                values: new object[] { new Guid("a535b82e-2f85-40f4-b1b2-e708084a6b30"), "Dushanbe", "92-999-99-99", "Customer", "Azizjon", "Azizov", "client1", null, "client", "Aziz", 0 });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("d07a6eff-abdf-44ca-a9f0-c5e37e448575"), "Asht", "92-977-77-77", "Employee", "Faridun", "Ikromzoda", "12", null, 0, "admin", "Faridun" },
                    { new Guid("e3c5cffe-6ae3-4d81-9ca2-0f1e18cccd4e"), "Khujand", "92-677-77-77", "Employee", "Azamjon", "Soliev", "123", null, 0, "admin", "Azam" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "DishType", "HolderId", "MenuId", "Name", "OrderId", "Photo", "Price", "Status" },
                values: new object[,]
                {
                    { new Guid("dd90b3e3-c133-42b0-a509-b2f962f26cbb"), "gushtin", 0, new Guid("00000000-0000-0000-0000-000000000000"), null, "mantu", null, "a.jpg", 20m, 0 },
                    { new Guid("e0875dc8-d7e1-4f28-8171-80a5d707ad42"), "ЯК ба як", 0, new Guid("00000000-0000-0000-0000-000000000000"), null, "Палов", null, "palov.jpg", 100m, 0 }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "Capacity" },
                values: new object[,]
                {
                    { new Guid("143ea5f7-8cab-49d8-9bfa-d8b4a277721d"), "1" },
                    { new Guid("3fcd75bb-9b1d-437b-abce-2a83b12ef67c"), "3" },
                    { new Guid("a14be8f3-b712-4d97-bda8-94440cebede4"), "2" }
                });
        }
    }
}
