using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectMVC.Areas.Admin.Models.Questions
{
    public class QuestionVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
    }
}