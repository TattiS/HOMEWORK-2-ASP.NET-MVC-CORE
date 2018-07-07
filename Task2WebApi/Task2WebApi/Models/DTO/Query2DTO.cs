using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task2WebApi.Models.DTO
{
    public class Query2DTO
    {
		public int UserId { get; set; }
		public IEnumerable<Comment> Comments { get; set; }
	}
}
