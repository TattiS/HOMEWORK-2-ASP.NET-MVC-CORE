using System.ComponentModel.DataAnnotations;

namespace Task2WebApi.Models
{
	public struct UserStruct
	{
		[Display(Name = "Latest post ")]
		public FullPost LastPost { get; set; }
		[Display(Name = "Latest post comments ")]
		public int LastPostCommentsCount { get; set; }
		[Display(Name = "Popular by comments")]
		public FullPost MostPopularByComms { get; set; }
		[Display(Name = "Popular by likes")]
		public FullPost MostPopularByLikes { get; set; }
		[Display(Name = "Uncompleted to-do ")]
		public int UnCompletedTasksCount { get; set; }
	}
}