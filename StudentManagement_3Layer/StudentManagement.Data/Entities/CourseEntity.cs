﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Data.Entities
{
    public class CourseEntity : BaseEntity
    {
        
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<EnrollmentEntity> Enrollments { get; set; }
    }
}
