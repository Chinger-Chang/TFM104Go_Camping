using FinalProjectFirstTest.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FinalProjectFirstTest.Controllers
{
    public class BuyerController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly FinalProjectDbContext _db;
        public BuyerController(IWebHostEnvironment environment, FinalProjectDbContext db)
        {
            _environment = environment;
            _db = db;
        }
        // 買家首頁
        public IActionResult Index()
        {
            return View();
        }
        // 拿首頁資訊
        public List<IndexInfo> getIndexInfo()
        {
            var s = _db.Camping_Areas.Select(x => new IndexInfo
            {
                CampingAreaId = x.Id,
                CampingAreaName = x.Name,
                CampingDes = x.Description,
                PicPath = x.Camping_Area_Pictures.Any() ? x.Camping_Area_Pictures.FirstOrDefault().Path : "", //Reds
                Region = x.Region,
                LowerPrice = Decimal.ToInt32(x.Rooms.Where(y => y.Camping_AreaId == x.Id).OrderBy(z => z.Price_Of_Weekdays).Select(n => n.Price_Of_Weekdays).FirstOrDefault())
            }).ToList();
            return s;
        }
        // 拿 Region
        public object GetDisplayName()
        {
            var a = Region.GetNames<Region>().ToList();
            //a = Enum.GetNames(typeof(Region)).ToList();
            //Console.WriteLine(a);
            //var r = Region.GetValues<Region>();

            return a;
        }
        // 首頁點露營區 ==> 看房型
        [Route("[controller]/[action]/{id}")]
        public IActionResult RoomInfo([FromRoute] int? id)
        {
            if (id != null)
            {
                HttpContext.Session.SetString("caid", id.ToString());
            }
            return View();
        }
        // 拿某露營區的房型資訊
        [HttpGet]
        public RoomInfoViewModel getRoomInfo(RoomInfoViewModel model)
        {
            string caid = HttpContext.Session.GetString("caid");
            int CAid = Convert.ToInt32(caid);

            var hasUserId = User.HasClaim(x => x.Type == "User_Id");

            if (hasUserId)
            {
                int userId = Int32.Parse(User.Claims.FirstOrDefault(x => x.Type == "User_Id").Value);

                var camp = _db.Camping_Areas.Where(x => x.Id == CAid).FirstOrDefault();
                var service = _db.Services.Where(x => x.Camping_AreaId == camp.Id).FirstOrDefault();

                var userFavRoomId = _db.OrderDetails.Where(x => x.UserId == userId && x.Status == Status.Favority).Select(y => y.RoomId).ToList();

                var s = new RoomInfoViewModel
                {
                    UserFavRoomId = userFavRoomId,
                    CAId = camp.Id,
                    CAname = camp.Name,
                    CAaddress = camp.Address,
                    CAphone = camp.Phone,
                    CAdescription = camp.Description,
                    CApicPath = _db.Camping_Area_Pictures.Where(x => x.Camping_AreaId == camp.Id).Select(s => s.Path).ToList(),
                    Wifi = service.Wifi,
                    Breakfast = service.Breakfast,
                    Canopy = service.Canopy,
                    Canteen = service.Canteen,
                    Dinner = service.Dinner,
                    IsCancel = service.IsCancel,
                    Kitchen_Utensils = service.Kitchen_Utensils,
                    Lunch = service.Lunch,
                    Mattress = service.Mattress,
                    Night_Lighting = service.Night_Lighting,
                    No_Equipment = service.No_Equipment,
                    Outdoor_Tables_Chairs = service.Outdoor_Tables_Chairs,
                    Power_Supply = service.Power_Supply,
                    Public_Refrigerator = service.Public_Refrigerator,
                    Tent_Equipment = service.Tent_Equipment,
                    Rooms = _db.Rooms.Where(x => x.Camping_AreaId == camp.Id).Select(z => new Myroom
                    {
                        UserId = userId, // 好像不需要傳userId
                        RoomId = z.Id,
                        RoomName = z.Name,
                        //RoomType = r.RoomType.GetType().GetMember(r.RoomType.ToString()).First().GetCustomAttribute<DisplayAttribute>().GetName(),
                        RoomType = z.RoomType.GetType().GetMember(z.RoomType.ToString()).First().GetCustomAttribute<DisplayAttribute>().GetName(),
                        PriceOfWeekDay = z.Price_Of_Weekdays,
                        Room_Path = _db.Room_Pictures.Where(y => y.RoomId == z.Id).Select(s => s.Path).ToList(),
                        Room_Des = z.Description,
                        RoomStatus = _db.OrderDetails.Where(n => n.UserId == userId && n.RoomId == z.Id && n.Status == Status.Favority).Select(c => c.Status.ToString()).FirstOrDefault()
                    }).ToList()
                };
                return s;
            }
            else
            {
                var camp = _db.Camping_Areas.Where(x => x.Id == CAid).FirstOrDefault();
                var service = _db.Services.Where(x => x.Camping_AreaId == camp.Id).FirstOrDefault();

                //var userFavRoomId = _db.OrderDetails.Where(x => x.UserId == userId && x.Status == Status.Favority).Select(y => y.RoomId).ToList();

                var s = new RoomInfoViewModel
                {
                    //UserFavRoomId = userFavRoomId,
                    CAId = camp.Id,
                    CAname = camp.Name,
                    CAaddress = camp.Address,
                    CAphone = camp.Phone,
                    CAdescription = camp.Description,
                    CApicPath = _db.Camping_Area_Pictures.Where(x => x.Camping_AreaId == camp.Id).Select(s => s.Path).ToList(),
                    Wifi = service.Wifi,
                    Breakfast = service.Breakfast,
                    Canopy = service.Canopy,
                    Canteen = service.Canteen,
                    Dinner = service.Dinner,
                    IsCancel = service.IsCancel,
                    Kitchen_Utensils = service.Kitchen_Utensils,
                    Lunch = service.Lunch,
                    Mattress = service.Mattress,
                    Night_Lighting = service.Night_Lighting,
                    No_Equipment = service.No_Equipment,
                    Outdoor_Tables_Chairs = service.Outdoor_Tables_Chairs,
                    Power_Supply = service.Power_Supply,
                    Public_Refrigerator = service.Public_Refrigerator,
                    Tent_Equipment = service.Tent_Equipment,
                    Rooms = _db.Rooms.Where(x => x.Camping_AreaId == camp.Id).Select(z => new Myroom
                    {
                        //UserId = userId, // 好像不需要傳userId
                        RoomId = z.Id,
                        RoomName = z.Name,
                        //RoomType = r.RoomType.GetType().GetMember(r.RoomType.ToString()).First().GetCustomAttribute<DisplayAttribute>().GetName(),
                        RoomType = z.RoomType.GetType().GetMember(z.RoomType.ToString()).First().GetCustomAttribute<DisplayAttribute>().GetName(),
                        PriceOfWeekDay = z.Price_Of_Weekdays,
                        Room_Path = _db.Room_Pictures.Where(y => y.RoomId == z.Id).Select(s => s.Path).ToList(),
                        Room_Des = z.Description,
                        RoomStatus = "noUserId"
                    }).ToList()
                };
                return s;
            }
        }
        // 收藏
        [HttpPost]
        public bool getFavoriteInfo([FromBody] FavoriteInfoViewModel model)
        {
            int userId = Int32.Parse(User.Claims.FirstOrDefault(x => x.Type == "User_Id").Value);
            var a = _db.OrderDetails.Where(x => x.UserId == userId && x.RoomId == model.favRoomId && x.Status == Status.Favority).FirstOrDefault();

            if (a == null) // 此roomid沒有在此user的收藏裡 ==> 才可收藏
            {
                _db.OrderDetails.Add(new Models.OrderDetail()
                {
                    UserId = userId,
                    RoomId = model.favRoomId,
                    CreateDate = DateTime.Now,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    Status = Status.Favority,
                    Name = "FackName",
                    Phone = "FackPhone"
                });
                _db.SaveChanges();
                return true;
            }
            else
            {
                _db.Remove(a);
                _db.SaveChanges();
                return false;
            }

        }
        public IActionResult MyFav()
        {
            return View();
        }
        public List<Myroom> GetFavorite()
        {
            var userId = Int32.Parse(User.Claims.FirstOrDefault(x => x.Type == "User_Id").Value);


            //var userFavRoomId = _db.OrderDetails.Where(x => x.UserId == userId && x.Status == Status.Favority).Select(y => y.RoomId).ToList();
            var s = from od in _db.OrderDetails.Where(x => x.UserId == userId && x.Status == Status.Favority)
                    join r in _db.Rooms on od.RoomId equals r.Id
                    select new Myroom
                    {
                        RoomId = r.Id,
                        CAId = r.Camping_AreaId,
                        CAName = r.Camping_Area.Name,
                        RoomName = r.Name,
                        Room_Des = r.Description,
                        RoomType = r.RoomType.GetType().GetMember(r.RoomType.ToString()).First().GetCustomAttribute<DisplayAttribute>().GetName(),
                        PriceOfWeekDay = r.Price_Of_Weekdays,
                        Room_Path = _db.Room_Pictures.Where(y => y.RoomId == r.Id).Select(s => s.Path).ToList(),
                        RoomStatus = od.Status.ToString()
                    };


            //RoomType = r.RoomType.GetType().GetMember(r.RoomType.ToString()).First().GetCustomAttribute<DisplayAttribute>().GetName(),
            //from od in _db.OrderDetails.Where(x => x.UserId == userId && x.Status != Status.Cancel && x.EndDate >= DateTime.Now)
            //join r in _db.Rooms on od.RoomId equals r.Id
            //join ca in _db.Camping_Areas on r.Camping_AreaId equals ca.Id
            //orderby od.CreateDate descending
            //select new OrderDetailViewModel
            return s.ToList();

        }
        //------------------------------------------
        // 買家 註冊+登入
        public IActionResult register()
        {
            return View();
        }
        // 註冊 ==> 確認帳號使否用過
        [HttpPost]
        public bool registerCheck(UserViewModel model)
        {
            var user = _db.Users.FirstOrDefault(x => x.Email == model.Email);
            if (user == null)
            {
                // 此帳號可使用

                // 加鹽加密
                string salt = Guid.NewGuid().ToString();
                byte[] passwordAndSaltBytes = System.Text.Encoding.UTF8.GetBytes(model.Password + salt);
                byte[] hashBytes = new System.Security.Cryptography.SHA256Managed().ComputeHash(passwordAndSaltBytes);
                string hashString = Convert.ToBase64String(hashBytes);

                _db.Users.Add(new Models.User()
                {
                    Email = model.Email,
                    Password = hashString,
                    Salt = salt,
                    Name = model.Name,
                    Phone = model.Phone,
                    CreateDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                });
                _db.SaveChanges();
                return true;
            }
            else
            {
                // 此帳號已被使用
                return false;
            }
        }
        // 登入 ==> 確認是否有這位使用者
        public async Task<IActionResult> LoginCheck(LoginViewModel model)
        {
            var user = _db.Users.FirstOrDefault(x => x.Email == model.Email);

            if (user == null)
            {
                // 無此使用者
                return Ok("400");
            }
            else
            {
                // 有此使用者
                var thisUserSalt = user.Salt;
                byte[] passwordAndSaltBytes = System.Text.Encoding.UTF8.GetBytes(model.Password + thisUserSalt);
                byte[] hashBytes = new System.Security.Cryptography.SHA256Managed().ComputeHash(passwordAndSaltBytes);
                string hashString = Convert.ToBase64String(hashBytes);

                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name,user.Name),
                    new Claim(ClaimTypes.Email,user.Email),
                    new Claim("User_Id",user.Id.ToString()),
                    new Claim(ClaimTypes.Role,"User")
                };
                var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimPrincipal = new ClaimsPrincipal(claimIdentity);
                await HttpContext.SignInAsync(claimPrincipal);

                if (user.IsMailConfirm != false)
                {
                    if(user.Password == hashString)
                    {
                        // 有此使用者 且 密碼加鹽雜湊後 與資料庫password欄位一樣
                        
                        //return RedirectToAction("Index","Home");
                        return Json(Url.Action("Index", "Buyer"));
                    }
                    else
                    {
                        // 有此使用者 但密碼錯誤
                        return Ok("401");
                    }
                }
                else
                {
                    // 有此使用者 但沒驗證
                    return Ok("402");
                }
            }
        }

        public IActionResult Facebook_Login()
        {
            var fb = new AuthenticationProperties()
            {
                RedirectUri = Url.Action("Facebook_Response")
            };
            return Challenge(fb, FacebookDefaults.AuthenticationScheme);
        }

        public async Task<IActionResult> Facebook_ResponseAsync()
        {
            string email = "";
            var response = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            var data = response.Principal.Claims.Select(x => new
            {
                x.Type,
                x.Value,
                x.Issuer,
                x.OriginalIssuer
            });

            foreach (var item in data)
            {
                if (item.Type.ToLower().Contains("emailaddress"))
                {
                    email = item.Value;
                }
            }

            var seller = _db.Users.FirstOrDefault(x => x.Email == email);
            if (seller == null)
            {
                //此帳號可使用
                _db.Users.Add(new User()
                {
                    Email = email,
                    CreateDate = DateTime.Now,
                    IsMailConfirm = true
                });
                _db.SaveChanges();
            }
            Console.WriteLine(email);

            var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Email,email),
                        new Claim(ClaimTypes.Role,"User"),

                    };

            var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var claimPrincipal = new ClaimsPrincipal(claimIdentity);
            await HttpContext.SignInAsync(claimPrincipal);
            //return RedirectToAction("login", "Account");

            return RedirectToAction("Index", "Buyer");
        }

        //[Route("google-login")]
        public IActionResult Google_Login()
        {
            //跟Google拿資料
            var properties = new AuthenticationProperties { RedirectUri = Url.Action("Google_Response") };

            return Challenge(properties, GoogleDefaults.AuthenticationScheme);
        }

        //[Route("google-response")]
        public async Task<IActionResult> Google_Response()
        {
            string email = "";
            //拿回來的資料 做接收 並作為登入依據
            var response = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            var data = response.Principal.Identities.FirstOrDefault()
                .Claims.Select(claim => new
                {
                    claim.Issuer,
                    claim.OriginalIssuer,
                    claim.Type,
                    claim.Value
                });

            foreach (var item in data)
            {
                if (item.Type.ToLower().Contains("emailaddress"))
                {
                    email = item.Value;
                }
            }


            var seller = _db.Users.FirstOrDefault(x => x.Email == email);
            if (seller == null)
            {
                //此帳號可使用
                _db.Users.Add(new User()
                {
                    Email = email,
                    CreateDate = DateTime.Now,
                    IsMailConfirm = true
                });
                _db.SaveChanges();
            }
            Console.WriteLine(email);
            //Console.WriteLine(name);

            var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Email,email),
                        new Claim(ClaimTypes.Role,"User")
                    };

            var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var claimPrincipal = new ClaimsPrincipal(claimIdentity);
            await HttpContext.SignInAsync(claimPrincipal);
            //return RedirectToAction("login", "Account");

            return RedirectToAction("Index", "Buyer");

            //return Json(claims);
        }
        //--------------------------------------------------------------------------
        // 訂房
        [Route("[controller]/[action]/{rid}")]
        public IActionResult reservation([FromRoute] int? rid)
        {
            if (rid != null)
            {
                HttpContext.Session.SetString("rid", rid.ToString());
            }
            return View();
        }
        // 傳 roomID + room平日/假日價錢
        public getRoomIdandPrice getRoomIdtoView(getRoomIdandPrice model)
        {
            // 拿roomId
            string rid = HttpContext.Session.GetString("rid");
            int Rid = Convert.ToInt32(rid);

            var room = _db.Rooms.FirstOrDefault(x => x.Id == Rid);
            var s = new getRoomIdandPrice
            {
                RoomId = room.Id,
                WeekDayPrice = room.Price_Of_Weekdays,
                WeekendPrice = room.Price_Of_Weekends
            };
            return s;
        }
        // 宣告List 裡面要放很多 []
        public static List<string[]> allDates = new List<string[]>();
        // 拿 ordertails的訂房/退房時間 ==> 轉成List<string[]> ==> groupby... ==> 傳到前端
        public List<string> ListString()
        {
            // 拿roomId
            string rid = HttpContext.Session.GetString("rid");
            int Rid = Convert.ToInt32(rid);

            //int Rid = 14;

            var od = _db.OrderDetails.Where(x => x.RoomId == Rid && x.Status == Status.Success).Select(x => new getListString
            {
                startDate = x.StartDate,
                endDate = x.EndDate
            }).ToList();
            //GetAllDates(DateTime.Now, DateTime.Now.AddDays(1));
            //GetAllDates(DateTime.Now, DateTime.Now.AddDays(2));
            //GetAllDates(od[0].startDate, od[0].endDate);
            //GetAllDates(od[1].startDate, od[1].endDate);

            allDates = new List<string[]>(); // 使用前要先清空List!!!!!

            for (int i = 0; i < od.ToArray().Length; i++)
            {
                GetAllDates(od[i].startDate, od[i].endDate);
            }

            string[] n = new string[0]; // 空陣列
            foreach (string[] y in allDates)
            {
                n = n.Concat(y).ToArray(); // 把陣列全部連在一起
            }

            var res = n.GroupBy(x => x).Select(y => new { date = y.Key, count = y.Count() }).ToList();

            List<string> xxDate = new List<string>();
            var count = _db.Rooms.Where(x => x.Id == Rid).FirstOrDefault().Count;

            foreach (var x in res)
            {
                Console.WriteLine(x.date);
                Console.WriteLine(x.count);
                if (x.count == count)
                {
                    xxDate.Add(x.date.ToString());
                }
            }
            //Console.WriteLine(xxDate.Count);
            //Console.WriteLine(xxDate[0]);
            return xxDate;


        }
        public List<string[]> GetAllDates(DateTime startingDate, DateTime endingDate)
        {
            int index = 0;
            string[] x = new string[(endingDate - startingDate).Days + 1];

            for (DateTime i = startingDate; i <= endingDate; i = i.AddDays(1))
            {
                x[index] = i.Date.ToString("yyyy-MM-dd");
                index++;
            }
            allDates.Add(x);
            return allDates;
        }
        // 付款成功後 ==> 拿買家訂房資訊    ---------> 改送到BankController
        public void getReservation(getReservationViewModel model)
        {
            // 沒用的東西:)
        }
        //--------------------------------------------------------------------------
        // 買家訂單明細
        public IActionResult BOrderDetail()
        {
            return View();
        }
        // 取某User訂單明細
        public List<OrderDetailViewModel> GetOrderDetails()
        {
            var userId = Int32.Parse(User.Claims.FirstOrDefault(x => x.Type == "User_Id").Value);
            //&& x.Status == Status.Success
            var s = (from od in _db.OrderDetails.Where(x => x.UserId == userId && x.Status != Status.Cancel && x.EndDate >= DateTime.Now)
                     join r in _db.Rooms on od.RoomId equals r.Id
                     join ca in _db.Camping_Areas on r.Camping_AreaId equals ca.Id
                     orderby od.CreateDate descending
                     select new OrderDetailViewModel
                     {
                         OrderDetailId = od.Id,
                         Name = od.Name,
                         Phone = od.Phone,
                         CampingAreaName = ca.Name,
                         RoomName = r.Name,
                         RoomType = r.RoomType.GetType().GetMember(r.RoomType.ToString()).First().GetCustomAttribute<DisplayAttribute>().GetName(),
                         CheckInDate = od.StartDate.ToString("yyyy-MM-dd"),
                         CheckOutDate = od.EndDate.ToString("yyyy-MM-dd"),
                         Price = CalPrice.CalDaysPrice(od.StartDate, od.EndDate, r.Price_Of_Weekdays, r.Price_Of_Weekends),
                         Status = od.Status.GetType().GetMember(od.Status.ToString()).First().GetCustomAttribute<DisplayAttribute>().GetName()
                     }).ToList();
            return s;
        }
        // 取某User訂單明細 cancel && 時效已過
        public List<OrderDetailViewModel> GetCancelOrderDetails()
        {
            var userId = Int32.Parse(User.Claims.FirstOrDefault(x => x.Type == "User_Id").Value);
            //&& x.Status == Status.Success
            var s = (from od in _db.OrderDetails.Where(x => x.UserId == userId && (x.Status == Status.Cancel || x.EndDate < DateTime.Now) && x.Status != Status.Favority)
                     join r in _db.Rooms on od.RoomId equals r.Id
                     join ca in _db.Camping_Areas on r.Camping_AreaId equals ca.Id
                     orderby od.CancelDate descending
                     select new OrderDetailViewModel
                     {
                         OrderDetailId = od.Id,
                         Name = od.Name,
                         Phone = od.Phone,
                         CampingAreaName = ca.Name,
                         RoomName = r.Name,
                         RoomType = r.RoomType.GetType().GetMember(r.RoomType.ToString()).First().GetCustomAttribute<DisplayAttribute>().GetName(),
                         CheckInDate = od.StartDate.ToString("yyyy-MM-dd"),
                         CheckOutDate = od.EndDate.ToString("yyyy-MM-dd"),
                         Price = CalPrice.CalDaysPrice(od.StartDate, od.EndDate, r.Price_Of_Weekdays, r.Price_Of_Weekends),
                         Status = od.Status.GetType().GetMember(od.Status.ToString()).First().GetCustomAttribute<DisplayAttribute>().GetName(),
                         CancelDate = od.CancelDate.HasValue ? od.CancelDate.Value.ToString("yyyy-MM-dd HH:mm:ss") : ""
                     }).ToList();
            return s;
        }
        // 取某User訂單明細 favorite
        public List<OrderDetailViewModel> GetFavoriteOrderDetails()
        {
            var userId = Int32.Parse(User.Claims.FirstOrDefault(x => x.Type == "User_Id").Value);
            //&& x.Status == Status.Success
            var s = (from od in _db.OrderDetails.Where(x => x.UserId == userId && x.Status == Status.Favority)
                     join r in _db.Rooms on od.RoomId equals r.Id
                     join ca in _db.Camping_Areas on r.Camping_AreaId equals ca.Id
                     orderby od.CreateDate descending
                     select new OrderDetailViewModel
                     {
                         OrderDetailId = od.Id,
                         RoomId = r.Id,
                         Name = od.Name,
                         Phone = od.Phone,
                         CampingAreaName = ca.Name,
                         RoomName = r.Name,
                         RoomType = r.RoomType.GetType().GetMember(r.RoomType.ToString()).First().GetCustomAttribute<DisplayAttribute>().GetName(),
                         CheckInDate = od.StartDate.ToString("yyyy-MM-dd"),
                         CheckOutDate = od.EndDate.ToString("yyyy-MM-dd"),
                         Price = CalPrice.CalDaysPrice(od.StartDate, od.EndDate, r.Price_Of_Weekdays, r.Price_Of_Weekends),
                         Status = od.Status.GetType().GetMember(od.Status.ToString()).First().GetCustomAttribute<DisplayAttribute>().GetName(),
                         CancelDate = od.CancelDate.HasValue ? od.CancelDate.Value.ToString("yyyy-MM-dd HH:mm:ss") : ""
                     }).ToList();
            return s;
        }
        // 取消後 ==> 傳回指定OrderDetailsID ==> Status改為Refunding
        [HttpPost]
        public bool GetodID([FromBody] OdID model)
        {
            var od = _db.OrderDetails.Where(x => x.Id == model.odid).FirstOrDefault();

            if (od != null && od.Status == Status.Success)
            {
                od.Status = Status.Refunding;
                _db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        // 買家基本資料
        public IActionResult userInfo()
        {
            return View();
        }
        // 取某User基本資料
        public BuyerInfo GetUserInfo()
        {
            //Console.WriteLine(User.Claims.FirstOrDefault(x => x.Type == "User_Id").Value);
            var userId = Int32.Parse(User.Claims.FirstOrDefault(x => x.Type == "User_Id").Value);
            var user = _db.Users.FirstOrDefault(x => x.Id == userId);

            var info = new BuyerInfo
            {
                id = user.Id,
                name = user.Name,
                email = user.Email,
                phone = user.Phone,
                password = user.Password
            };
            return info;
        }
        // 拿買家編輯後的資料
        [HttpPost]
        public bool GetNewUserInfo([FromBody] NewUserInfo model)
        {
            var newUser = _db.Users.Where(x => x.Id == model.Id).FirstOrDefault();

            var oldPassword = newUser.Password;
            if (model.Password != oldPassword)
            {
                string salt = newUser.Salt;
                byte[] passwordAndSaltBytes = System.Text.Encoding.UTF8.GetBytes(model.Password + salt);
                byte[] hashBytes = new System.Security.Cryptography.SHA256Managed().ComputeHash(passwordAndSaltBytes);
                string hashString = Convert.ToBase64String(hashBytes);
                newUser.Password = hashString;
            }
            newUser.Name = model.Name;
            newUser.Email = model.Email;
            newUser.Phone = model.Phone;

            _db.SaveChanges();
            return true;

        }
        
        //----------ViewModel-----------------------------------------------------
        public class NewUserInfo
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Password { get; set; }
        }
        public class UserViewModel
        {
            public string Email { get; set; }
            public string Password { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }

        }
        public class LoginViewModel
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }
        public class OrderDetailViewModel
        {
            public int OrderDetailId { get; set; }
            public int RoomId { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }
            public string CampingAreaName { get; set; }
            public string RoomName { get; set; }
            public string RoomType { get; set; }
            public string CheckInDate { get; set; }
            public string CheckOutDate { get; set; }
            public decimal Price { get; set; }
            public string Status { get; set; }
            public string CancelDate { get; set; }
        }
        public class BuyerInfo
        {
            public int id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public string phone { get; set; }
            public string password { get; set; }
        }
        public class OdID
        {
            public decimal odid { get; set; }
        }
        public class IndexInfo
        {
            public int CampingAreaId { get; set; }
            public string CampingAreaName { get; set; }
            public string CampingDes { get; set; }
            public int LowerPrice { get; set; }
            public string PicPath { get; set; }
            public Region Region { get; set; }

        }
        public class RoomInfoViewModel
        {
            public List<int> UserFavRoomId { get; set; }
            public int CAId { get; set; }
            public string CAname { get; set; }
            public List<string> CApicPath { get; set; }
            public string CAdescription { get; set; }
            public string CAaddress { get; set; }
            public string CAphone { get; set; }
            public bool Wifi { get; set; }
            public bool Breakfast { get; set; }
            public bool Canopy { get; set; }
            public bool Canteen { get; set; }
            public bool Dinner { get; set; }
            public bool IsCancel { get; set; }
            public bool Kitchen_Utensils { get; set; }
            public bool Lunch { get; set; }
            public bool Mattress { get; set; }
            public bool Night_Lighting { get; set; }
            public bool No_Equipment { get; set; }
            public bool Outdoor_Tables_Chairs { get; set; }
            public bool Power_Supply { get; set; }
            public bool Public_Refrigerator { get; set; }
            public bool Tent_Equipment { get; set; }
            public List<Myroom> Rooms { get; set; }

        }
        public class Myroom
        {
            public int UserId { get; set; }
            public int CAId { get; set; }
            public string CAName { get; set; }
            public int RoomId { get; set; }
            public decimal PriceOfWeekDay { get; set; }
            public string RoomName { get; set; }
            public string RoomType { get; set; }
            public List<string> Room_Path { get; set; }
            public string Room_Des { get; set; }
            public string RoomStatus { get; set; }

        }
        public class getReservationViewModel
        {
            public string Name { get; set; }
            public string Tel { get; set; }
            public string CheckInDate { get; set; }
            public string CheckOutDate { get; set; }
        }
        public class getRoomIdandPrice
        {
            public int RoomId { get; set; }
            public decimal WeekDayPrice { get; set; }
            public decimal WeekendPrice { get; set; }

        }
        public class getListString
        {
            public DateTime startDate { get; set; }
            public DateTime endDate { get; set; }
        }
        public class FavoriteInfoViewModel
        {
            public int favRoomId { get; set; }
        }
    }
}
