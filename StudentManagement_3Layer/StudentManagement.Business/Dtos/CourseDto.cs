using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Business.Dtos
{
    public class CourseDto : BaseDto
    {
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<EnrollmentDto> Enrollments { get; set; }
    }
}
