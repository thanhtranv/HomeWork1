using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Data.Entities
{
    public class EnrollmentEntity : BaseEntity
    {
        
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public int? Grade { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual StudentEntity Student { get; set; }
        public virtual CourseEntity Course { get; set; }
    }
}
