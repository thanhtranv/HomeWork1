using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Business.Dtos
{
    public class EnrollmentDto : BaseDto
    {
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public int? Grade { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual StudentDto Student { get; set; }
        public virtual CourseDto Course { get; set; }
    }
}
