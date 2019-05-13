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
    }
}