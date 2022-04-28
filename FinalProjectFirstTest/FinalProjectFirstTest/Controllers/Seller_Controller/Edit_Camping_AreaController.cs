using FinalProjectFirstTest.Models;
using FinalProjectFirstTest.Seller_ViewModel.Create_Camping_Area;
using FinalProjectFirstTest.Seller_ViewModel.Edit_Camping_Area;
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
	public class Edit_Camping_AreaController : Controller
	{
		private readonly IWebHostEnvironment _environment;
		private readonly FinalProjectDbContext _db;

		public Edit_Camping_AreaController(IWebHostEnvironment environment, FinalProjectDbContext db)
		{
			_environment = environment;
			_db = db;
		}

		[Authorize(Roles = "Seller")]
		public IActionResult EditCamping_Area()
		{
			return View();
		}

		public EditCamping_AreaViewModel GetCamping_Area()
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
					Path =  _db.Camping_Area_Pictures.Where(w => w.Camping_AreaId == s.Id).Select(service => service.Path).ToList(),
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
					IsCancel= service.IsCancel
				}).FirstOrDefault()
			};
			return mydata;
	}
		[HttpPost]
		public bool EditCamping_Area_Into_DB(CampingAreaViewModel model)
		{
			
			if (model!=null)
			{
				string r = HttpContext.Session.GetString("camping_area_id");
				var camp = _db.Camping_Areas.Find(Convert.ToInt32(r));
				camp.Name = model.Name;
				camp.Phone = model.Phone;
				camp.Region = model.Region;
				camp.Address = model.Address;
				camp.Description = model.Description;
				camp.UpdateTime = DateTime.Now;
				_db.SaveChanges();

				var service = _db.Services.Where(w => w.Camping_AreaId == camp.Id).FirstOrDefault();
				service.Breakfast = model.Breakfast;
				service.Lunch = model.Lunch;
				service.Dinner = model.Dinner;
				service.Public_Refrigerator = model.Public_Refrigerator;
				service.Tent_Equipment = model.Tent_Equipment;
				service.Kitchen_Utensils = model.Kitchen_Utensils;
				service.Canopy = model.Canopy;
				service.Wifi = model.Wifi;
				service.Night_Lighting = model.Night_Lighting;
				service.Power_Supply = model.Power_Supply;
				service.Outdoor_Tables_Chairs = model.Outdoor_Tables_Chairs;
				service.Canteen = model.Canteen;
				service.Mattress = model.Mattress;
				service.No_Equipment = model.No_Equipment;
				_db.SaveChanges();

				if (model.Path != null)
				{
					var path = _environment.WebRootPath + "/Camping_Area_Picture";
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
						_db.Camping_Area_Pictures.Add(new Camping_Area_Picture()
						{
							Camping_AreaId = Convert.ToInt32(r),
							Path = fileName,
							UpdateTime = DateTime.Now
						});
					}
				}
				_db.SaveChanges();
				return true;
			}
			else
			{
				return false;
			}

			
		}

		[HttpPost]
		[Route("[controller]/[action]/{id}")]
		public Boolean DeleteCampingPicture([FromRoute] int? id)
		{
			if (id != null)
			{
				var s =  _db.Camping_Area_Pictures.Where(W=>W.Id ==id).FirstOrDefault();
				_db.Camping_Area_Pictures.Remove(s);
				_db.SaveChanges();
				return true;
			}
			return false;

		}
	}
}
