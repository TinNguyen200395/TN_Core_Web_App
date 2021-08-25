using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TN_Core_Web_App.Services.ViewModels.Product;

namespace TN_Core_Web_App.Models
{
    public class ShoppingCartViewModel
    {
        public ProductViewModel Product { set; get; }

        public int Quantity { set; get; }

        public decimal Price { set; get; }

        public int ColorId { get; set; }

        public int SizeId { get; set; }
        public ColorViewModel Color { get; set; }

        public SizeViewModel Size { get; set; }
    }
}
