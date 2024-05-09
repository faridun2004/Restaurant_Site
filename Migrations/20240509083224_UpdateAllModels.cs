using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restaurant_Site.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAllModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customer",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Table",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Tables_TableId1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_TableId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_TableId1",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("3b1a3f3d-be07-4efa-85e4-eed96e4ed666"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("884f20a6-1b98-4b2d-9398-70641301cc3e"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("9b9b599d-c1f7-47e5-a006-52e6184a073b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f7d78fd-2be3-4a5d-9c32-6241bacf5ae9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e155f3c8-6329-4f61-81cb-a05c02117fc7"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("fa438dce-9742-4514-a566-72168881b0c3"));

            migrationBuilder.DropColumn(
                name: "TableId1",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "Capacity",
                table: "Tables",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EditDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "Menus",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Role", "Username", "customerStatus" },
                values: new object[] { new Guid("a93c989b-88b1-4082-a7e4-e9599455ebd8"), "Dushanbe", "92-999-99-99", "Customer", "Azizjon", "Azizov", "client1", null, "client", "Aziz", 0 });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[] { new Guid("e845f5be-5bce-417a-a7c7-c73fc0d49d1d"), "Asht", "92-977-77-77", "Employee", "Faridun", "Ikromzoda", "12", null, 0, "admin", "Faridun" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "DishType", "HolderId", "Name", "Photo", "Price", "Status" },
                values: new object[,]
                {
                    { new Guid("6e875db9-e2fa-4d2d-b4c4-89e51835bbaa"), "gushtin", 0, new Guid("00000000-0000-0000-0000-000000000000"), "mantu", "a.jpg", 20.0, 0 },
                    { new Guid("f0a70921-8cd5-49ef-93fe-a1023c7f833c"), "ЯК ба як", 0, new Guid("00000000-0000-0000-0000-000000000000"), "Палов", "palov.jpg", 100.0, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TableId",
                table: "Orders",
                column: "TableId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Persons_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Tables_TableId",
                table: "Orders",
                column: "TableId",
                principalTable: "Tables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Persons_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Tables_TableId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_TableId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("a93c989b-88b1-4082-a7e4-e9599455ebd8"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e845f5be-5bce-417a-a7c7-c73fc0d49d1d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e875db9-e2fa-4d2d-b4c4-89e51835bbaa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f0a70921-8cd5-49ef-93fe-a1023c7f833c"));

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Menus");

            migrationBuilder.AlterColumn<string>(
                name: "Capacity",
                table: "Tables",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditDate",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<Guid>(
                name: "TableId1",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Role", "Username", "customerStatus" },
                values: new object[] { new Guid("3b1a3f3d-be07-4efa-85e4-eed96e4ed666"), "Dushanbe", "92-999-99-99", "Customer", "Azizjon", "Azizov", "client1", null, "client", "Aziz", 0 });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "ContactInfo", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("884f20a6-1b98-4b2d-9398-70641301cc3e"), "Asht", "92-977-77-77", "Employee", "Faridun", "Ikromzoda", "12", null, 0, "admin", "Faridun" },
                    { new Guid("9b9b599d-c1f7-47e5-a006-52e6184a073b"), "Khujand", "92-677-77-77", "Employee", "Azamjon", "Soliev", "123", null, 0, "admin", "Azam" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "DishType", "HolderId", "Name", "Photo", "Price", "Status" },
                values: new object[,]
                {
                    { new Guid("9f7d78fd-2be3-4a5d-9c32-6241bacf5ae9"), "gushtin", 0, new Guid("00000000-0000-0000-0000-000000000000"), "mantu", "a.jpg", 20.0, 0 },
                    { new Guid("e155f3c8-6329-4f61-81cb-a05c02117fc7"), "ЯК ба як", 0, new Guid("00000000-0000-0000-0000-000000000000"), "Палов", "palov.jpg", 100.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "Capacity" },
                values: new object[] { new Guid("fa438dce-9742-4514-a566-72168881b0c3"), "1" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TableId",
                table: "Orders",
                column: "TableId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TableId1",
                table: "Orders",
                column: "TableId1",
                unique: true,
                filter: "[TableId1] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customer",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Table",
                table: "Orders",
                column: "TableId",
                principalTable: "Tables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Tables_TableId1",
                table: "Orders",
                column: "TableId1",
                principalTable: "Tables",
                principalColumn: "Id");
        }
    }
}
