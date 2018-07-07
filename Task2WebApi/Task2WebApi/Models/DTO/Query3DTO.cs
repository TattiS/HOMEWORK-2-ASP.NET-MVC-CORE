using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task2WebApi.Models.DTO
{
    public class Query3DTO
    {
		public int UserId { get; set; }
		public IEnumerable<Query3Result> Result { get; set; }
	}
}
