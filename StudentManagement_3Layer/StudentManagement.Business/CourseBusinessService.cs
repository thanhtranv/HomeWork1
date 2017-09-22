using StudentManagement.Business.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Business.Dtos;
using StudentManagement.Data.Contracts;
using StudentManagement.Data.Entities;
using AutoMapper;

namespace StudentManagement.Business
{
    public class CourseBusinessService : BaseBusinessService, ICourseBusinessService
    {
        private IRepository<CourseEntity> courseRepository;

        public CourseBusinessService(IRepository<CourseEntity> repo)
        {
            courseRepository = repo;
        }

        public void DeleteCourse(CourseDto courseDto)
        {
            var course = Mapper.Map<CourseEntity>(courseDto);

            courseRepository.Delete(course);
            courseRepository.SaveChanges();
        }

        public IList<CourseDto> GetAllCourses()
        {
            var course = courseRepository.GetAll();
            var courseDtos = (IList<CourseDto>)Mapper.Map(course, course.GetType(), typeof(IList<CourseDto>));

            return courseDtos;
        }

        public CourseDto GetCourseById(Guid Id)
        {
            var course = courseRepository.GetById(Id);

            return Mapper.Map<CourseEntity, CourseDto>(course);
        }

        public CourseDto InsertCourse(CourseDto courseDto)
        {
            var course = Mapper.Map<CourseEntity>(courseDto);
            course = courseRepository.Insert(course);
            courseRepository.SaveChanges();

            return Mapper.Map<CourseEntity, CourseDto>(course);
        }

        public IList<CourseDto> SearchCourseByName(string courseName, int pageIndex, int pageSize, out int total)
        {
            var course = courseRepository.Search(p => p.Title.Contains(courseName), o => o.Title, pageIndex, pageSize, out total);
            var courseDtos = (IList<CourseDto>)Mapper.Map(course, course.GetType(), typeof(IList<CourseDto>));

            return courseDtos;
        }

        public void UpdateCourse(CourseDto courseDto)
        {
            var course = Mapper.Map<CourseEntity>(courseDto);

            courseRepository.Update(course);
            courseRepository.SaveChanges();
        }
    }
}
