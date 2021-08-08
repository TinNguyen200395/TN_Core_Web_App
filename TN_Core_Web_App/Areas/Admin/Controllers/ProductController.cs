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
        IProductCategoryService _productCategoryService;

        IProductService _productService;
        public ProductController(IProductService productService , IProductCategoryService productCategoryService)
        {

            _productService = productService;
            _productCategoryService = productCategoryService;

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
        [HttpGet]
        public IActionResult GetAllCategories()
        {
            var model = _productCategoryService.GetAll();
            return new OkObjectResult(model);
        }

        [HttpGet]
        public IActionResult GetAllPaging(int? categoryId, string keyword, int page, int pageSize)
        {
            var model = _productService.GetAllPaging(categoryId, keyword, page, pageSize);
            return new OkObjectResult(model);
        }
        #endregion
    }
}
