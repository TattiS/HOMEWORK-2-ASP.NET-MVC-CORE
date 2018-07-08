using System.ComponentModel.DataAnnotations;

namespace Task2WebApi.Models.DTO
{
	public class Query5DTO
    {
		[Required(ErrorMessage = "Не указан id")]
		public int UserId { get; set; }
		public UserStruct Result { get; set; }
	}
}
