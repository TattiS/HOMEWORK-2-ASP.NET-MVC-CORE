using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Task2WebApi.Models;
using Task2WebApi.Services;

namespace Task2WebApi.Controllers
{
    public class Query4Controller : Controller
    {
		[HttpGet]
		public IActionResult GetResult()
		{
			return View();
		}

		[HttpPost, ActionName("GetResult")]
		public IActionResult GetQueryResult()
		{
			return View(QueryService.Query4());
		}
	}
}