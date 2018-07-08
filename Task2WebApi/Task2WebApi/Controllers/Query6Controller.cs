using Microsoft.AspNetCore.Mvc;
using Task2WebApi.Models.DTO;
using Task2WebApi.Services;

namespace Task2WebApi.Controllers
{
	public class Query6Controller : Controller
    {
		[HttpGet]
		public IActionResult GetResult()
		{
			return View();
		}

		[HttpPost]
		public IActionResult GetResult(Query6DTO dataObject)
		{
			if (dataObject == null)
			{
				return NotFound();
			}

			if (!QueryService.IsPostExist(dataObject.PostId))
			{
				ViewBag.NotFound = true;
				return View();
			}

			return View(new Query6DTO { PostId = dataObject.PostId, Result = QueryService.Query6(dataObject.PostId) });
		}
	}
}