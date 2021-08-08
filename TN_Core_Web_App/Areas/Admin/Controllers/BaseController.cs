using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TN_Core_Web_App.Areas.Admin.Controllers
{ // tao ra base controller để kế thừa dùng chung cho các controller khác 
    [Area("Admin")]
    [Authorize]
    public class BaseController : Controller
    {
       
    }
}
