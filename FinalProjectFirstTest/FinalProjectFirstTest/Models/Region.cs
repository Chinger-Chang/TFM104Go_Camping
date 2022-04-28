using System.ComponentModel.DataAnnotations;

namespace FinalProjectFirstTest.Models
{
	public enum Region
	{
		[Display(Name ="基隆")]
		Keelung,
		[Display(Name = "新北市")]
		New_Taipei,
		[Display(Name = "台北市")]
		Taipei,
		[Display(Name = "桃園")]
		Taoyuan,
		[Display(Name = "新竹")]
		Hsinchu,
		[Display(Name = "苗栗")]
		Miaoli,
		[Display(Name = "台中")]
		Taichung,
		[Display(Name = "彰化")]
		Changhua,
		[Display(Name = "南投")]
		Nantou,
		[Display(Name = "雲林")]
		Yunlin,
		[Display(Name = "嘉義")]
		Chiayi,
		[Display(Name = "台南")]
		Tainan,
		[Display(Name = "高雄")]
		Kaohsiung,
		[Display(Name = "屏東")]
		Pingtung,
		[Display(Name = "宜蘭")]
		Yilan,
		[Display(Name = "花蓮")]
		Hualien,
		[Display(Name = "台東")]
		Taitung
	}
}