using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TN_Core_Web_App.Services.ViewModels.Blog;
using TN_Core_Web_App.Services.ViewModels.Common;
using TN_Core_Web_App.Services.ViewModels.Product;

namespace TN_Core_Web_App.Models
{
    // home view model này chỉ dùng trên trang web . ( k liên quan đến các view model còn lại )
    public class HomeViewModel
    {
        public List<BlogViewModel> LastestBlogs { get; set; }
        public List<SlideViewModel> HomeSlides { get; set; }
        public List<ProductViewModel> HotProducts { get; set; }
        public List<ProductViewModel> TopSellProducts { get; set; }

        public List<ProductCategoryViewModel> HomeCategories { set; get; }

        public string Title { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
    }
}
