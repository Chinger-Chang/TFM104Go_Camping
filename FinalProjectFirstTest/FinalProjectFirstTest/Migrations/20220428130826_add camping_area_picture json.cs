using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectFirstTest.Migrations
{
    public partial class addcamping_area_picturejson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Camping_Area_Pictures",
                columns: new[] { "Id", "Camping_AreaId", "Path", "UpdateTime" },
                values: new object[,]
                {
                    { 1, 1, "campingarea1.jpg", new DateTime(2022, 4, 13, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 21, 6, "campingarea15.jpg", new DateTime(2022, 4, 22, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 22, 6, "campingarea23.jpg", new DateTime(2022, 4, 23, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 23, 7, "campingarea42.jpg", new DateTime(2022, 4, 18, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 24, 7, "campingarea46.jpg", new DateTime(2022, 4, 19, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 25, 7, "campingarea47.jpg", new DateTime(2022, 4, 19, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 26, 8, "campingarea32.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 27, 8, "campingarea33.jpg", new DateTime(2022, 4, 21, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 28, 8, "campingarea34.jpg", new DateTime(2022, 4, 22, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 29, 9, "campingarea12.jpg", new DateTime(2022, 4, 23, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 30, 9, "campingarea13.jpg", new DateTime(2022, 4, 23, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 31, 9, "campingarea21.jpg", new DateTime(2022, 4, 24, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 32, 10, "campingarea32.jpg", new DateTime(2022, 4, 25, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 33, 10, "campingarea38.jpg", new DateTime(2022, 4, 25, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 34, 10, "campingarea39.jpg", new DateTime(2022, 4, 26, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 35, 11, "campingarea11.jpg", new DateTime(2022, 4, 16, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 20, 6, "campingarea6.jpg", new DateTime(2022, 4, 22, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 36, 11, "campingarea13.jpg", new DateTime(2022, 4, 17, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 19, 6, "campingarea44.jpg", new DateTime(2022, 4, 21, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 17, 5, "campingarea35.jpg", new DateTime(2022, 4, 19, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 2, 1, "campingarea2.jpg", new DateTime(2022, 4, 14, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 3, 1, "campingarea3.jpg", new DateTime(2022, 4, 15, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 4, 1, "campingarea4.jpg", new DateTime(2022, 4, 18, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 5, 1, "campingarea39.jpg", new DateTime(2022, 4, 18, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 6, 2, "campingarea5.jpg", new DateTime(2022, 4, 19, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 7, 2, "campingarea6.jpg", new DateTime(2022, 4, 19, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 8, 2, "campingarea7.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 9, 3, "campingarea15.jpg", new DateTime(2022, 4, 15, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 10, 3, "campingarea16.jpg", new DateTime(2022, 4, 15, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 11, 3, "campingarea18.jpg", new DateTime(2022, 4, 18, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 12, 4, "campingarea48.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 13, 4, "campingarea49.jpg", new DateTime(2022, 4, 21, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 14, 4, "campingarea50.jpg", new DateTime(2022, 4, 22, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 15, 5, "campingarea31.jpg", new DateTime(2022, 4, 18, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 16, 5, "campingarea32.jpg", new DateTime(2022, 4, 19, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 18, 6, "campingarea43.jpg", new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 37, 11, "campingarea28.jpg", new DateTime(2022, 4, 18, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Camping_Area_Pictures",
                keyColumn: "Id",
                keyValue: 37);
        }
    }
}
