using FinalProjectFirstTest.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FinalProjectFirstTest.Controllers.Seller_Controller
{
	public class ChartController : Controller
	{
		private readonly FinalProjectDbContext _db;
		public ChartController(FinalProjectDbContext db)
		{
			_db = db;
		}
		[Authorize(Roles = "Seller")]
		public IActionResult Chart()
		{
			
			return View();
		}

		[Route("[controller]/[action]/{name}")]
		public bool Cid([FromRoute] string name)
		{
			var campid = _db.Camping_Areas.Where(w => w.Name == name).FirstOrDefault().Id;
			HttpContext.Session.SetString("cid", campid.ToString());
			return true;
		}

	
		[Route("[controller]/[action]/{name?}")]
		public object RoomChart()
		
		{
			int campid;

			if (HttpContext.Session.GetString("cid") == null)
			{
				var sellerid = Int32.Parse(User.Claims.FirstOrDefault(x => x.Type == "Seller_Id").Value);
				campid = _db.Camping_Areas.Where(w=> w.SellerId == sellerid).FirstOrDefault().Id;
			}
			else
			{

				campid = Convert.ToInt32(HttpContext.Session.GetString("cid"));
			}
				
			
			
			var mydata = (from od in _db.OrderDetails.Where(w => w.Status != Status.Cancel)
						join r in _db.Rooms on od.RoomId equals r.Id
						join c in _db.Camping_Areas on r.Camping_AreaId equals c.Id
						where c.Id == campid
						  select new RoomChartViewModel
						{
							RoomName = r.Name,
							Price = CalPrice.CalDaysPrice(od.StartDate, od.EndDate, r.Price_Of_Weekdays, r.Price_Of_Weekends),

						}).ToList();
			var gp = mydata.GroupBy(g => g.RoomName).Select(s => new RoomChartViewModel { RoomName = s.Key, Price = s.Sum(s => s.Price) });

			return gp;
		}

		public object Camping_AreaChart()
		{
			var sellerid = Int32.Parse(User.Claims.FirstOrDefault(x => x.Type == "Seller_Id").Value);
			//int sellerid = 4;
			var mydata = (from od in _db.OrderDetails.Where(w => w.Status != Status.Cancel)
						  join r in _db.Rooms on od.RoomId equals r.Id
						  join c in _db.Camping_Areas on r.Camping_AreaId equals c.Id
						  join s in _db.Sellers on c.SellerId equals s.Id
						  where s.Id == sellerid
						  select new Camping_AreaChartViewModel
						  {
							  Camping_AreaId = c.Id,
							  Camping_AreaName = c.Name,
							  Price = CalPrice.CalDaysPrice(od.StartDate, od.EndDate, r.Price_Of_Weekdays, r.Price_Of_Weekends),

						  }).ToList();
			var gp = mydata.GroupBy(g => g.Camping_AreaName).Select(s => new Camping_AreaChartViewModel { Camping_AreaName = s.Key,Camping_AreaId = s.FirstOrDefault().Camping_AreaId , Price = s.Sum(s => s.Price) });

			return gp;
		}
		public class RoomChartViewModel
		{
			public string RoomName { get; set; }
			public decimal Price { get; set; }

		}

		public class Camping_AreaChartViewModel
		{
			public int Camping_AreaId { get; set; }
			public string Camping_AreaName { get; set; }
			public decimal Price { get; set; }

		}
	}
}
