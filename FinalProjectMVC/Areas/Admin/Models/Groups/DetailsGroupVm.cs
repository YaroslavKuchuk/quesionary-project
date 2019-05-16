using FinalProjectMVC.Areas.Admin.Models.Student;
using FinalProjectMVC.Areas.Admin.Models.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectMVC.Areas.Admin.Models.Groups
{
    public class DetailsGroupVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BeginigDate { get; set; }
        public string CourseName { get; set; }
        public virtual List<StudentVm> Students { get; set; }
        public virtual List<TeacherVm> Teachers { get; set; }

        public DetailsGroupVm()
        {
            Students = new List<StudentVm> { new StudentVm { FirstName = "StudentFN", LastName = "TeacherLN"  } };
            Teachers = new List<TeacherVm> { new TeacherVm { FirstName = "TeacherFN", LastName = "TeacherLN" } };
            CourseName = "Course 1";
            BeginigDate = DateTime.Now;
        }
    }
}