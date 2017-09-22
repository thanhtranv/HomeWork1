using StudentManagement.Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Business.Contracts
{
    public interface ICourseBusinessService
    {
        IList<CourseDto> GetAllCourses();
        IList<CourseDto> SearchCourseByName(string courseName, int pageIndex, int pageSize, out int total);
        CourseDto InsertCourse(CourseDto courseDto);
        void UpdateCourse(CourseDto courseDto);
        void DeleteCourse(CourseDto courseDto);
        CourseDto GetCourseById(Guid Id);
    }
}
