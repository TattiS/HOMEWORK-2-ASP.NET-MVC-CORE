namespace Task2WebApi.Models
{
	public struct UserStruct
	{
		public FullPost LastPost { get; set; }
		public int LastPostCommentsCount { get; set; }
		public FullPost MostPopularByComms { get; set; }
		public FullPost MostPopularByLikes { get; set; }
		public int UnCompletedTasksCount { get; set; }
	}
}