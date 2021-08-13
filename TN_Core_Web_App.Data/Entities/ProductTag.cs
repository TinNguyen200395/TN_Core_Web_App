using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TN_Core_Web_App.Infrastructure.SharedKernel;

namespace TN_Core_Web_App.Data.Entities
{
    [Table("ProductTags")]

    public class ProductTag : DomainEntity<int>
        {
            public int ProductId { get; set; }

            [StringLength(50)]
            [Column(TypeName = "varchar")]
            public string TagId { set; get; }

            [ForeignKey("ProductId")]
            public virtual Product Product { set; get; }

            [ForeignKey("TagId")]
            public virtual Tag Tag { set; get; }
        }
    }
