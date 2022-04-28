using System.ComponentModel.DataAnnotations;

namespace FinalProjectFirstTest.Models
{
	public enum RoomType
	{
		[Display(Name = "單人房")]
		Single_Room,
		[Display(Name = "雙人房")]
		Double_Room,
		[Display(Name = "四人房")]
		Quad_Room,
		[Display(Name = "六人房")]
		Six_Person_Room,
		[Display(Name = "八人房")]
		Eight_Person_Room,
		[Display(Name = "十人房")]
		Ten_Person_Room,
		[Display(Name = "露營車(二人)")]
		Campervan_2,
		[Display(Name = "露營車(四人)")]
		Campervan_4,
		[Display(Name = "露營車(六人)")]
		Campervan_6,
		[Display(Name = "露營區(二人)")]
		Campsite_2,
		[Display(Name = "露營區(四人)")]
		Campsite_4,
		[Display(Name = "露營區(六人)")]
		Campsite_6,
		[Display(Name = "豪華露營(二人)")]
		Glamping_2,
		[Display(Name = "豪華露營(四人)")]
		Glamping_4,
		[Display(Name = "豪華露營(六人)")]
		Glamping_6,
	}
}