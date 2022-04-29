using FinalProjectFirstTest.Models;
using FinalProjectFirstTest.Seller_ViewModel.Order_Detail;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace FinalProjectFirstTest.Controllers.Seller_Controller
{
	public class Order_DetailController : Controller
	{
		private readonly FinalProjectDbContext _db;
		public Order_DetailController(FinalProjectDbContext db)
		{
			_db = db;
		}

		[Authorize(Roles = "Seller")]
		public IActionResult Seller_OrderDetail()
		{
			return View();
		}

		public List<OrderDetailViewModel> Get_Order_Details()
		{
			var sellerid = Int32.Parse(User.Claims.FirstOrDefault(x => x.Type == "Seller_Id").Value);
			var sres = (from od in _db.OrderDetails.Where(w => w.Status != Status.Cancel && w.EndDate >= DateTime.Now )
					 join r in _db.Rooms on od.RoomId equals r.Id
					 join c in _db.Camping_Areas on r.Camping_AreaId equals c.Id
					 join s in _db.Sellers on c.SellerId equals s.Id
					 where s.Id == sellerid
					 orderby od.CreateDate descending
					 select new OrderDetailViewModel
					 {
					  OrderDetailId = od.Id,
					  Name = od.Name,
					  Phone = od.Phone,
					  CampingAreaName = c.Name,
					  RoomType = r.RoomType.GetType().GetMember(r.RoomType.ToString()).First().GetCustomAttribute<DisplayAttribute>().GetName(),
					  CheckInDate = od.StartDate.ToString("yyyy-MM-dd"),
					  CheckOutDate = od.EndDate.ToString("yyyy-MM-dd"),
					  Price = CalPrice.CalDaysPrice(od.StartDate, od.EndDate, r.Price_Of_Weekdays, r.Price_Of_Weekends),
					  Status = od.Status.GetType().GetMember(od.Status.ToString()).First().GetCustomAttribute<DisplayAttribute>().GetName(),
					  CancelDate = od.CancelDate.HasValue ? od.CancelDate.Value.ToString("yyyy-MM-dd") : ""
					 }).ToList();
			return sres;
		}
		public List<OrderDetailViewModel> Get_Cancel_Order_Details()
		{
			var sellerid = Int32.Parse(User.Claims.FirstOrDefault(x => x.Type == "Seller_Id").Value);
			var sres = (from od in _db.OrderDetails.Where(w => (w.Status == Status.Cancel || w.EndDate < DateTime.Now) && w.Status != Status.Favority)
					 join r in _db.Rooms on od.RoomId equals r.Id
					 join c in _db.Camping_Areas on r.Camping_AreaId equals c.Id 
					 join s in _db.Sellers on c.SellerId equals s.Id
					 where s.Id == sellerid
					 orderby od.CreateDate descending
					 select new OrderDetailViewModel
					 {
						 OrderDetailId = od.Id,
						 Name = od.Name,
						 Phone = od.Phone,
						 CheckInDate = od.StartDate.ToString("yyyy-MM-dd"),
						 CheckOutDate = od.EndDate.ToString("yyyy-MM-dd"),
						 Price = CalPrice.CalDaysPrice(od.StartDate, od.EndDate, r.Price_Of_Weekdays, r.Price_Of_Weekends),
						 Status = od.Status.GetType().GetMember(od.Status.ToString()).First().GetCustomAttribute<DisplayAttribute>().GetName(),
						 RoomType = r.RoomType.GetType().GetMember(r.RoomType.ToString()).First().GetCustomAttribute<DisplayAttribute>().GetName(),
						 CampingAreaName = c.Name,
						 CancelDate = od.CancelDate.HasValue ? od.CancelDate.Value.ToString("yyyy-MM-dd") : ""
					 }).ToList();
				return sres;
		}

		[HttpPost]
		public bool Delete_Order_Detail([FromBody] int id)
		{
			var od = _db.OrderDetails.Where(w => w.Id == id).FirstOrDefault();

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
	}
}
