using FinalProjectMVC.Areas.Admin.Models.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProjectMVC.Areas.Admin.Controllers
{
    public class ThemeController : Controller
    {
        private static int _count = 2;
        private List<ThemeVm> models = new List<ThemeVm> {
            new ThemeVm{
                Id = 0,
                Name = "Theme 1"
            },
            new ThemeVm{
                Id = 1,
                Name = "Theme 2"
            }
        };

        [HttpGet]
        public ActionResult Create()
        {
            var model = new ThemeVm();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(ThemeVm vm)
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
            var model = new DetailsThemeVm
            {
                Id = vm.Id,
                Name = vm.Name,
                ModuleName = "Module 1",
                Questions = new List<Models.Questions.QuestionVm> { new Models.Questions.QuestionVm { Id = 0, Name = "Qwestion 1", Text = "Lorem ipsum dolor sit amet, " +
                "consectetur adipiscing elit. Vestibulum nulla eros, pellentesque in laoreet vitae, imperdiet non ligula. " +
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
        public ActionResult Edit(ThemeVm vm)
        {
            var model = models.FirstOrDefault(m => m.Id == vm.Id);
            models.Remove(model);
            models.Add(vm);
            return RedirectToAction("GetAll");
        }
    }
}