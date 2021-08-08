using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TN_Core_Web_App.Data.Entities;
using TN_Core_Web_App.Data.IRepositories;

namespace TN_Core_Web_App.Data.EF.Responsitories
{
    public class ProductCategoryRepository : EFRepository <ProductCategory, int>, IProductCategoryRespository
    {
        AppDbContext _context;
        public ProductCategoryRepository(AppDbContext context):base(context)
        {
            _context = context;
        }

        public List<ProductCategory> GetByAlias(string alias)
        {
            return _context.ProductCategories.Where(x => x.SeoAlias == alias).ToList();
        }
    }
}
