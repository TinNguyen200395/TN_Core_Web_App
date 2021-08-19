using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TN_Core_Web_App.Controllers
{
    public class ProductController :Controller
    {
        [Route("products.html")]

        public IActionResult Index()
        {
            return View();
        }
        [Route("{alias}-c.{id}.html")]

        public IActionResult Catalog(int id , string keyword,int? pageSize , string sortBy, int page=1)
        {
            return View();
        }
    }
}
