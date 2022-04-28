using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectFirstTest.Models
{
	public class Service
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[ForeignKey("Camping_Area")]
		public int Camping_AreaId { get; set; }

		[Required]
		public bool Breakfast { get; set; }

		[Required]
		public bool Lunch { get; set; }

		[Required]
		public bool Dinner { get; set; }

		[Required]
		public bool Public_Refrigerator { get; set; }

		[Required]
		public bool Tent_Equipment { get; set; }

		[Required]
		public bool Kitchen_Utensils { get; set; }

		[Required]
		public bool Canopy { get; set; }

		[Required]
		public bool Wifi { get; set; }

		[Required]
		public bool Night_Lighting { get; set; }

		[Required]
		public bool Power_Supply { get; set; }

		[Required]
		public bool Outdoor_Tables_Chairs { get; set; }

		[Required]
		public bool Canteen { get; set; }

		[Required]
		public bool Mattress { get; set; }

		[Required]
		public bool No_Equipment { get; set; }

		[Required]
		public bool IsCancel { get; set; }

		public virtual Camping_Area Camping_Area { get; set; }
	}
}
