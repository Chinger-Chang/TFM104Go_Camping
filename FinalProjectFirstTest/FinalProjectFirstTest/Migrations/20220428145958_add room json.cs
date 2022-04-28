using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectFirstTest.Migrations
{
    public partial class addroomjson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Camping_AreaId", "Count", "Description", "Name", "Price_Of_Weekdays", "Price_Of_Weekends", "RoomType" },
                values: new object[,]
                {
                    { 1, 1, 5, "含衛浴(共 1 間),可加至6人,屋頂專屬露台可搭帳野餐,附冷暖空調,需自備床墊、枕頭、棉被,需自備盥洗用具等個人用品(牙膏、牙刷、浴巾、毛巾)。", "溫暖小木屋", 1000m, 1100m, 2 },
                    { 20, 9, 6, "本園區禁止攜帶寵物入場", "狄俄尼索斯", 1289m, 1450m, 3 },
                    { 19, 8, 9, "室內附冷氣，獨立衛浴", "亞瑞士", 2000m, 2500m, 4 },
                    { 18, 7, 6, "農場自搭帳每帳一車一帳，每帳人數 4 人。不含早餐。可於現場加購。", "海斯堤亞", 780m, 1380m, 9 },
                    { 17, 7, 8, "館內全面禁菸，違反者視情節輕重，將有可能請您退宿(住宿費用將不退還)，感謝您共同維護住宿品質。", "阿洛伊代", 1700m, 1800m, 5 },
                    { 16, 7, 3, "室內營位不含衛浴,附枕頭、棉被、冷氣,不含早餐,需自備個人盥洗用品,園區禁止攜帶寵物,園區禁止吸菸 包場可容納28人,多1位加收清潔費300元(現場收費)", "普羅米修斯", 1500m, 1800m, 7 },
                    { 15, 6, 6, "飯店不提供加床。", "宙斯", 800m, 1300m, 1 },
                    { 14, 6, 6, "室內(共有6間) 無衛浴 提供冷暖氣 不可攜帶寵物入住 附沐浴乳、洗髮乳，寢具 進場時間：當日下午3：00後離場時間：次日上午11：00以前", "波塞頓", 900m, 1250m, 11 },
                    { 13, 6, 3, "此區開放車邊帳、車頂帳及睡車上的營友預訂", "阿波羅", 750m, 1200m, 4 },
                    { 12, 6, 5, "為維護環境安寧及其他住客權益，請勿在園區或房間內大聲喧嘩。", "雅典娜", 800m, 1350m, 8 },
                    { 11, 6, 3, "附冷暖氣、床墊、棉被、枕頭、共用大客廳。一棟限14位，超過一人加收600元。(現場收費)。進場時間:當日下午14:00以後退場時間：次日上午11:00以前。下午兩點以前為餐飲營業時間，提早入園加收1000元。 夜衝時間：18：00～22：00之間，不接受提早或延遲，如攜帶寵物入場，酌收清潔費300元隻。", "維納斯", 600m, 1250m, 2 },
                    { 10, 5, 5, "為維護環境安寧及其他住客權益，請勿在園區或房間內大聲喧嘩。", "北冕座", 2000m, 2500m, 3 },
                    { 9, 4, 5, "為維護住宿品質，夜間請保持輕聲細語。", "鯨魚座", 1450m, 2200m, 10 },
                    { 8, 3, 7, "飯店不提供加床。", "牡羊座", 1200m, 1600m, 9 },
                    { 7, 2, 5, "鑰匙遺失賠償費用: TWD 500。", "天鷹座", 800m, 1200m, 7 },
                    { 6, 2, 8, "館內全面禁菸，違反者視情節輕重，將有可能請您退宿(住宿費用將不退還)，感謝您共同維護住宿品質。", "異國風情奢華帳", 1350m, 1800m, 13 },
                    { 5, 1, 3, "為響應環保，鼓勵您自備牙刷。", "普羅旺斯", 1100m, 1750m, 2 },
                    { 4, 1, 2, "室內附冷氣，獨立衛浴", "異國風情奢華帳", 800m, 1500m, 14 },
                    { 3, 1, 3, "本園區禁止攜帶寵物入場", "八人雅房", 1250m, 1800m, 8 },
                    { 2, 1, 6, "室內含衛浴(共2間),提供冷氣,提供洗髪精/沐浴乳、棉被、枕頭、免洗牙刷/牙膏", "森與夢", 1000m, 1200m, 4 },
                    { 21, 10, 6, "室內含衛浴(共2間),提供冷氣,提供洗髪精/沐浴乳、棉被、枕頭、免洗牙刷/牙膏", "赫爾墨斯", 900m, 1550m, 13 },
                    { 22, 11, 3, "為維護環境安寧及其他住客權益，請勿在園區或房間內大聲喧嘩。", "異國風情奢華帳", 890m, 1290m, 14 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22);
        }
    }
}
