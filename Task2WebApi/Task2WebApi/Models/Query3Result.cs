using System.ComponentModel.DataAnnotations;

namespace Task2WebApi.Models
{
	public class Query3Result
	{
		[Display(Name = "Todo Id")]
		public int Id { get; set; }
		[Display(Name = "Todo name")]
		public string Name { get; set; }
	}
}