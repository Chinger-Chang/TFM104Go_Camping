using FinalProjectFirstTest.Models;
using FinalProjectFirstTest.Seller_ViewModel.Camping_Information;
using FinalProjectFirstTest.Seller_ViewModel.Edit_Camping_Area;
using FinalProjectFirstTest.Seller_ViewModel.Edit_Room;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace FinalProjectFirstTest.Controllers
{
    public class ManagerController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly FinalProjectDbContext _db;
        public ManagerController(IWebHostEnvironment environment, FinalProjectDbContext db)
        {
            _environment = environment;
            _db = db;
        }
        // 管理者訂單
        [Authorize(Roles = "Manager")]
        public IActionResult ManagerOrderDetails()
        {
            return View();
        }
        // 拿所有訂單
        public List<MOrderDetailViewModel> GetAllOrderDetails()
        {
            //var a = _db.OrderDetailsTest.FirstOrDefault();

            var s = (from od in _db.OrderDetails.Where(x => x.Status != Status.Favority)
                     join r in _db.Rooms on od.RoomId equals r.Id
                     join ca in _db.Camping_Areas on r.Camping_AreaId equals ca.Id
                     orderby od.Id descending
                     select new MOrderDetailViewModel
                     {
                         MOrderDetailID = od.Id,
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
        // 拿退款中的訂單
        public List<MOrderDetailViewModel> GetReFundingOrderDetails()
        {
            //var a = _db.OrderDetailsTest.FirstOrDefault();

            var s = (from od in _db.OrderDetails.Where(x => x.Status == Status.Refunding)
                     join r in _db.Rooms on od.RoomId equals r.Id
                     join ca in _db.Camping_Areas on r.Camping_AreaId equals ca.Id
                     orderby od.Id descending
                     select new MOrderDetailViewModel
                     {
                         MOrderDetailID = od.Id,
                         Name = od.Name,
                         Phone = od.Phone,
                         CampingAreaName = ca.Name,
                         RoomName = r.Name,
                         RoomType = r.RoomType.GetType().GetMember(r.RoomType.ToString()).First().GetCustomAttribute<DisplayAttribute>().GetName(),
                         CheckInDate = od.StartDate.ToString("yyyy-MM-dd"),
                         CheckOutDate = od.EndDate.ToString("yyyy-MM-dd"),
                         Price = CalPrice.CalDaysPrice(od.StartDate, od.EndDate, r.Price_Of_Weekdays, r.Price_Of_Weekends),
                         Status = od.Status.GetType().GetMember(od.Status.ToString()).First().GetCustomAttribute<DisplayAttribute>().GetName(),
                         CancelDate = od.CancelDate.HasValue ? od.CancelDate.Value.ToString("yyyy-MM-dd") : ""   // 問 Reds:)
                     }).ToList();
            return s;
        }
        // 管理者確認退款後 ==> 傳回指定OrderDetailsID ==> 更改status為Cancel
        [HttpPost]
        public bool GetmodID([FromBody] mOdID model)
        {
            var od = _db.OrderDetails.Where(x => x.Id == model.modid).FirstOrDefault();

            if (od != null && od.Status == Status.Refunding)
            {
                od.Status = Status.Cancel;
                //od.CancelDate = 記得加取消時間
                od.CancelDate = DateTime.Now;
                _db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        [Authorize(Roles = "Manager")]
        public IActionResult Get_Unaudited_Campingarea()
        {
            return View();
        }

        public List<Unaudited_CampingareaViewModel> Unaudited_Campingarea_Info()
        {
            var mydata = (from ca in _db.Camping_Areas.Where(w => w.IsAudit == false)
                          join s in _db.Sellers on ca.SellerId equals s.Id
                          orderby ca.UpdateTime descending
                          select new Unaudited_CampingareaViewModel
                          {
                              SellerEmail = s.Email,
                              SellerName = s.Name,
                              SellerPhone = s.Phone,
                              CampingAreaId = ca.Id,
                              CampingAreaName = ca.Name,
                              Path = "/Camping_Area_Picture/" + _db.Camping_Area_Pictures.Where(w => w.Camping_AreaId == ca.Id).FirstOrDefault().Path
                          }).ToList();
            return mydata;
        }

        [Authorize(Roles = "Manager")]
        [Route("[controller]/[action]/{id?}")]
        public IActionResult Get_All([FromRoute] int? id)
		{
            if(id==null)
			{
                return View();
			}
			else
			{
                HttpContext.Session.SetString("camping_area_id", id.ToString());
                return View();
            }
            
            
        }

        public CampingInformationViewModel Get_All_FromDB()
        {
            var id = HttpContext.Session.GetString("camping_area_id");
            var camp = _db.Camping_Areas.FirstOrDefault(x => x.Id == Convert.ToInt32(id));

            var mydata = new CampingInformationViewModel
            {
                Camping_AreaId = camp.Id,
                Camping_Area_Name = camp.Name,
                Camping_AreaAddress = camp.Address,
                AuditDescription = camp.AuditDescription,
                Camping_Area_Path = "/Camping_Area_Picture/" + _db.Camping_Area_Pictures.Where(w => w.Camping_AreaId == camp.Id).FirstOrDefault()?.Path,
                Myrooms = _db.Rooms.Where(w => w.Camping_AreaId == camp.Id).Select(x => new Myroom
                {
                    RoomId = x.Id,
                    RoomName = x.Name,
                    RoomCount = x.Count,
                    Room_Path = "/Room_Picture/" + _db.Room_Pictures.Where(w => w.RoomId == x.Id).FirstOrDefault().Path
                }).ToList()
            };

            return mydata;
        }

        [Authorize(Roles = "Manager")]
        public IActionResult Get_CampingArea()
        {
            return View();
        }

        [Authorize(Roles = "Manager")]
        [Route("[controller]/[action]/{id}")]
        public IActionResult Get_Room([FromRoute] int id)
        {
            HttpContext.Session.SetString("room_id", id.ToString());
            return View();
        }

        public EditCamping_AreaViewModel Audit_CampingArea()
        {
            string id = HttpContext.Session.GetString("camping_area_id");


            var mydata = new EditCamping_AreaViewModel
            {
                MyCampingAreas = _db.Camping_Areas.Where(w => w.Id == Convert.ToInt32(id)).Select(s => new MyCampingArea
                {
                    Id = s.Id,
                    Name = s.Name,
                    Phone = s.Phone,
                    Region = s.Region.ToString(),
                    Address = s.Address,
                    Description = s.Description,
                    IsAudit = s.IsAudit,
                    Path = _db.Camping_Area_Pictures.Where(w => w.Camping_AreaId == s.Id).Select(service => service.Path).ToList(),
                    PathId = _db.Camping_Area_Pictures.Where(w => w.Camping_AreaId == s.Id).Select(service => service.Id).ToList()
                }).FirstOrDefault(),
                MyServices = _db.Services.Where(w => w.Camping_AreaId == Convert.ToInt32(id)).Select(service => new MyService
                {
                    Breakfast = service.Breakfast,
                    Lunch = service.Lunch,
                    Dinner = service.Dinner,
                    Public_Refrigerator = service.Public_Refrigerator,
                    Tent_Equipment = service.Tent_Equipment,
                    Kitchen_Utensils = service.Kitchen_Utensils,
                    Canopy = service.Canopy,
                    Wifi = service.Wifi,
                    Night_Lighting = service.Night_Lighting,
                    Power_Supply = service.Power_Supply,
                    Outdoor_Tables_Chairs = service.Outdoor_Tables_Chairs,
                    Canteen = service.Canteen,
                    Mattress = service.Mattress,
                    No_Equipment = service.No_Equipment,
                    IsCancel = service.IsCancel
                }).FirstOrDefault()
            };
            return mydata;
        }

        public Edit_RoomViewModel Audit_Room()
        {
            string id = HttpContext.Session.GetString("room_id");
            var s = _db.Rooms.Where(w => w.Id == Convert.ToInt32(id)).FirstOrDefault();
            var mydata = new Edit_RoomViewModel
            {
                Name = s.Name,
                Count = s.Count,
                RoomType = s.RoomType.ToString(),
                Description = s.Description,
                Price_Of_Weekdays = s.Price_Of_Weekdays,
                Price_Of_Weekends = s.Price_Of_Weekends,
                Path = _db.Room_Pictures.Where(w => w.RoomId == s.Id).Select(s => s.Path).ToList(),
                PathId = _db.Room_Pictures.Where(w => w.RoomId == s.Id).Select(s => s.Id).ToList()
            };

            return mydata;
        }

        public bool Pass()
		{
            string id = HttpContext.Session.GetString("camping_area_id");
            var camp = _db.Camping_Areas.Where(w => w.Id == Convert.ToInt32(id)).FirstOrDefault();

            camp.IsAudit = true;
            _db.SaveChanges();
            return true;
        }

        [HttpPost]
        public bool NotPass([FromBody]NotPassViewModel model)
        {
            string id = HttpContext.Session.GetString("camping_area_id");
            var camp = _db.Camping_Areas.Where(w => w.Id == Convert.ToInt32(id)).FirstOrDefault();

            camp.IsAudit = false;
            camp.AuditDescription = model.Description;
            _db.SaveChanges();
            return true;
        }
        //--------------- ViewModel -------------------------------
        public class MOrderDetailViewModel
        {
            public int MOrderDetailID { get; set; }
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
        public class mOdID
        {
            public decimal modid { get; set; }
        }

        public class Unaudited_CampingareaViewModel
        {
            public string SellerEmail { get; set; } 

            public string SellerName { get; set; }

            public string SellerPhone { get; set; }

            public string CampingAreaName { get; set; }

            public int CampingAreaId { get; set; }

            public string Path { get; set; }
        }

        public class NotPassViewModel
		{
            public string Description { get; set; }
		}
    }
}
