using FinalProjectMVC.Areas.Admin.Models.Answers;
using FinalProjectMVC.Areas.Admin.Models.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProjectMVC.Areas.Admin.Controllers
{
    public class QuestionController : Controller
    {
        private static int _count = 2;
        private List<QuestionVm> models = new List<QuestionVm> {
            new QuestionVm{
                Id = 0,
                Name = "Question 1",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum nulla eros, pellentesque in laoreet vitae, imperdiet non ligula. " +
                "Pellentesque nec orci vitae nisl semper ultricies vitae ac justo. Etiam congue sit amet nisi sed commodo. Ut pretium interdum enim id vulputate. " +
                "Etiam mattis mauris et purus viverra tempor. Donec facilisis faucibus risus et gravida. Etiam lobortis, ante a ultricies fermentum, " +
                "metus metus pulvinar nulla, id iaculis tellus ipsum ut nisl. Maecenas ac nibh sit amet nisi blandit pulvinar at ac dolor."
            },
            new QuestionVm{
                Id = 1,
                Name = "Question 2",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum nulla eros, pellentesque in laoreet vitae, imperdiet non ligula. " +
                "Pellentesque nec orci vitae nisl semper ultricies vitae ac justo. Etiam congue sit amet nisi sed commodo. Ut pretium interdum enim id vulputate. " +
                "Etiam mattis mauris et purus viverra tempor. Donec facilisis faucibus risus et gravida. Etiam lobortis, ante a ultricies fermentum, " +
                "metus metus pulvinar nulla, id iaculis tellus ipsum ut nisl. Maecenas ac nibh sit amet nisi blandit pulvinar at ac dolor."
            }
        };

        [HttpGet]
        public ActionResult Create()
        {
            var model = new QuestionVm();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(QuestionVm vm)
        {
            vm.Id = _count++;
            models.Add(vm);
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return View(models);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var vm = models.FirstOrDefault(m => m.Id == id);
            var model = new DetailsQuestionVm
            {
                Id = vm.Id,
                Name = vm.Name,
                Text = vm.Text,
                ModuleName = "Module 1",
                QuestionType = "Type 1",
                TestName = "Test 1",
                ThemeName = "Theme 1",
                MultichoiceAnswers = new List < MultichoiceAnswerVm >{ new MultichoiceAnswerVm { Id = 0, Name = "multi 1", Text = "Lorem ipsum dolor sit amet, " +
                "consectetur adipiscing elit. Vestibulum nulla eros, pellentesque in laoreet vitae, imperdiet non ligula. " +
                "Pellentesque nec orci vitae nisl semper ultricies vitae ac justo. Etiam congue sit amet nisi sed commodo. Ut pretium interdum enim id vulputate. " +
                "Etiam mattis mauris et purus viverra tempor. Donec facilisis faucibus risus et gravida. Etiam lobortis, ante a ultricies fermentum, " +
                "metus metus pulvinar nulla, id iaculis tellus ipsum ut nisl. Maecenas ac nibh sit amet nisi blandit pulvinar at ac dolor."} },
                TextAnswers = new List<TextAnswerVm> { new TextAnswerVm { Id = 0, Name = "TextAnswer 1", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Vestibulum nulla eros, pellentesque in laoreet vitae, imperdiet non ligula. " +
                "Pellentesque nec orci vitae nisl semper ultricies vitae ac justo. Etiam congue sit amet nisi sed commodo. Ut pretium interdum enim id vulputate. " +
                "Etiam mattis mauris et purus viverra tempor. Donec facilisis faucibus risus et gravida. Etiam lobortis, ante a ultricies fermentum, " +
                "metus metus pulvinar nulla, id iaculis tellus ipsum ut nisl. Maecenas ac nibh sit amet nisi blandit pulvinar at ac dolor."} }
            };
            return View(model);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var vm = models.FirstOrDefault(m => m.Id == id);
            models.Remove(vm);
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var vm = models.FirstOrDefault(m => m.Id == id);
            return View(vm);
        }

        [HttpPost]
        public ActionResult Edit(QuestionVm vm)
        {
            var model = models.FirstOrDefault(m => m.Id == vm.Id);
            models.Remove(model);
            models.Add(vm);
            return RedirectToAction("GetAll");
        }
    }
}