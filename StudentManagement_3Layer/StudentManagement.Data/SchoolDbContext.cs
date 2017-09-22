using StudentManagement.Data.Contracts;
using StudentManagement.Data.Entities;
using StudentManagement.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Data
{
    public class SchoolDbContext : DbContext, IDbContext
    {
        public SchoolDbContext(string connectString) : base(connectString)
        {

        }

        public IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }

        public DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            return base.Entry(entity);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentMapping());
            modelBuilder.Configurations.Add(new CourseMapping());
            modelBuilder.Configurations.Add(new EnrollmentMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
