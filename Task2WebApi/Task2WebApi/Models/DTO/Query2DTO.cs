using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task2WebApi.Models.DTO
{
    public class Query2DTO
    {
		[Required(ErrorMessage = "Не указан id")]
		[Display(Name = "User Id")]
		public int UserId { get; set; }
		[Display(Name = "Comments")]
		public IEnumerable<Comment> Comments { get; set; }
	}
}
