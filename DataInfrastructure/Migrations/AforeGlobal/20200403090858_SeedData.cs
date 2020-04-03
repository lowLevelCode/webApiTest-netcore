using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webApiTest.DataInfrastructure.Migrations.AforeGlobal
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Post",
                table: "Post");

            migrationBuilder.RenameTable(
                name: "Post",
                newName: "post");

            migrationBuilder.AddPrimaryKey(
                name: "PK_post",
                table: "post",
                column: "Id");

            migrationBuilder.InsertData(
                table: "post",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 4, 3, 2, 8, 57, 777, DateTimeKind.Local).AddTicks(3934), "Post 1" },
                    { 2, new DateTime(2020, 4, 3, 2, 8, 57, 782, DateTimeKind.Local).AddTicks(2106), "Post 2" },
                    { 3, new DateTime(2020, 4, 3, 2, 8, 57, 782, DateTimeKind.Local).AddTicks(2184), "Post 3" },
                    { 4, new DateTime(2020, 4, 3, 2, 8, 57, 782, DateTimeKind.Local).AddTicks(2196), "Post 4" },
                    { 5, new DateTime(2020, 4, 3, 2, 8, 57, 782, DateTimeKind.Local).AddTicks(2202), "Post 5" },
                    { 6, new DateTime(2020, 4, 3, 2, 8, 57, 782, DateTimeKind.Local).AddTicks(2209), "Post 6" },
                    { 7, new DateTime(2020, 4, 3, 2, 8, 57, 782, DateTimeKind.Local).AddTicks(2215), "Post 7" },
                    { 8, new DateTime(2020, 4, 3, 2, 8, 57, 782, DateTimeKind.Local).AddTicks(2222), "Post 8" },
                    { 9, new DateTime(2020, 4, 3, 2, 8, 57, 782, DateTimeKind.Local).AddTicks(2228), "Post 9" },
                    { 10, new DateTime(2020, 4, 3, 2, 8, 57, 782, DateTimeKind.Local).AddTicks(2235), "Post 10" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_post",
                table: "post");

            migrationBuilder.DeleteData(
                table: "post",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "post",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "post",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "post",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "post",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "post",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "post",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "post",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "post",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "post",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.RenameTable(
                name: "post",
                newName: "Post");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Post",
                table: "Post",
                column: "Id");
        }
    }
}
