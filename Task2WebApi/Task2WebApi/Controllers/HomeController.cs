using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task2WebApi.Models;

namespace Task2WebApi.Controllers
{
	public class HomeController : Controller
    {
        public IActionResult Index()
        {
			return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Данное домашнее задание основано на предыдущем. Для успешного выполнения домашнего задания вам понадобится: \n создать ASP.NET MVC Core приложение из темплейта Visual Studio при старте приложение должно получать набор открытых данных с помощью API запросов к https://5b128555d50a5c0014ef1204.mockapi.io/:endpoint \nдля каждой выборки создать отдельную страницу(выборки взять из предыдущего задания), результаты запросов выводить в таблицах. Если строка таблицы предполагает вложенные данные, то сделать возможность развернуть вложенные данные в еще одну маленькую таблицу(expand/ collapse).\n навигация между страницами должна осуществляться через меню \n задача на креативность: создать страницу, где будут отображены все исходные данные в красивом виде, т.е.Пользователи с их постами и комментариями под ними, и тд. \n для сущностей User, Post, Todo должны быть созданы отдельные страницы для просмотра информации.В других местах приложения имя пользователя, название поста, название todo-айтема должно быть кликабельно и вести на страницу сущности.";

            return View();
        }

       	public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
