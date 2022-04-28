using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectFirstTest.Seller_ViewModel.Order_Detail
{
	public class OrderDetailViewModel
	{
		public int OrderDetailId { get; set; }
		public string Name { get; set; }
		public string Phone { get; set; }
		public string CampingAreaName { get; set; }
		public string RoomType { get; set; }
		public string CheckInDate { get; set; }
		public string CheckOutDate { get; set; }
		public decimal Price { get; set; }
		public string Status { get; set; }
		public string CancelDate { get; set; }
	}
}
