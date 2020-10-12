using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using MVC.Models;

namespace MVC.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string StringValue()
        {
            return DateTime.Now.ToString();

        }
        public IActionResult yt()
        {
            return Redirect("http://www.youtube.com");
        }
        public IActionResult getJson()
        {
            return Json(new { Name = "Szymon", Surname = "Gliwa" });
        }
        public IActionResult TestModel() {
            var model = new List<TestModel> {
            new TestModel { TestMessage = "Wiadomość z Modelu 1" },
            new TestModel { TestMessage = "Wiadomość z Modelu 2" },
            new TestModel { TestMessage = "Wiadomość z Modelu 3" },
            };
            return View(model);
        }
    }
}
