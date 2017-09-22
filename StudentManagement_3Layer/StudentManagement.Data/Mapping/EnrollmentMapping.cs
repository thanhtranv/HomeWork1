using StudentManagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Data.Mapping
{
    public class EnrollmentMapping : EntityTypeConfiguration<EnrollmentEntity>
    {
        public EnrollmentMapping()
        {
            ToTable("Enrollment").HasKey(k => k.ID);
        }
    }
}
