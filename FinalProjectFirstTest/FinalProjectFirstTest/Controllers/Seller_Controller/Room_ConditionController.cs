using FinalProjectFirstTest.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectFirstTest.Controllers.Seller_Controller
{
	public class Room_ConditionController : Controller
	{
		private readonly FinalProjectDbContext _db;
		public Room_ConditionController(FinalProjectDbContext db)
		{
			_db = db;
		}

		[Authorize(Roles = "Seller")]
		public IActionResult RoomCondition()
		{
			return View();
		}

		public Get_Camping_AreaViewModel Get_Camping_Area()
		{
			var sellerid = Int32.Parse(User.Claims.FirstOrDefault(x => x.Type == "Seller_Id").Value);
			var mydata = new Get_Camping_AreaViewModel
			{
				Camping_AreaId = _db.Camping_Areas.Where(w => w.SellerId == sellerid).Select(s => s.Id).ToList(),
				Camping_Area_Name = _db.Camping_Areas.Where(w => w.SellerId == sellerid).Select(s => s.Name).ToList()
			};
			return mydata;
		}

		[Route("[controller]/[action]/{id?}")]
		public Get_RoomViewModel Get_Room([FromRoute] int? id)
		{
			var sellerid = Int32.Parse(User.Claims.FirstOrDefault(x => x.Type == "Seller_Id").Value);
			if (id ==null)
			{
				var camp = _db.Camping_Areas.Where(w => w.SellerId == sellerid).Select(s => s.Id).FirstOrDefault();

				var mydata = new Get_RoomViewModel
				{
					RoomId = _db.Rooms.Where(w => w.Camping_AreaId == camp).Select(s => s.Id).ToList(),
					Room_Name = _db.Rooms.Where(w => w.Camping_AreaId == camp).Select(s => s.Name).ToList()
				};
				return mydata;
			}
			else
			{
				var mydata = new Get_RoomViewModel
				{
					RoomId = _db.Rooms.Where(w => w.Camping_AreaId == id).Select(s => s.Id).ToList(),
					Room_Name = _db.Rooms.Where(w => w.Camping_AreaId == id).Select(s => s.Name).ToList()
				};
				return mydata;
			}
			
		}

		[Route("[controller]/[action]/{id}")]
		public Get_Room_Order_DetailsViewModel ListString([FromRoute] int id)
		{
			// 拿roomId

			var od = _db.OrderDetails.Where(x => x.RoomId == id && (x.Status == Status.Success || x.Status == Status.Refunding)).OrderBy(o => o.StartDate).Select(x => new Get_Date
			{
				StartDate = x.StartDate,
				EndDate = x.EndDate
			}).ToList();
			AllDates = new List<string[]>();
			for (int i = 0; i < od.ToArray().Length; i++)
			{
				GetAllDates(od[i].StartDate, od[i].EndDate);
			}

			string[] AllDatesString = new string[0]; // 空陣列
			foreach (string[] a in AllDates)
			{
				AllDatesString = AllDatesString.Concat(a).ToArray();
			}

			var mydata1 = AllDatesString.GroupBy(g => g).Select(s => new { Date = s.Key, Count = s.Count() }).ToList();

			List<string> AllDate = new List<string>();
			List<int> Remaining_Amount = new List<int>();
			var Count = _db.Rooms.Where(x => x.Id == id).FirstOrDefault().Count;
			//Console.WriteLine("aaa");
			foreach (var x in mydata1)
			{
				//Console.WriteLine(x.Date);
				//Console.WriteLine(x.Count);
				AllDate.Add(x.Date.ToString());
				Remaining_Amount.Add(Count - x.Count);

			}

			var mydata2 = new Get_Room_Order_DetailsViewModel
			{
				Total_Amount = _db.Rooms.Where(w => w.Id == id).Select(s => s.Count).FirstOrDefault(),
				GetAllDate = AllDate,
				GetRemaining_Amount = Remaining_Amount
			};
			//Console.WriteLine(xxDate.Count);
			//Console.WriteLine(xxDate[0]);
			return mydata2;


		}
		public static List<string[]> AllDates = new List<string[]>();
		public List<string[]> GetAllDates(DateTime StartingDate, DateTime EndingDate)
		{
			int index = 0;
			string[] x = new string[(EndingDate - StartingDate).Days + 1];

			for (DateTime i = StartingDate; i <= EndingDate; i = i.AddDays(1))
			{
				x[index] = i.Date.ToString("yyyy-MM-dd");
				index++;
			}
			AllDates.Add(x);
			return AllDates;
		}


		public class Get_Camping_AreaViewModel
		{
			public List<string> Camping_Area_Name { get; set; }
			public List<int> Camping_AreaId { get; set; }
		}

		public class Get_RoomViewModel
		{
			public List<string> Room_Name { get; set; }
			public List<int> RoomId { get; set; }
		}

		public class Get_Date
		{
			public DateTime StartDate { get; set; }
			public DateTime EndDate { get; set; }
		}

		public class Get_Room_Order_DetailsViewModel
		{
			public int Total_Amount { get; set; }
			public List<string> GetAllDate { get; set; }
			public List<int> GetRemaining_Amount { get; set; }
		}
	}
}
