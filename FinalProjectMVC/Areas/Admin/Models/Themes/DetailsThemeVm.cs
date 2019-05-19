using FinalProjectMVC.Areas.Admin.Models.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectMVC.Areas.Admin.Models.Themes
{
    public class DetailsThemeVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ModuleName { get; set; }
        
        public List<QuestionVm> Questions { get; set; }

        public DetailsThemeVm()
        {
            Questions = new List<QuestionVm>();
        }
    }
}