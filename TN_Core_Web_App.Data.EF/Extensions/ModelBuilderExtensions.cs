using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN_Core_Web_App.Data.EF.Extensions
{
    // Extensions method bắt buộc phải nằm trong static class 
    public static class ModelBuilderExtensions
    {
        // note( tham số đầu tiên modelBuilder ta truyên vào một cái entityConfiguration ta add nó vào modelbuilder 
        public static void AddConfiguration<TEntity>(
          this ModelBuilder modelBuilder,
          DbEntityConfiguration<TEntity> entityConfiguration) where TEntity : class
        {
            modelBuilder.Entity<TEntity>(entityConfiguration.Configure);
        }
    }

    // trong cái phương thức này ta có thuộc tính configure  để ta đẩy cái entity vào để lúc ta cần configuration ta chỉ cần using DbEntityConfiguration 
    public abstract class DbEntityConfiguration<TEntity> where TEntity : class
    {
        public abstract void Configure(EntityTypeBuilder<TEntity> entity);
    }
}
