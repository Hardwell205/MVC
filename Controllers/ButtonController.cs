using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    
    public class ButtonController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
