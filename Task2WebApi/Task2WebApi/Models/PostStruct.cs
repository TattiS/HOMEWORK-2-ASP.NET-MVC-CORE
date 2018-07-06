namespace Task2WebApi.Models
{
	public struct PostStruct
	{
		public Comment LongestComm { get; internal set; }
		public Comment LikestComm { get; internal set; }
		public int LowRatedCommsCount { get; internal set; }
	}
}