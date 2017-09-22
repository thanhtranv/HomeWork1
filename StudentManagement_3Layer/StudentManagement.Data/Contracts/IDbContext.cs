using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Data.Entities;
using System.Data.Entity.Infrastructure;

namespace StudentManagement.Data.Contracts
{
    public interface IDbContext : IDisposable
    {
        int SaveChanges();
        IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : BaseEntity;
    }
}
