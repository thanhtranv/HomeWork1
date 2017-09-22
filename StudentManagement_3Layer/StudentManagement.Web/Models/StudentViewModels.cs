using StudentManagement.Business.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentManagement.Web.Models
{
    public class CreateStudentViewModel
    {
        [Required]
        [Display (Name = "Frist Name")]
        public string FristName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public string DOB { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
    }

    public class DetailStudentViewModel
    {
        [Display(Name = "Frist Name")]
        public string FristName { get; set; }
        
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        
        [Display(Name = "Date of Birth")]
        public string DOB { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Display(Name = "Enrollment Date")]
        public string EnrollmentDate { get; set; }

        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [Display(Name = "Grade")]
        public int Grade { get; set; }
    }

    public class DeleteStudentViewModel
    {
        [Display(Name = "Frist Name")]
        public string FristName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Date of Birth")]
        public string DOB { get; set; }
    }

    public class SearchStudentViewModel
    {
        public string TextSearch { get; set; }
        public IList<StudentDto> StudentDto { get; set; }
        public int Total { get; set; }
        public int CurrentPage { get; set; }
    }

    public class UpdateStudentViewModel
    {
        [Required]
        [Display(Name = "Frist Name")]
        public string FristName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public string DOB { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
    }
}