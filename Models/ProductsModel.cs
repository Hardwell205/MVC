using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class ProductsModel
    {
        public string Products { get; set; }
        public decimal Price { get; set; }

        public string Currency = "zł";
        public string Descrip { get; set; }


    }
}
