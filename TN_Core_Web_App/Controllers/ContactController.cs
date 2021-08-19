using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TN_Core_Web_App.Controllers
{
    public class ContactController : Controller
    {
        [Route("contact.html")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
