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
	}
}
