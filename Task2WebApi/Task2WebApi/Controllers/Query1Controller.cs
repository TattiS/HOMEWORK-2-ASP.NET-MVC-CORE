using Microsoft.AspNetCore.Mvc;
using Task2WebApi.Models.DTO;
using Task2WebApi.Services;

namespace Task2WebApi.Controllers
{
	public class Query1Controller : Controller
    {
		[HttpGet]
        public IActionResult GetResult()
        {
            return View();
        }

		[HttpPost]
		public IActionResult GetResult(Query1DTO dataObject)
		{
			if (dataObject == null)
			{
				return NotFound();
			}

			if (!QueryService.IsUserExist(dataObject.UserId))
			{
				return NoContent();
			}
			
			return View(new Query1DTO { UserId = dataObject.UserId, Result = QueryService.Query1(dataObject.UserId) }) ;
		}
    }
}