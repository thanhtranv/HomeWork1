using Autofac;
using StudentManagement.Data.Contracts;
using StudentManagement.Data.Entities;
using StudentManagement.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Data
{
    public class DataModule : Module
    {
        private string connectionString;

        public DataModule(string connString)
        {
            connectionString = connString;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new SchoolDbContext(this.connectionString)).As<IDbContext>().InstancePerRequest();
            RegisterRepository<StudentEntity>(builder);
            RegisterRepository<CourseEntity>(builder);
            RegisterRepository<EnrollmentEntity>(builder);

            base.Load(builder);
        }

        private void RegisterRepository<TEntity>(ContainerBuilder builder) where TEntity : BaseEntity
        {
            builder.RegisterType<BaseRepository<TEntity>>().As<IRepository<TEntity>>().InstancePerRequest();
        }
    }
}
