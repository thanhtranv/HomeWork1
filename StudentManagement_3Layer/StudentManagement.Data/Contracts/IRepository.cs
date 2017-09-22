using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Data.Contracts
{
    public interface IRepository<TEntity> : IDisposable
    {
        void Delete(TEntity entity);
        IList<TEntity> GetAll();
        TEntity GetById(Guid ID);
        TEntity Insert(TEntity entity);
        void Update(TEntity entity);
        void SaveChanges();
        IList<TEntity> Search<TOrderBy>(Expression<Func<TEntity, bool>> criteria, Expression<Func<TEntity, TOrderBy>> orderBy,
            int pageIndex, int pageSize, out int total, SortOrder sortOrder = SortOrder.Ascending);
    }
}
