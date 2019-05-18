using FinalProjectMVC.Areas.Admin.Models.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectMVC.Areas.Admin.Models.Questions
{
    public class DetailsQuestionVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string ModuleName { get; set; }
        public string QuestionType { get; set; }
        public string TestName { get; set; }
        public string ThemeName { get; set; }

        public List<MultichoiceAnswerVm> MultichoiceAnswers { get; set; }
        public List<TextAnswerVm> TextAnswers { get; set; }
    }
}