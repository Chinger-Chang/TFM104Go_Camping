using FinalProjectFirstTest.Models;
using FinalProjectFirstTest.Seller_ViewModel.Camping_Information;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampingAreaTest330.Controllers
{
	public class Camping_InformationController : Controller
	{
		private readonly FinalProjectDbContext _db;

		public Camping_InformationController(FinalProjectDbContext db)
		{
			_db = db;
		}

		[Authorize(Roles = "Seller")]
		public IActionResult CampingInformation()
		{
			return View();
		}

		public object GetAllCamping_Area()
		{
			
			return _db.Camping_Areas.Select(s =>
			new
			{
				Id = s.Id,
				Name = s.Name
			});
		}
		[HttpGet]
		[Route("[controller]/[action]/{id?}")]
		public object GetAllInformation([FromRoute]int? id)
		{
			var sellerid = Int32.Parse(User.Claims.FirstOrDefault(x => x.Type == "Seller_Id").Value);
			//string cid = "";
			if (id == null)
			{
				if (HttpContext.Session.GetString("camping_area_id")==null)
				{
					var s = _db.Camping_Areas.Where(w => w.SellerId == sellerid).FirstOrDefault();
					if(s == null)
					{
						return false;
					}
					//HttpContext.Session.SetString("camping_area_id", s.ToString());
					id = s.Id;
				}
				else
				{
					id = Convert.ToInt32(HttpContext.Session.GetString("camping_area_id"));
				}
				
			}
			HttpContext.Session.SetString("camping_area_id", id.ToString());
			//id = Convert.ToInt32(HttpContext.Session.GetString("camping_area_id"));
			Console.WriteLine(id);
			var camp = _db.Camping_Areas.FirstOrDefault(x => x.Id == id);
			if (camp == null)
			{
				return false;
			}

			
			var mydata = new CampingInformationViewModel
			{
				Camping_AreaId = camp.Id,
				Camping_Area_Name = camp.Name,
				Camping_AreaAddress = camp.Address,
				IsAudit = camp.IsAudit,
				AuditDescription = camp.AuditDescription,
				//Camping_Area_Path = "/Camping_Area_Picture/" + camp.Camping_Area_Pictures.FirstOrDefault()?.Path
				Camping_Area_Path = "/Camping_Area_Picture/" +_db.Camping_Area_Pictures.Where(w => w.Camping_AreaId == camp.Id).FirstOrDefault()?.Path,
				//s = _db.Rooms.Where(s => s.Camping_AreaId == camp.Id).FirstOrDefault().Id,
				Myrooms = _db.Rooms.Where(w=>w.Camping_AreaId==camp.Id).Select(x => new Myroom
				{
					RoomId = x.Id,
					RoomName = x.Name,
					RoomCount = x.Count,
					//x.Room_Pictures.FirstOrDefault()?.Path
					Room_Path = "/Room_Picture/" + _db.Room_Pictures.Where(w=>w.RoomId==x.Id).FirstOrDefault().Path
				}).ToList()
			} ;

			return mydata;
			
		}

		[HttpPost]
		[Route("[controller]/[action]/{id}")]
		public Boolean DeleteRoom([FromRoute] int? id)
		{
			if(id!=null)
			{
				var b = _db.Rooms.Where(w => w.Id == id).FirstOrDefault().Camping_AreaId;
				HttpContext.Session.SetString("camping_area_id", b.ToString());
				var a =_db.Rooms.Where(w => w.Id == id).FirstOrDefault();
				_db.Rooms.Remove(a);
				_db.SaveChanges();
				return true;
			}
			return false;
			
		}

		[HttpPost]
		[Route("[controller]/[action]/{id}")]
		public Boolean DeleteCamping([FromRoute] int? id)
		{
			if (id != null)
			{
				var a = _db.Camping_Areas.Where(w => w.Id == id).FirstOrDefault();
				HttpContext.Session.SetString("camping_area_id", a.Id.ToString());
				_db.Camping_Areas.Remove(a);
				_db.SaveChanges();
				HttpContext.Session.Remove("camping_area_id");
				return true;
			}
			return false;

		}

	}

}
