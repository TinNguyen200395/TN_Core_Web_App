using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TN_Core_Web_App.Services.ViewModels.Product;
using TN_Core_Web_App.Utilities.DTO;

namespace TN_Core_Web_App.Services.Interfaces
{
    public interface IProductService:IDisposable
    {
        List<ProductViewModel> GetAll();
        PagedResult<ProductViewModel> GetAllPaging(int? categoryId, string keyword, int page, int pageSize);

    }
}
