using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Task2WebApi.Models.DTO
{
	public class Query1DTO
	{
		[Required(ErrorMessage = "Не указан id")]
		public int UserId { get; set; }
		public IEnumerable <Query1Result> Result { get; set; }
	}
}
