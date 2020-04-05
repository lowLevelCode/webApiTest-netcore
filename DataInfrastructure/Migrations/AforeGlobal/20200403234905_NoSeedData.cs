using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webApiTest.DataInfrastructure.Migrations.AforeGlobal
{
    public partial class NoSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "post",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 4, 3, 2, 17, 25, 777, DateTimeKind.Local).AddTicks(6030), "Post 1" },
                    { 2, new DateTime(2020, 4, 3, 2, 17, 25, 782, DateTimeKind.Local).AddTicks(7526), "Post 2" },
                    { 3, new DateTime(2020, 4, 3, 2, 17, 25, 782, DateTimeKind.Local).AddTicks(7621), "Post 3" },
                    { 4, new DateTime(2020, 4, 3, 2, 17, 25, 782, DateTimeKind.Local).AddTicks(7633), "Post 4" },
                    { 5, new DateTime(2020, 4, 3, 2, 17, 25, 782, DateTimeKind.Local).AddTicks(7640), "Post 5" },
                    { 6, new DateTime(2020, 4, 3, 2, 17, 25, 782, DateTimeKind.Local).AddTicks(7647), "Post 6" },
                    { 7, new DateTime(2020, 4, 3, 2, 17, 25, 782, DateTimeKind.Local).AddTicks(7654), "Post 7" },
                    { 8, new DateTime(2020, 4, 3, 2, 17, 25, 782, DateTimeKind.Local).AddTicks(7661), "Post 8" },
                    { 9, new DateTime(2020, 4, 3, 2, 17, 25, 782, DateTimeKind.Local).AddTicks(7668), "Post 9" },
                    { 10, new DateTime(2020, 4, 3, 2, 17, 25, 782, DateTimeKind.Local).AddTicks(7676), "Post 10" }
                });
        }
    }
}
