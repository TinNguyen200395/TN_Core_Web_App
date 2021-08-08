using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TN_Core_Web_App.Services.Interfaces;

namespace TN_Core_Web_App.Areas.Admin.Controllers
{

    public class ProductController : BaseController
    {
        IProductService _productService;
        public ProductController(IProductService productService)
        {

            _productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }
        #region AJAX API
        [HttpGet]
        public IActionResult GetAll()
        {
            var model = _productService.GetAll();
            return new OkObjectResult(model);
        }
        #endregion
    }
}
