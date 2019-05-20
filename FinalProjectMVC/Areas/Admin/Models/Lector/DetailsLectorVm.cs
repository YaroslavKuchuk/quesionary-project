using FinalProjectMVC.Areas.Admin.Models.Courses;
using FinalProjectMVC.Areas.Admin.Models.Groups;
using FinalProjectMVC.Areas.Admin.Models.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectMVC.Areas.Admin.Models.Lector
{
    public class DetailsLectorVm
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<TestPassingVm> TestPassings { get; set; }
        public List<CourseVm> Courses { get; set; }
        public List<GroupVm> Groups { get; set; }

        public DetailsLectorVm()
        {
            TestPassings = new List<TestPassingVm>();
            Courses = new List<CourseVm>();
            Groups = new List<GroupVm>();
        }
    }
}