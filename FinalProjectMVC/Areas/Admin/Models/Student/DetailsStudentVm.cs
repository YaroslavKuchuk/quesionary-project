using FinalProjectMVC.Areas.Admin.Models.Groups;
using FinalProjectMVC.Areas.Admin.Models.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectMVC.Areas.Admin.Models.Student
{
    public class DetailsStudentVm
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<TestPassingVm> TestPassings { get; set; }
        public List<GroupVm> Groups { get; set; }
    }
}