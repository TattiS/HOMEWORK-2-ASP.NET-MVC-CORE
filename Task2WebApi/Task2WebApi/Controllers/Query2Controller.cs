using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Task2WebApi.Models.DTO;
using Task2WebApi.Services;

namespace Task2WebApi.Controllers
{
    public class Query2Controller : Controller
    {
		[HttpGet]
        public IActionResult GetResult()
        {
            return View();
        }

		[HttpPost]
		public IActionResult GetResult(Query2DTO dataObject)
		{
			if (dataObject == null)
			{
				return NotFound();
			}
			
			if (!QueryService.IsUserExist(dataObject.UserId))
			{
				ViewBag.NotFound = true;
				return View();
			}
			return View(new Query2DTO { UserId = dataObject.UserId, Comments = QueryService.Query2(dataObject.UserId)});
		}
	}
}