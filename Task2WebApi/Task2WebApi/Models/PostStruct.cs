using System.ComponentModel.DataAnnotations;

namespace Task2WebApi.Models
{
	public struct PostStruct
	{
		[Display(Name = "Longest comment")]
		public Comment LongestComm { get; internal set; }
		[Display(Name = "Likest comment")]
		public Comment LikestComm { get; internal set; }
		[Display(Name = "Low-rated comment(without likes and less 80)")]
		public int LowRatedCommsCount { get; internal set; }
	}
}