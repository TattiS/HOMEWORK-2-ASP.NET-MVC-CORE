using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task2WebApi.Models.DTO
{
    public class Query6DTO
    {
		[Required(ErrorMessage = "Не указан id")]
		[Display(Name = "User Id")]
		public int PostId { get; set; }
		public PostStruct Result { get; set; }
	}
}
