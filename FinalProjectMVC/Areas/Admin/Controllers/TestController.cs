using FinalProjectMVC.Areas.Admin.Models.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProjectMVC.Areas.Admin.Controllers
{
    public class TestController : Controller
    {
        private static int _count = 2;
        private List<TestVm> models = new List<TestVm> {
            new TestVm{
                Id = 0,
                Name = "Test 1"
            },
            new TestVm{
                Id = 1,
                Name = "Test 2"
            }
        };

        [HttpGet]
        public ActionResult Create()
        {
            var model = new TestVm();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(TestVm vm)
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
            var model = new DetailsTestVm
            {
                Id = vm.Id,
                Name = vm.Name,
                CourseName = "Course 1",
                Modules = new List<Models.Modules.ModuleVm> { new Models.Modules.ModuleVm { Id = 0, Name = "Module 1"} },
                Questions = new List<Models.Questions.QuestionVm> { new Models.Questions.QuestionVm { Id = 0,
                Name = "Question 1",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum nulla eros, pellentesque in laoreet vitae, imperdiet non ligula. " +
                "Pellentesque nec orci vitae nisl semper ultricies vitae ac justo. Etiam congue sit amet nisi sed commodo. Ut pretium interdum enim id vulputate. " +
                "Etiam mattis mauris et purus viverra tempor. Donec facilisis faucibus risus et gravida. Etiam lobortis, ante a ultricies fermentum, " +
                "metus metus pulvinar nulla, id iaculis tellus ipsum ut nisl. Maecenas ac nibh sit amet nisi blandit pulvinar at ac dolor."} },
                TestPassings = new List<TestPassingVm> { new TestPassingVm { Id = 0, Date = DateTime.Now, StudentName = "Student1", LectorName = "Lector 1", TestName = vm.Name} }
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
        public ActionResult Edit(TestVm vm)
        {
            var model = models.FirstOrDefault(m => m.Id == vm.Id);
            models.Remove(model);
            models.Add(vm);
            return RedirectToAction("GetAll");
        }
    }
}