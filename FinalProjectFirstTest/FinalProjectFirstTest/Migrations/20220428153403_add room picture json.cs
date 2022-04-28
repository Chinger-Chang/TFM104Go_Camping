using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectFirstTest.Migrations
{
    public partial class addroompicturejson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Room_Pictures",
                columns: new[] { "Id", "Path", "RoomId", "UpdateTime" },
                values: new object[,]
                {
                    { 1, "room26.jpg", 1, new DateTime(2022, 4, 13, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 36, "room74.jpg", 12, new DateTime(2022, 4, 17, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 37, "room28.jpg", 13, new DateTime(2022, 4, 18, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 38, "room41.jpg", 13, new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 39, "room42.jpg", 13, new DateTime(2022, 4, 15, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 40, "room87.jpg", 14, new DateTime(2022, 4, 15, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 41, "room88.jpg", 14, new DateTime(2022, 4, 18, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 42, "room89.jpg", 14, new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 43, "room27.jpg", 15, new DateTime(2022, 4, 21, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 44, "room26.jpg", 15, new DateTime(2022, 4, 22, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 45, "room25.jpg", 15, new DateTime(2022, 4, 18, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 46, "room82.jpg", 16, new DateTime(2022, 4, 19, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 47, "room74.jpg", 16, new DateTime(2022, 4, 19, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 48, "room83.jpg", 16, new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 49, "room14.jpg", 17, new DateTime(2022, 4, 21, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 50, "room12.jpg", 17, new DateTime(2022, 4, 22, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 51, "room13.jpg", 17, new DateTime(2022, 4, 22, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 52, "room7.jpg", 18, new DateTime(2022, 4, 23, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 53, "room6.jpg", 18, new DateTime(2022, 4, 18, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 54, "room5.jpg", 18, new DateTime(2022, 4, 19, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 55, "room17.jpg", 19, new DateTime(2022, 4, 19, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 56, "room19.jpg", 19, new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 57, "room20.jpg", 19, new DateTime(2022, 4, 21, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 58, "room51.jpg", 20, new DateTime(2022, 4, 22, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 59, "room52.jpg", 20, new DateTime(2022, 4, 23, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 60, "room53.jpg", 20, new DateTime(2022, 4, 23, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 61, "room6.jpg", 21, new DateTime(2022, 4, 24, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 62, "room4.jpg", 21, new DateTime(2022, 4, 25, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 63, "room5.jpg", 21, new DateTime(2022, 4, 25, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 64, "room2.jpg", 22, new DateTime(2022, 4, 26, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 35, "room73.jpg", 12, new DateTime(2022, 4, 16, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 34, "room72.jpg", 12, new DateTime(2022, 4, 26, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 33, "room53.jpg", 11, new DateTime(2022, 4, 25, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 32, "room52.jpg", 11, new DateTime(2022, 4, 25, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 2, "room27.jpg", 1, new DateTime(2022, 4, 14, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 3, "room28.jpg", 1, new DateTime(2022, 4, 15, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 4, "room37.jpg", 2, new DateTime(2022, 4, 18, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 5, "room38.jpg", 2, new DateTime(2022, 4, 18, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 6, "room39.jpg", 2, new DateTime(2022, 4, 19, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 7, "room72.jpg", 3, new DateTime(2022, 4, 19, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 8, "room73.jpg", 3, new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 9, "room74.jpg", 3, new DateTime(2022, 4, 15, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) }
                });

            migrationBuilder.InsertData(
                table: "Room_Pictures",
                columns: new[] { "Id", "Path", "RoomId", "UpdateTime" },
                values: new object[,]
                {
                    { 10, "room1.jpg", 4, new DateTime(2022, 4, 15, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 11, "room2.jpg", 4, new DateTime(2022, 4, 18, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 12, "room3.jpg", 4, new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 13, "room20.jpg", 5, new DateTime(2022, 4, 21, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 14, "room21.jpg", 5, new DateTime(2022, 4, 22, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 15, "room23.jpg", 5, new DateTime(2022, 4, 18, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 65, "room3.jpg", 22, new DateTime(2022, 4, 16, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 16, "room94.jpg", 6, new DateTime(2022, 4, 19, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 18, "room96.jpg", 6, new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 19, "room63.jpg", 7, new DateTime(2022, 4, 21, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 20, "room65.jpg", 7, new DateTime(2022, 4, 22, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 21, "room66.jpg", 7, new DateTime(2022, 4, 22, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 22, "room89.jpg", 8, new DateTime(2022, 4, 23, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 23, "room90.jpg", 8, new DateTime(2022, 4, 18, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 24, "room91.jpg", 8, new DateTime(2022, 4, 19, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 25, "room97.jpg", 9, new DateTime(2022, 4, 19, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 26, "room98.jpg", 9, new DateTime(2022, 4, 20, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 27, "room99.jpg", 9, new DateTime(2022, 4, 21, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 28, "room27.jpg", 10, new DateTime(2022, 4, 22, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 29, "room28.jpg", 10, new DateTime(2022, 4, 23, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 30, "room30.jpg", 10, new DateTime(2022, 4, 23, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 31, "room51.jpg", 11, new DateTime(2022, 4, 24, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 17, "room95.jpg", 6, new DateTime(2022, 4, 19, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 66, "room4.jpg", 22, new DateTime(2022, 4, 17, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Room_Pictures",
                keyColumn: "Id",
                keyValue: 66);
        }
    }
}
