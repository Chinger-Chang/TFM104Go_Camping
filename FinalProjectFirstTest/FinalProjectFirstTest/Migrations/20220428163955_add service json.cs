using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectFirstTest.Migrations
{
    public partial class addservicejson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Breakfast", "Camping_AreaId", "Canopy", "Canteen", "Dinner", "IsCancel", "Kitchen_Utensils", "Lunch", "Mattress", "Night_Lighting", "No_Equipment", "Outdoor_Tables_Chairs", "Power_Supply", "Public_Refrigerator", "Tent_Equipment", "Wifi" },
                values: new object[,]
                {
                    { 1, true, 1, false, true, false, true, true, false, true, true, false, false, true, false, false, true },
                    { 18, true, 18, false, false, true, false, true, true, true, false, false, false, true, false, false, false },
                    { 17, false, 17, false, true, false, false, false, true, false, true, true, true, false, false, false, false },
                    { 16, false, 16, false, false, false, true, false, true, false, false, true, true, true, true, false, true },
                    { 15, false, 15, false, false, true, false, true, false, false, true, true, false, false, true, false, false },
                    { 14, true, 14, false, false, true, false, false, false, true, false, false, false, true, false, false, true },
                    { 13, true, 13, true, false, true, false, false, false, true, false, false, false, true, false, true, false },
                    { 12, true, 12, false, false, true, true, false, false, true, true, false, false, false, false, true, false },
                    { 11, true, 11, false, false, true, false, true, false, true, false, false, false, true, false, false, true },
                    { 10, false, 10, false, true, false, true, false, false, false, false, true, true, true, true, false, true },
                    { 9, true, 9, false, true, true, false, true, false, false, false, true, false, false, false, false, true },
                    { 8, true, 8, false, false, true, false, true, true, true, false, false, false, false, false, false, true },
                    { 7, true, 7, false, false, false, true, true, false, false, false, true, false, true, false, false, true },
                    { 6, true, 6, true, false, false, true, false, true, false, false, true, false, true, false, true, false },
                    { 5, true, 5, false, false, true, true, true, true, true, false, false, false, false, false, false, true },
                    { 4, true, 4, false, false, true, false, false, false, true, true, false, false, false, true, false, true },
                    { 3, false, 3, false, false, true, false, true, true, false, false, true, false, true, false, false, false },
                    { 2, true, 2, true, false, false, false, false, true, false, false, true, false, true, false, true, false },
                    { 19, true, 19, false, false, true, false, false, false, true, false, true, false, true, true, false, true },
                    { 20, true, 20, false, false, true, false, false, true, false, false, false, false, true, true, false, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
