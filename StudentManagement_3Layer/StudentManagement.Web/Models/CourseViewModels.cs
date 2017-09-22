using StudentManagement.Business.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentManagement.Web.Models
{
    public class CreateCourseViewModel
    {
        [Required]
        [Display (Name = "Course Name")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Credits")]
        public string Credits { get; set; }
    }

    public class DetailCourseViewModel
    {
        [Display(Name = "Course Name")]
        public string Title { get; set; }
       
        [Display(Name = "Credits")]
        public string Credits { get; set; }
    }

    public class DeleteCourseViewModel
    {
        [Display(Name = "Course Name")]
        public string Title { get; set; }

        [Display(Name = "Credits")]
        public string Credits { get; set; }
    }

    public class SearchCourseViewModel
    {
        public string TextSearch { get; set; }
        public IList<CourseDto> CourseDto { get; set; }
        public int Total { get; set; }
        public int CurrentPage { get; set; }
    }

    public class UpdateCourseViewModel
    {
        [Required]
        [Display(Name = "Course Name")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Credits")]
        public string Credits { get; set; }
    }
}