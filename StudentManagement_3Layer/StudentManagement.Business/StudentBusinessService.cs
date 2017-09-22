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
    public class StudentBusinessService : BaseBusinessService, IStudentBusinessService
    {
        private IRepository<StudentEntity> studentRepository;

        public StudentBusinessService(IRepository<StudentEntity> repo)
        {
            studentRepository = repo;
        }

        public void DeleteStudent(StudentDto studentDto)
        {
            var student = Mapper.Map<StudentEntity>(studentDto);

            studentRepository.Delete(student);
            studentRepository.SaveChanges();
        }

        public IList<StudentDto> GetAllStudents()
        {
            var student = studentRepository.GetAll();
            var studentDtos = (IList<StudentDto>)Mapper.Map(student, student.GetType(), typeof(IList<StudentDto>));
            return studentDtos;
        }

        public StudentDto GetStudentById(Guid Id)
        {
            var student = studentRepository.GetById(Id);
            return Mapper.Map<StudentEntity, StudentDto>(student);
        }

        public StudentDto InsertStudent(StudentDto studentDto)
        {
            var student = Mapper.Map<StudentEntity>(studentDto);
            student = studentRepository.Insert(student);
            studentRepository.SaveChanges();

            return Mapper.Map<StudentEntity, StudentDto>(student);
        }

        public IList<StudentDto> SearchStudentByName(string studentName, int pageIndex, int pageSize, out int total)
        {
            var student = studentRepository.Search(p => p.FristName.Contains(studentName), o => o.FristName, pageIndex, pageSize, out total);
            var studentDtos = (IList<StudentDto>)Mapper.Map(student, student.GetType(), typeof(IList<StudentDto>));

            return studentDtos;
        }

        public void UpdateStudent(StudentDto studentDto)
        {
            var student = Mapper.Map<StudentEntity>(studentDto);

            studentRepository.Update(student);
            studentRepository.SaveChanges();
        }
    }
}
