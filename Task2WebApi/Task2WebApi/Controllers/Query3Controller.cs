using Microsoft.AspNetCore.Mvc;
using Task2WebApi.Models.DTO;
using Task2WebApi.Services;

namespace Task2WebApi.Controllers
{
	public class Query3Controller : Controller
    {
		[HttpGet]
		public IActionResult GetResult()
		{
			return View();
		}

		[HttpPost]
		public IActionResult GetResult(Query3DTO dataObject)
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
			return View(new Query3DTO { UserId = dataObject.UserId, Result = QueryService.Query3(dataObject.UserId) });
		}
	}
}