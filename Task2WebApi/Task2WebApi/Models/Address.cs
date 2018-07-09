using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2WebApi.Models
{
	public class Address
	{
		public int Id { get; set; }
		[Display(Name = "Country")]
		public string Country { get; set; }
		[Display(Name = "City")]
		public string City { get; set; }
		[Display(Name = "Street")]
		public string Street { get; set; }
		[Display(Name = "Zip")]
		public string Zip { get; set; }
		[Display(Name = "User Id")]
		public int UserId { get; set; }

		public override string ToString()
		{
			return $"{Street}\n{City}\n{Country}\n{Zip}";
		}
	}
}
