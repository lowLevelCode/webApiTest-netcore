using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webApiTest.DataInfrastructure.Migrations.AforeGlobal
{
    public partial class SeedData_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "post",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 3, 2, 17, 25, 777, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "post",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 3, 2, 17, 25, 782, DateTimeKind.Local).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "post",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 3, 2, 17, 25, 782, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "post",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 3, 2, 17, 25, 782, DateTimeKind.Local).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "post",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 3, 2, 17, 25, 782, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "post",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 3, 2, 17, 25, 782, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "post",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 3, 2, 17, 25, 782, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "post",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 3, 2, 17, 25, 782, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "post",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 3, 2, 17, 25, 782, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "post",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 3, 2, 17, 25, 782, DateTimeKind.Local).AddTicks(7676));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "post",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 3, 2, 8, 57, 777, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "post",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 3, 2, 8, 57, 782, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "post",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 3, 2, 8, 57, 782, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "post",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 3, 2, 8, 57, 782, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "post",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 3, 2, 8, 57, 782, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "post",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 3, 2, 8, 57, 782, DateTimeKind.Local).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "post",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 3, 2, 8, 57, 782, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "post",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 3, 2, 8, 57, 782, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "post",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 3, 2, 8, 57, 782, DateTimeKind.Local).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "post",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 3, 2, 8, 57, 782, DateTimeKind.Local).AddTicks(2235));
        }
    }
}
