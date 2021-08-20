using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TN_Core_Web_App.Data.Entities;
using TN_Core_Web_App.Data.IRepositories;

namespace TN_Core_Web_App.Data.EF.Responsitories
{
    public class BlogRepository : EFRepository<Blog, int>, IBlogRepository
    {
        public BlogRepository(AppDbContext context) : base(context)
        {
        }
    }
}
