using FinalProjectFirstTest.Models;
using FinalProjectFirstTest.Seller_ViewModel.Create_Room;
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
	public class Create_RoomController : Controller
	{
		private readonly IWebHostEnvironment _environment;
		private readonly FinalProjectDbContext _db;
		public Create_RoomController(IWebHostEnvironment environment, FinalProjectDbContext db)
		{
			_environment = environment;
			_db = db;
		}

		[Authorize(Roles = "Seller")]
		[Route("[controller]/[action]/{id?}")]

		public IActionResult CreateRoom([FromRoute] int? id)
		{
			if(id!=null)
			{
				HttpContext.Session.SetString("camping_area_id", id.ToString());
			}
			return View();
		}

		[HttpPost]
		
		public Boolean Room_IntoDB(RoomViewModel model)
		{
			
			var cid = HttpContext.Session.GetString("camping_area_id");
			Console.WriteLine(cid);
			var path = _environment.WebRootPath + "/Room_Picture";
			var picsize = model.Path.Count;
			var file = model.Path;
			//Console.WriteLine(model.Reigon);
			//ProductType pt = (ProductType)Enum.Parse(typeof(ProductType),)
			if (model != null)
			{
				var oo = new Room()
				{
					Camping_AreaId = Convert.ToInt32(cid),
					Name = model.Name,
					Count = model.Count,
					RoomType = model.RoomType,
					Description = model.Description,
					Price_Of_Weekdays = model.Price_Of_Weekdays,
					Price_Of_Weekends = model.Price_Of_Weekends,

				};
				_db.Rooms.Add(oo);

				if (file != null)
				{
					for (var index = 0; index < picsize; index++)
					{
						//if(file.Length > 0)
						//{
						var fileName = DateTime.Now.Ticks.ToString() + file[index].FileName;
						using (var fs = System.IO.File.Create($"{path}/{fileName}"))
						{

							//還沒載完會卡住所以要copy
							file[index].CopyTo(fs);
						}

						_db.Room_Pictures.Add(new Room_Picture()
						{
							Room = oo,
							Path = fileName,
							UpdateTime = DateTime.Now
						});
					}
				}

				_db.SaveChanges();
				//Console.WriteLine(id);
				//}
				return true;
			}
			else
			{
				return false;
			}

		}
	
	
}
}
