using System.Collections.Generic;

namespace Task2WebApi.Models.DTO
{
	public class Query1DTO
	{
		public int UserId { get; set; }
		public IEnumerable <Query1Result> Result { get; set; }
	}
}
