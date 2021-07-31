using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TN_Core_Web_App.Data.Enums;
using TN_Core_Web_App.Data.Interfaces;
using TN_Core_Web_App.Infrastructure.SharedKernel;

namespace TN_Core_Web_App.Data.Entities
{
    [Table("ProductCategories")]
    public class ProductCategory : DomainEntity<int>,
         IHasSeoMetaData, ISwitchable, ISortable, IDateTracking
    {
        public ProductCategory()
        {
            Products = new List<Product>();
        }
        public string Name { get; set; }

        public string Description { get; set; }

        public int? ParentId { get; set; }

        public int? HomeOrder { get; set; }

        public string Image { get; set; }

        public bool? HomeFlag { get; set; }

        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public int SortOrder { set; get; }
        public Status Status { set; get; }
        public string SeoPageTitle { set; get; }
        public string SeoAlias { set; get; }
        public string SeoKeywords { set; get; }
        public string SeoDescription { set; get; }

        public virtual ICollection<Product> Products { set; get; }
    }
}
