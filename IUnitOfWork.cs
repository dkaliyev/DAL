using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IUnitOfWork: IDisposable
    {
        IRepository<T,K> GetRepository<T, K>() where T: class, IEntity<K>;
        void Commit();
        void Rollback();
    }
}
