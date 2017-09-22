using Autofac;
using AutoMapper;
using StudentManagement.Business.Contracts;
using StudentManagement.Business.Dtos;
using StudentManagement.Data;
using StudentManagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Business
{
    public class BusinessModule : Module
    {
        private string connectionString;
        public BusinessModule(string connString)
        {
            connectionString = connString;
            
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StudentBusinessService>().As<IStudentBusinessService>().InstancePerRequest();
            builder.RegisterType<CourseBusinessService>().As<ICourseBusinessService>().InstancePerRequest();

            builder.RegisterModule(new DataModule(connectionString));
            base.Load(builder);
        }

        private void RegisterMapper()
        {
            Mapper.CreateMap<BaseEntity, BaseDto>();
            Mapper.CreateMap<BaseDto, BaseEntity>();

            Mapper.CreateMap<StudentEntity, StudentDto>();
            Mapper.CreateMap<StudentDto, StudentEntity>();

            Mapper.CreateMap<CourseEntity, CourseDto>();
            Mapper.CreateMap<CourseDto, CourseEntity>();

            Mapper.CreateMap<EnrollmentEntity, EnrollmentDto>();
            Mapper.CreateMap<EnrollmentDto, EnrollmentEntity>();
        }
    }
}
