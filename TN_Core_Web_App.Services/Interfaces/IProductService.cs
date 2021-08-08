using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TN_Core_Web_App.Services.ViewModels.Product;

namespace TN_Core_Web_App.Services.Interfaces
{
    public interface IProductService:IDisposable
    {
        List<ProductViewModel> GetAll();

    }
}
