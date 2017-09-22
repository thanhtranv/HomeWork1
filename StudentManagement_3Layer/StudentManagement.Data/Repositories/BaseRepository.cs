using StudentManagement.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity.Infrastructure;
using StudentManagement.Data.Entities;

namespace StudentManagement.Data.Repositories
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly IDbContext context;

        public BaseRepository(IDbContext context)
        {
            this.context = context;
        }

        private IDbSet<TEntity> GetEntities()
        {
            return this.context.Set<TEntity>();
        }

        public void Delete(TEntity entity)
        {
            var obj = GetById(entity.ID);
            if (obj != null)
            {
                GetEntities().Remove(obj);
            }
        }

        public void Dispose()
        {
            if (this.context != null)
            {
                this.context.Dispose();
            }
        }

        public IList<TEntity> GetAll()
        {
            return GetEntities().AsQueryable().ToList();
        }

        public TEntity GetById(Guid ID)
        {
            return GetEntities().AsQueryable().SingleOrDefault(x => x.ID == ID);
        }

        public TEntity Insert(TEntity entity)
        {
            if (entity.ID == Guid.Empty)
            {
                entity.ID = Guid.NewGuid();
            }
            return GetEntities().Add(entity);
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        public IList<TEntity> Search<TOrderBy>(System.Linq.Expressions.Expression<Func<TEntity, bool>> criteria, System.Linq.Expressions.Expression<Func<TEntity, TOrderBy>> orderBy, int pageIndex, int pageSize, out int total, SortOrder sortOrder = SortOrder.Ascending)
        {
            total = GetEntities().Where(criteria).AsQueryable().Count();

            return (sortOrder == SortOrder.Ascending)
                ? GetEntities().Where(criteria).AsQueryable().OrderBy(orderBy).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList()
                : GetEntities().Where(criteria).AsQueryable().OrderByDescending(orderBy).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        }

        public void Update(TEntity entity)
        {
            var obj = GetById(entity.ID);
            if (obj != null)
            {
                context.Entry(obj).CurrentValues.SetValues(entity);
            }
        }
    }
}
