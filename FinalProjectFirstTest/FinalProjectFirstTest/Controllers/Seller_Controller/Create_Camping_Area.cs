using FinalProjectFirstTest.Models;
using FinalProjectFirstTest.Seller_ViewModel.Create_Camping_Area;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampingAreaTest330.Controllers
{
	public class Create_Camping_AreaController : Controller
	{
		private readonly IWebHostEnvironment _environment;
		private readonly FinalProjectDbContext _db;

		public Create_Camping_AreaController(IWebHostEnvironment environment, FinalProjectDbContext db)
		{
			_environment = environment;
			_db = db;
		}

		[Authorize(Roles = "Seller")]
		public IActionResult CampingArea()
		{
			return View();
		}

		[HttpPost]
		public Boolean Camping_Area_IntoDB(CampingAreaViewModel model)

		{
			var sellerid = Int32.Parse(User.Claims.FirstOrDefault(x => x.Type == "Seller_Id").Value);
			var path = _environment.WebRootPath + "/Camping_Area_Picture";
			var picsize = model.Path.Count;
			var file = model.Path;
			Console.WriteLine(model.Region);
			//ProductType pt = (ProductType)Enum.Parse(typeof(ProductType),)
			if (model != null)
			{
				var oo = new Camping_Area()
				{
					SellerId = sellerid,
					Name = model.Name,
					Phone = model.Phone,
					Region = model.Region,
					Address = model.Address,
					//Path = fileName,
					Description = model.Description,
					IsAudit = false,
					UpdateTime = DateTime.Now
				};
				_db.Camping_Areas.Add(oo);
				_db.SaveChanges();
				var pp = new Service()
				{
					Camping_AreaId = oo.Id,
					Breakfast = model.Breakfast,
					Lunch = model.Lunch,
					Dinner = model.Dinner,
					Public_Refrigerator = model.Public_Refrigerator,
					Tent_Equipment = model.Tent_Equipment,
					Kitchen_Utensils = model.Kitchen_Utensils,
					Canopy = model.Canopy,
					Wifi = model.Wifi,
					Night_Lighting = model.Night_Lighting,
					Power_Supply = model.Power_Supply,
					Outdoor_Tables_Chairs = model.Outdoor_Tables_Chairs,
					Canteen = model.Canteen,
					Mattress = model.Mattress,
					No_Equipment = model.No_Equipment,
					IsCancel = model.IsCancel
				};

				_db.Services.Add(pp);
				_db.SaveChanges();
				//var id = oo.Id;

				if (file != null)
				{
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

						_db.Camping_Area_Pictures.Add(new Camping_Area_Picture()
						{
							Camping_AreaId = oo.Id,
							Path = fileName,
							UpdateTime = DateTime.Now
						});
					}
				}

				_db.SaveChanges();
				//Console.WriteLine(id);
				//}
				HttpContext.Session.SetString("camping_area_id", oo.Id.ToString());
				return true;
			}
			else
			{
				return false;
			}

		}
	}

}
