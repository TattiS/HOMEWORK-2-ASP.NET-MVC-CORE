﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Task2WebApi.Services;

namespace Task2WebApi.Controllers
{
    public class ShowController : Controller
    {
        public IActionResult GetAll()
        {
            return View(QueryService.GetEntitiesList());
        }

		
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
	}
}