using System.ComponentModel.DataAnnotations;

namespace Task2WebApi.Models.DTO
{
	public class Query5DTO
    {
		[Required(ErrorMessage = "Не указан id")]
		[Display(Name = "User Id")]
		public int UserId { get; set; }
		public UserStruct Result { get; set; }
	}
}
