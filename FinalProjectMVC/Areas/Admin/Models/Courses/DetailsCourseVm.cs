using FinalProjectMVC.Areas.Admin.Models.Groups;
using FinalProjectMVC.Areas.Admin.Models.Modules;
using FinalProjectMVC.Areas.Admin.Models.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectMVC.Areas.Admin.Models.Courses
{
    public class DetailsCourseVm
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<TeacherVm> teachersList { get; set; }

        public List<ModuleVm> modulesList { get; set; }

        public List<GroupVm> groupsList { get; set; }

        public DetailsCourseVm()
        {
            teachersList = new List<TeacherVm> { new TeacherVm { FirstName = "TeacherFN", LastName = "TeacherLN"} };
            modulesList = new List<ModuleVm> { new ModuleVm { Name = "Module 1"} };
            groupsList = new List<GroupVm> { new GroupVm { Name = "Group 1"} };
        }
    }
}