using FinalProjectFirstTest.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectFirstTest.Seller_ViewModel.Create_Camping_Area
{
	public class CampingAreaViewModel
	{
		public string Name { get; set; }
		public string Phone { get; set; }
		public Region Region { get; set; }
		public string Address { get; set; }
		public string Description { get; set; }
		public bool Breakfast { get; set; }
		public bool Lunch { get; set; }
		public bool Dinner { get; set; }
		public bool Public_Refrigerator { get; set; }
		public bool Tent_Equipment { get; set; }
		public bool Kitchen_Utensils { get; set; }
		public bool Canopy { get; set; }
		public bool Wifi { get; set; }
		public bool Night_Lighting { get; set; }
		public bool Power_Supply { get; set; }
		public bool Outdoor_Tables_Chairs { get; set; }
		public bool Canteen { get; set; }
		public bool Mattress { get; set; }
		public bool No_Equipment { get; set; }

		public bool IsCancel { get; set; }
		public List<IFormFile> Path { get; set; }
	}
}
