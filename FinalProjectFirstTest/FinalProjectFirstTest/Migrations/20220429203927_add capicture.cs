using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectFirstTest.Migrations
{
    public partial class addcapicture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Camping_Area_Pictures",
                columns: new[] { "Id", "Camping_AreaId", "Path", "UpdateTime" },
                values: new object[,]
                {
                    { 56, 12, "campingarea50.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 80, 20, "campingarea42.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 79, 19, "campingarea48.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 78, 19, "campingarea45.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 77, 19, "campingarea46.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 76, 18, "campingarea5.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 75, 18, "campingarea44.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 74, 18, "campingarea43.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 73, 17, "campingarea32.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 72, 17, "campingarea31.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 71, 17, "campingarea34.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 70, 16, "campingarea13.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 81, 20, "campingarea49.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 69, 16, "campingarea14.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 67, 15, "campingarea1.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 66, 15, "campingarea2.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 65, 15, "campingarea3.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 64, 14, "campingarea30.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 63, 14, "campingarea29.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 62, 14, "campingarea28.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 61, 13, "campingarea32.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 60, 13, "campingarea31.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 59, 13, "campingarea35.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 58, 12, "campingarea46.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 57, 12, "campingarea45.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 68, 16, "campingarea12.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 82, 20, "campingarea47.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 82);
        }
    }
}
