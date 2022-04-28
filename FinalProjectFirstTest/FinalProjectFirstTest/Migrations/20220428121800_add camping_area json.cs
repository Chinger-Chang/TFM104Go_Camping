using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectFirstTest.Migrations
{
    public partial class addcamping_areajson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Camping_Areas",
                columns: new[] { "Id", "Address", "AuditDescription", "Description", "IsAudit", "Name", "Phone", "Region", "SellerId", "UpdateTime" },
                values: new object[,]
                {
                    { 1, "新竹縣五峰鄉花園村6鄰121之5號", null, "大圓山露營區位於靠海的營位，有許多樹可以遮蔽陽光，右手邊則有搭建遮雨棚以及水泥屋和竹屋(位於水泥屋後方)，提供不同的住宿選擇，設備基本上也是以簡單為主。 往左邊望去就可以看到墾丁的知名景點之一的船帆石，最右邊便是鵝鑾鼻公園，晚上可以明顯看到鵝鑾鼻燈塔的燈光", true, "大海露營區", "0315-045-844", 5, 1, new DateTime(2022, 4, 13, 8, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 18, "高雄市六龜區(台20線71K處)", null, "南橫2071農場，位於荖濃往甲仙南橫公路直瀨溪旁，群山環繞，氣候宜人，空氣清新，環境清幽，最適合整天忙錄於工作與想遠離塵囂及愛好露營活動朋友的最佳場地。", true, "戀戀南橫2071露營區", "0912-693-503", 12, 5, new DateTime(2022, 4, 21, 23, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 17, "苗栗縣泰安鄉大興村５鄰47之6號", null, "游老闆的經營理念：親切服務，不超收！在這裡大家都是遊牧民族，我們為露客打造露營該有的環境；帳貼帳、夜市情景不在這裡。", true, "遊牧民族露營區", "0912-850-330", 5, 4, new DateTime(2022, 4, 20, 23, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 16, "屏東縣恆春鎮鵝鑾里船帆路999-1號", null, "沒有華麗人工美，而執意走自己步調自然風，四面環山，好似被山林擁抱著的幸福，享受大自然，小而美歡迎光臨大東田", true, "大東田露營區", "0921-612-597", 13, 4, new DateTime(2022, 4, 19, 23, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 15, "新竹縣五峰鄉茅圃產業道路", null, "【巴棍杉林】擁有超美獨特山陵線環繞、雲海 堪稱白蘭之最的景色，秋冬雲海旺季可賞大景、營區的草皮柔軟、營區廣闊 原生大樹遮陰 適合新手露友、三代同行！", true, "巴棍杉林", "0910-170-544", 4, 4, new DateTime(2022, 4, 17, 23, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 14, "桃園市復興區12號1", null, "露營區草地大約是500坪的空間, 整個園區大概是1500坪空間, 區內大樹林立, 四面青山環繞, 優美僻靜, 後臨北勢溪可以戲水玩樂, 園內景觀視野遼闊, 適合三五好友群聚, 享受悠閒、寧靜的露營時光。", true, "山豬王露營區", "0915-012-889", 3, 3, new DateTime(2022, 4, 15, 23, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 13, "桃園市復興區義盛里6鄰62號和平橋後左轉約400公尺處", null, "位於小烏來風景區，以森林和瀑布為景點的義盛部落，隱身於部落裡的宇內溪谷旁，木河谷，二十年櫸樹，五十年老田，心靈沉靜的小溪谷，​歡迎您親自蒞臨感受。", true, "木河谷", "0925-312-956", 3, 3, new DateTime(2022, 4, 14, 23, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 12, "桃園市復興區奎輝里嘎色鬧7鄰2號", "房間資訊不完整，照片請多加。", "嘎色鬧意指「最角落的地方」，是神給遷徙時的泰雅族人恩典之地,如「蜻蜓」逐水繁延其後代佇築於此，與大地共存。 兩年前的一場風雨摧不斷族人堅守家園與攜手重建的心，「蜻蜓營區」就是營主一家用雙手見證他們堅守家園再造神所賜的新天新地。", false, "蜻蜓露營區-嘎色鬧", "0939-523-829", 3, 3, new DateTime(2022, 4, 25, 23, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 11, "桃園市復興區高義里7鄰色霧鬧10-16號", null, "松野農園露營區每到5、6月份繡球花季，營地有漂亮的繡球花可以觀賞，白天雲海雲瀑，夜晚微風陣陣看著絕美夜景是件多浪漫的事。", true, "松野農園露營區", "0963-123-251", 3, 2, new DateTime(2022, 4, 24, 23, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 10, "新北市平溪區靜安路三段391號-7", null, "是個適合親子露營、親近大自然的好地方。近市郊卻能遠離塵囂，可以靜靜聆聽潺潺的流水聲，亦可呼吸森林的清新。給孩子們一個最自然的玩耍空間，也給自己一個最放鬆的休息地方。", true, "十分自然露營區", "0936-175-763", 1, 2, new DateTime(2022, 4, 22, 23, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 9, "南投縣埔里鎮福長路260號", null, "位於南投縣埔里鎮，周邊即是福興溫泉，更是在能高瀑布的下方，絕佳的地理位置讓您充分感受到大自然最純粹的洗禮，無光害的環境在入夜後便可望見點點繁星佈滿天際，璀璨浪漫的景緻總令人心醉，而夏季時光亦可看見成群的螢火蟲在草叢間嬉戲。", true, "山野星空親子露營區", "0968-605-609", 8, 2, new DateTime(2022, 4, 21, 23, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 8, "365苗栗縣泰安鄉泰安士林國小後依天晴指標走", null, "位於苗栗泰安山上的天晴野舍，是一處具有特色的露營區，整個營地座落的位置寧靜、舒適，且面向大安溪遼闊景緻，坐在營位上可以感受放空的心境。 若有機會可以遇見太陽霞光、琉璃光、雲海等漂亮景色。", true, "山晴野舍", "0923-345-123", 5, 2, new DateTime(2022, 4, 20, 23, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 7, "311新竹縣五峰鄉和平部落", "照片不清楚，露營區搭建好才能通過。", "駛入蜿蜒的鄉間小徑，遠離塵囂與感受寧靜的自然美景。 森林步道感受杉林芬多精的滋潤、蟲鳴鳥叫的交響樂，體驗山林的奇妙旅程。", false, "戈巴侖森林露營區", "0975-595-131", 4, 2, new DateTime(2022, 4, 16, 23, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 6, "No.305-1號,五峰鄉新竹縣311", null, "四季露營區右邊是白蘭部落，全台最高的樂山基地及雪霸國家公園; 面向中央山脈遠眺雪山北峰等三千公尺以上百岳，正下方是清泉風景區", true, "四季露營區", "0945-112-340", 4, 2, new DateTime(2022, 4, 12, 23, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 5, "新竹縣尖石鄉梅花村9鄰242-6號", null, "起初休閒露營區開箱體驗！位在新竹尖石深山林間，營區內還有茂密的杉木林，漫步於林間的步道享受芬多精和蓊鬱美景，山坡邊的營地更能 180 度遠眺層巒疊嶂，值得前往紮營體驗。", true, "起初休閒露營區", "0965-312-713", 4, 1, new DateTime(2022, 4, 15, 23, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 4, "屏東縣萬巒鄉光明路42-10號", null, "夢露露營空間位於屏東萬巒鄉，鄰近萬金聖母聖堂，營區不僅可以自搭帳篷，還提供了免裝備服務，讓露營新手能輕鬆體驗露營，設有戲水池、沙坑、大草地讓孩子有很棒的活動空間，大人放鬆小孩放電，很適合親朋好友一同享樂。", true, "夢露露營空間", "0927-858-657", 13, 1, new DateTime(2022, 4, 23, 23, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 3, "高雄市六龜區新發里和平路305-2號", "照片太模糊,敘述請在詳盡一些。", "位於高雄六龜的「陽光綠地水世界露營區」在一望無盡的山水自然環境中，遠離都市的塵囂紛擾在寧靜的大自然氣氛中，感受那最純粹的露營區風景！", false, "六龜陽光綠地水世界露營區", "0963-459-755", 12, 1, new DateTime(2022, 4, 17, 23, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 2, "南投縣魚池鄉投69-3鄉道555號", null, "翠林農場海拔750多公尺，得天獨厚的天然環境，兩面環山，還有青翠的綠地、豐富有趣生態導覽，來露營的朋友還可以規劃螢火蟲導覽、野溪導覽，行程好豐富。", true, "翠林農場", "0945-140-341", 8, 1, new DateTime(2022, 4, 14, 11, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 19, "宜蘭縣冬山鄉小埤五路331號", null, "希望之丘休閒農場，可以採果和體驗療育香草及花卉帶來的放鬆心靈，也可以嘗試農業體驗及生態之旅，來感受大自然裡的生態與奧妙。還可以露營、夜間觀星及享受宜蘭在地的美食饗宴。", true, "希望之丘露營區", "0965-257-713", 14, 5, new DateTime(2022, 4, 23, 23, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) },
                    { 20, "宜蘭縣大同鄉泰雅路二段92巷99-1號", null, "關於營區【營業時間】進場時間：當日上午10：00以後/退場時間：次日中午12：00以前預訂(星期五)二天一夜露營，請於星期六上午11:00前離場，以提供星期六訂位者使用，造成不便敬請見諒。 連續假日營地紮營時間為下午1點至隔日中午12點，以供下位紮營者使用。 週五(或前一晚) 提前進場 (限隔日續住者) 18:00~22:00 可入營，酌收每帳500元(現場收費) ，18:00前到場，以整日收費計算，請於23:00前搭營完成，避免打擾已就寢露友。請於露營日2天前電話聯絡0922-157971營主確認是否有營位。連續假日期間、星期六晚上不提供夜衝服務", true, "沐野露營區", "0922-157-971", 14, 5, new DateTime(2022, 4, 24, 23, 14, 33, 862, DateTimeKind.Unspecified).AddTicks(673) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Camping_Areas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Camping_Areas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Camping_Areas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Camping_Areas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Camping_Areas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Camping_Areas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Camping_Areas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Camping_Areas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Camping_Areas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Camping_Areas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Camping_Areas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Camping_Areas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Camping_Areas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Camping_Areas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Camping_Areas",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Camping_Areas",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Camping_Areas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Camping_Areas",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Camping_Areas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Camping_Areas",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
