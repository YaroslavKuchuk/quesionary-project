using FinalProjectMVC.Areas.Admin.Models.Questions;
using FinalProjectMVC.Areas.Admin.Models.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectMVC.Areas.Admin.Models.Modules
{
    public class DetailsModuleVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int QuantityLessons { get; set; }
        public string CourseName { get; set; }
        public string TestName { get; set; }
        public virtual List<QuestionVm> Questions { get; set; }
        public virtual List<ThemeVm> Themes { get; set; }

        public DetailsModuleVm()
        {
            Questions = new List<QuestionVm>();
            Themes = new List<ThemeVm>();
        }
    }
}