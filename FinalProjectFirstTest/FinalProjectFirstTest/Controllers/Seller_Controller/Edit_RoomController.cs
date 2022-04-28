using FinalProjectFirstTest.Models;
using FinalProjectFirstTest.Seller_ViewModel.Create_Room;
using FinalProjectFirstTest.Seller_ViewModel.Edit_Room;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampingAreaTest330.Controllers
{
	public class Edit_RoomController : Controller
	{
		private readonly IWebHostEnvironment _environment;
		private readonly FinalProjectDbContext _db;

		public Edit_RoomController(IWebHostEnvironment environment, FinalProjectDbContext db)
		{
			_environment = environment;
			_db = db;
		}

		[Authorize(Roles = "Seller")]
		[Route("[controller]/[action]/{id}")]
		public IActionResult EditRoom([FromRoute] int id)
		{
			HttpContext.Session.SetString("roomid", id.ToString());
			return View();
		}

		public Edit_RoomViewModel GetRoom()
		{
			string id = HttpContext.Session.GetString("roomid");
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

		[HttpPost]
		public bool EditRoom_Into_DB(RoomViewModel model)
		{
			if(model!=null)
			{ 
			string r = HttpContext.Session.GetString("roomid");
			var room = _db.Rooms.Where(w => w.Id == (Convert.ToInt32(r))).FirstOrDefault();
			room.Name = model.Name;
			room.Count = model.Count;
			room.RoomType = model.RoomType;
			room.Description = model.Description;
			room.Price_Of_Weekdays = model.Price_Of_Weekdays;
			room.Price_Of_Weekends = model.Price_Of_Weekends;

			_db.SaveChanges();

			if (model.Path != null)
			{
				var path = _environment.WebRootPath + "/Room_Picture";
				var picsize = model.Path.Count;
				var file = model.Path;
				for (var index = 0; index < picsize; index++)
				{
					//if(file.Length > 0)
					//{
					var fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + file[index].FileName;
					using (var fs = System.IO.File.Create($"{path}/{fileName}"))
					{

						//還沒載完會卡住所以要copy
						file[index].CopyTo(fs);
					}

					_db.Room_Pictures.Add(new Room_Picture()
					{
						RoomId = Convert.ToInt32(r),
						Path = fileName,
						UpdateTime = DateTime.Now
					});
					
				}
				_db.SaveChanges();
				
			}
				return true;
			}

			else
			{
				return false;
			}
		}

		[HttpPost]
		[Route("[controller]/[action]/{id}")]
		public Boolean DeleteRoomPicture([FromRoute] int? id)
		{
			if (id != null)
			{
				var s = _db.Room_Pictures.Where(W => W.Id == id).FirstOrDefault();
				_db.Room_Pictures.Remove(s);
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
