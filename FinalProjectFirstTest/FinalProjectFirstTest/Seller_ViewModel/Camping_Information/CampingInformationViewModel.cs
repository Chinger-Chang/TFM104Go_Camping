using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectFirstTest.Seller_ViewModel.Camping_Information
{
	public class CampingInformationViewModel
	{
		public string Camping_Area_Name { get; set; }
		public int Camping_AreaId { get; set; }
		public string Camping_AreaAddress { get; set; }

#nullable enable
		public string? AuditDescription { get; set; }
#nullable disable
		public bool IsAudit { get; set; }
		public string Camping_Area_Path { get; set; }
		public List<Myroom> Myrooms { get; set; }

	}

	public class Myroom
	{
		public int RoomId { get; set; }
		public int RoomCount { get; set; }
		public string RoomName { get; set; }
		public string Room_Path { get; set; }
	}
}
