using FinalProjectMVC.Areas.Admin.Models.Modules;
using FinalProjectMVC.Areas.Admin.Models.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectMVC.Areas.Admin.Models.Test
{
    public class DetailsTestVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CourseName { get; set; }
        
        public List<ModuleVm> Modules { get; set; }
        public List<QuestionVm> Questions { get; set; }
        public List<TestPassingVm> TestPassings { get; set; }

        public DetailsTestVm()
        {
            Modules = new List<ModuleVm>();
            Questions = new List<QuestionVm>();
            TestPassings = new List<TestPassingVm>();
        }
    }
}