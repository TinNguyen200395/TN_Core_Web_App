using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TN_Core_Web_App.Infrastructure.Interfaces
{
    /// <summary>
    /// 
    /// T là kiểu của entity , kiểu T là một class
    /// K là kiểu key , K sẽ là một kiểu dữ liệu
    /// IRespository để xây dựng các phương thức để sử dụng lại 
    /// params : Danh sách các tham số (có thể chuyền bao nhiêu tham số cũng được )
    /// Expression: là một biểu thức 
    /// Func : trong biểu thức ta truyền vào một func 
    /// object>>[]: trả về một object
    /// includeProperties: ví dụ ta cần tìm 1 product ta sẽ include ra thêm product categories 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="K"></typeparam>
    public interface IRepository<T, K> where T : class
    {
        T FindById(K id, params Expression<Func<T, object>>[] includeProperties);

        T FindSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

        IQueryable<T> FindAll(params Expression<Func<T, object>>[] includeProperties);

        IQueryable<T> FindAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

        void Add(T entity);

        void Update(T entity);

        void Remove(T entity);

        void Remove(K id);

        void RemoveMultiple(List<T> entities);
    }
}
