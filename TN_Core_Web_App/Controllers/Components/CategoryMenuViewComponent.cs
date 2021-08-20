using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TN_Core_Web_App.Services.Interfaces;

namespace TN_Core_Web_App.Controllers.Components
{
    public class CategoryMenuViewComponent:ViewComponent
    {
        private IProductCategoryService _productcategoryservice;
        public CategoryMenuViewComponent(IProductCategoryService productCategoryService)
        {
            _productcategoryservice = productCategoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_productcategoryservice.GetAll());
        }
    }
}
