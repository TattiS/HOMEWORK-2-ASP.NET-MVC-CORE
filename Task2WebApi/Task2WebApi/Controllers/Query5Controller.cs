using Microsoft.AspNetCore.Mvc;
using Task2WebApi.Models.DTO;
using Task2WebApi.Services;

namespace Task2WebApi.Controllers
{
	public class Query5Controller : Controller
	{
		[HttpGet]
		public IActionResult GetResult()
		{
			return View();
		}

		[HttpPost]
		public IActionResult GetResult(Query5DTO dataObject)
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

			return View(new Query5DTO { UserId = dataObject.UserId, Result = QueryService.Query5(dataObject.UserId) });
		}
	}
}