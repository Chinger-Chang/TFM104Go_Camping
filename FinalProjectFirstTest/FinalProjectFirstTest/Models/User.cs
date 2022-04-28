using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectFirstTest.Models
{
	public class User
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		[EmailAddress]
		public string Email { get; set; }

		public string Password { get; set; }

		
		public string Name { get; set; }

		
		[Phone]
		public string Phone { get; set; }

		[Required]
		public DateTime CreateDate { get; set; }

		[Required]
		public bool IsMailConfirm { get; set; }

		
		public string Salt { get; set; }

		public virtual ICollection<OrderDetail> OrderDetails { get; set; }
	}
}
