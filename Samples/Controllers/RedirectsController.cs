using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ActionResultsSamples.Controllers
{
    public class RedirectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sample1()
        {
            // перенаправление с помощью кода 302. Временное перенаправление.
            return Redirect("http://itvdn.com");
        }

        public IActionResult Sample2()
        {
            // перенаправление с помощью кода 302. Временное перенаправление.
            return Redirect("/home/index");
        }

        public IActionResult Sample3()
        {
            // перенаправление с помощью кода 301. Постоянное перенаправление.
            return RedirectPermanent("/home/index");
        }

        public IActionResult Sample4()
        {
            return RedirectToAction("Index"); // перенаправление на метод Index текущего контроллера
        }

        public IActionResult Sample5()
        {
            return RedirectToAction("Index", "Home"); // перенаправление на метод Index контроллера Home
        }

        public IActionResult Sample6()
        {
            // Перенаправление с использованием значений для переменных сегментов
            return RedirectToRoute(new { controller = "home", action = "index" });
        }
    }
}