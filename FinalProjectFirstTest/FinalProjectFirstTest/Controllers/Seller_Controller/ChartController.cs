using FinalProjectFirstTest.Models;
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
		public IActionResult Chart()
		{
			
			return View();
		}

		public object RoomChart()
		{
			int sellerid = 4;
			var mydata = (from od in _db.OrderDetails.Where(w => w.Status != Status.Cancel)
						join r in _db.Rooms on od.RoomId equals r.Id
						join c in _db.Camping_Areas on r.Camping_AreaId equals c.Id
						join s in _db.Sellers on c.SellerId equals s.Id
						where s.Id == sellerid
						select new RoomChartViewModel
						{
							RoomName = r.Name,
							Price = CalPrice.CalDaysPrice(od.StartDate, od.EndDate, r.Price_Of_Weekdays, r.Price_Of_Weekends),

						}).ToArray();
			return mydata;
		}
		public class RoomChartViewModel
		{
			public string RoomName { get; set; }
			public decimal Price { get; set; }

		}
	}
}
