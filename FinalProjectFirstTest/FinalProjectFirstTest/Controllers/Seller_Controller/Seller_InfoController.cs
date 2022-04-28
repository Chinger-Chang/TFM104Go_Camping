using FinalProjectFirstTest.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectFirstTest.Controllers.Seller_Controller
{
	public class Seller_InfoController : Controller
	{
		private readonly FinalProjectDbContext _db;

		public Seller_InfoController(FinalProjectDbContext db)
		{
			_db = db;
		}

		[Authorize(Roles = "Seller")]
		public IActionResult SellerInfo()
		{
			return View();
		}

		public SellerInfoViewModel Get_SellerInfo()
		{
			var sellerid = Int32.Parse(User.Claims.FirstOrDefault(x => x.Type == "Seller_Id").Value);

			var seller = _db.Sellers.FirstOrDefault(f => f.Id == sellerid);

			return new SellerInfoViewModel
			{
				Email = seller.Email,
				Name = seller.Name,
				Phone = seller.Phone
			};
			
		}

		[HttpPost]
		public bool Edit_SellerInfo([FromBody]SellerInfoViewModel model)
		{
			var sellerid = Int32.Parse(User.Claims.FirstOrDefault(x => x.Type == "Seller_Id").Value);

			var seller = _db.Sellers.FirstOrDefault(f => f.Id == sellerid);

			seller.Name = model.Name;
			seller.Phone = model.Phone;
			_db.SaveChanges();
			return true;

		}

		[HttpPost]
		public bool Check_Password([FromBody] PasswordViewModel model)
		{
			var sellerid = Int32.Parse(User.Claims.FirstOrDefault(x => x.Type == "Seller_Id").Value);

			var seller = _db.Sellers.FirstOrDefault(f => f.Id == sellerid);

			string salt = seller.Salt;
			byte[] passwordAndSaltBytes = System.Text.Encoding.UTF8.GetBytes(model.Password + salt);
			byte[] hashBytes = new System.Security.Cryptography.SHA256Managed().ComputeHash(passwordAndSaltBytes);
			string hashString = Convert.ToBase64String(hashBytes);
			if(hashString == seller.Password)
			{
				return true;
			}
			else
			{
				return false;
			}

		}

		[HttpPost]
		public bool Change_Password([FromBody] PasswordViewModel model)
		{
			var sellerid = Int32.Parse(User.Claims.FirstOrDefault(x => x.Type == "Seller_Id").Value);

			var seller = _db.Sellers.FirstOrDefault(f => f.Id == sellerid);

			string salt = Guid.NewGuid().ToString();
			byte[] passwordAndSaltBytes = System.Text.Encoding.UTF8.GetBytes(model.Password + salt);
			byte[] hashBytes = new System.Security.Cryptography.SHA256Managed().ComputeHash(passwordAndSaltBytes);
			string hashString = Convert.ToBase64String(hashBytes);

			seller.Salt = salt;
			seller.Password = hashString;
			_db.SaveChanges();

			return true;

		}

		public class SellerInfoViewModel
		{
			public string Email { get; set; }

			public string Name { get; set; }

			public string Phone { get; set; }
		}

		public class PasswordViewModel
		{
			public string Password { get; set; }

		}
	}
}
