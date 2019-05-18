using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectMVC.Areas.Admin.Models.Answers
{
    public class TextAnswerVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
    }
}