using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProjectMVC.Areas.Admin.Models.Courses
{
    public class CreateCourseVm
    {
        [Required(ErrorMessage = "Введите название курса")]
        public string Name { get; set; }
    }
}