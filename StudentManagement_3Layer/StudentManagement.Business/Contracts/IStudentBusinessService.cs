using StudentManagement.Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Business.Contracts
{
    public interface IStudentBusinessService
    {
        IList<StudentDto> GetAllStudents();
        IList<StudentDto> SearchStudentByName(string studentName, int pageIndex, int pageSize, out int total);
        StudentDto InsertStudent(StudentDto studentDto);
        void UpdateStudent(StudentDto studentDto);
        void DeleteStudent(StudentDto studentDto);
        StudentDto GetStudentById(Guid Id);
    }
}
