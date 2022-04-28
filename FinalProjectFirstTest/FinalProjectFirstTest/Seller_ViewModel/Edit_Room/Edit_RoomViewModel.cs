using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectFirstTest.Seller_ViewModel.Edit_Room
{
	public class Edit_RoomViewModel
	{
		public string Name { get; set; }
		public int Count { get; set; }
		public string RoomType { get; set; }
		public string Description { get; set; }
		public decimal Price_Of_Weekdays { get; set; }
		public decimal Price_Of_Weekends { get; set; }
		public List<string> Path { get; set; }
		public List<int> PathId { get; set; }
	}
}
