using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductsModel()
        {
            var model = new List<ProductsModel>
            {
                new ProductsModel { Products = "Powerslide Imperial One 80 BLACK CRIMSON 2019", Price = 889, Descrip = "Imperial One 80 BLACK CRIMSON to znakomitej jakości rolki do jazdy freestylowej. Konstrukcję rolki oparto o aluminiową płozę i kółka spinner z łożyskami Wicked freespin ABEC 7. Zakładaj rolki na nogi i jedź zdobyć to miasto!"},
                new ProductsModel { Products = "FR FR3 80", Price = 889, Descrip = "FR Skates to nowość która pojawiła się w roku 2018, jednak nie trudno jest zauważyć, że to kontynuacja jednej z najbardziej cenionych marek z segmentu freeskatingu oraz freestyle slalom – Seba. Po latach eksperymentów z różnymi odmianami sprzętu do jazdy na rolkach, od aggressive, poprzez fitness, aż na jeździe szybkiej kończąc, Francuzi z Universkate dokonali przedefiniowania swojej linii produktów. FR Skates skupia się na tym, co stanowiło zawsze trzon oferty Seba – czyli solidnych rolkach do freeride oraz wysokiej klasy modelach do freestyle slalom."},
                new ProductsModel { Products = "Powerslide Next 80", Price = 949, Descrip = "Rolki Powerslide NEXT to nowa jakość w jeździe freeskate i urban. Jest to pierwsza w historii rolka oparta o pełną skorupę z nowatorskim montażem Trinity. Trzy punkty łączące szynę z butem umożliwiły konstruktorom obniżenie środka ciężkości w sposób do tej pory niespotykany w tego typu rolkach oraz podniesienie sztywności całej konstrukcji. Dzięki temu rolki NEXT dają kontrolę oraz efektywność przenoszenia energii odepchnięcia, które do tej pory były charakterystyczne jedynie dla droższych modeli freeskate, z jednoczęściowym butem."},
                
            };
            return View(model);
        }
    }
}
