using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Data.Entities
{
    public class StudentEntity : BaseEntity
    {
        public string LastName { get; set; }
        public string FristName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime DOB { get; set; }
        

        public virtual ICollection<EnrollmentEntity> Enrollments { get; set; }
    }
}
