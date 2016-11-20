using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<T, K>
    {
        IQueryable<T> AsQueryable();

        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        T GetById(K id);

        void Create(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
