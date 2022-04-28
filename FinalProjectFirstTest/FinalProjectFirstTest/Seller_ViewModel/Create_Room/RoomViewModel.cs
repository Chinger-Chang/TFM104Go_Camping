using FinalProjectFirstTest.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectFirstTest.Seller_ViewModel.Create_Room
{
	public class RoomViewModel
	{
		public string Name { get; set; }
		public int Count { get; set; }
		public RoomType RoomType { get; set; }
		public string Description { get; set; }
		public decimal Price_Of_Weekdays { get; set; }
		public decimal Price_Of_Weekends { get; set; }
		public List<IFormFile> Path { get; set; }
	}
}
