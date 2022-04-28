using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectFirstTest.Migrations
{
    public partial class adddatatocatable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Camping_Area_Pictures",
                columns: new[] { "Id", "Camping_AreaId", "Path", "UpdateTime" },
                values: new object[] { 41, 12, "campingarea28.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) });

            migrationBuilder.InsertData(
                table: "Camping_Area_Pictures",
                columns: new[] { "Id", "Camping_AreaId", "Path", "UpdateTime" },
                values: new object[] { 42, 12, "campingarea27.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) });

            migrationBuilder.InsertData(
                table: "Camping_Area_Pictures",
                columns: new[] { "Id", "Camping_AreaId", "Path", "UpdateTime" },
                values: new object[] { 43, 12, "campingarea29.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 43);
        }
    }
}
