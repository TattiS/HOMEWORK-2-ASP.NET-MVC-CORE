using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Task2WebApi.Models;
using Task2WebApi.Services;

namespace Task2WebApi.Controllers
{
    public class ShowController : Controller
    {
		[Route("[controller]")]
		[Route("[controller]/[action]")]
		public IActionResult GetAll()
        {
            return View(QueryService.GetEntitiesList());
        }

		[Route("[controller]/[action]/{id?}")]
		public IActionResult ShowUser(int id)
		{
			
			if (QueryService.IsUserExist(id))
			{
				return View(QueryService.GetEntities()?.FirstOrDefault(u => u.Id == id));
			}
			else
			{
				ViewData["NotFound"] = "Such user wasn't found.";
				return View();
			}
		}

		[Route("[controller]/[action]/{user?}")]
		public IActionResult UserS(SomeEntity user)
		{

			if (QueryService.IsUserExist(user.Id))
			{
				return View(QueryService.GetEntities()?.FirstOrDefault(u => u.Id == user.Id));
			}
			else
			{
				ViewData["NotFound"] = "Such user wasn't found.";
				return View();
			}
		}
		public IActionResult ShowPost(int id)
		{

			if (QueryService.IsPostExist(id))
			{
				return View(QueryService.GetEntities()?.SelectMany(p=>p.Posts).FirstOrDefault(u => u.Id == id));
			}
			else
			{
				ViewData["NotFound"] = "Such post wasn't found.";
				return View();
			}
		}

		
		public IActionResult ShowTodo(int id)
		{

			if (QueryService.IsTodoExist(id))
			{
				return View(QueryService.GetEntities()?.SelectMany(p => p.Todos).FirstOrDefault(u => u.Id == id));
			}
			else
			{
				ViewData["NotFound"] = "Such todo wasn't found.";
				return View();
			}
		}

		
		public IActionResult ShowComment(int id)
		{

			if (QueryService.IsCommentExist(id))
			{
				return View(QueryService.GetEntities()?.SelectMany(p => p.Comments).FirstOrDefault(u => u.Id == id));
			}
			else
			{
				ViewData["NotFound"] = "Such comment wasn't found.";
				return View();
			}
		}
	}
}