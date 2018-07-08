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
		public int UserId { get; set; }
		public IEnumerable<Comment> Comments { get; set; }
	}
}
