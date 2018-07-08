using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2WebApi.Models
{
	public class SomeEntity
	{
		[Required(ErrorMessage = "Не указан id")]
		public int Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public string Name { get; set; }
		public string Avatar { get; set; }
		[EmailAddress(ErrorMessage = "Некорректный адрес")]
		public string Email { get; set; }
		public IEnumerable<FullPost> Posts { get; set; }
		public IEnumerable<Todo> Todos { get; set; }
		public Address MyAddress { get; set; }
		public IEnumerable<Comment> Comments { get; set; }

		public override string ToString()
		{
			string result = $"Id:{Id} Created:{CreatedAt.ToShortDateString()}\nName:{Name}\nEmail:{Email}\nAddress:{MyAddress}\n";
			if (Todos != null && Todos.Count() > 0)
			{
				result += "\tToDos list:\n";
				foreach (var item in Todos)
				{
					result += item.ToString();
				}
				result += "\n";
			}
			if (Posts != null && Posts.Count() > 0)
			{
				result += "\tPosts list:\n";
				foreach (var item in Posts)
				{
					result += item.ToString();
				}
				result += "\n";
			}
			if (Comments != null && Comments.Count() > 0)
			{
				result += "\tComments list:\n";
				foreach (var item in Comments)
				{
					result += item.ToString();
				}
				result += "\n";
			}
			return result;
		}
	}
}
