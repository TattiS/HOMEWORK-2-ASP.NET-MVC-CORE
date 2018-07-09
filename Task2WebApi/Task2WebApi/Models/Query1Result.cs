using System.ComponentModel.DataAnnotations;

namespace Task2WebApi.Models
{
	public class Query1Result
	{
		[Display(Name = "Post")]
		public FullPost PostItem { get; set; }
		[Display(Name = "Comments count")]
		public int CommentCount { get; set; }
	}
}