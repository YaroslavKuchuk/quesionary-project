using FinalProjectMVC.Areas.Admin.Models.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProjectMVC.Areas.Admin.Controllers
{
    public class ModuleController : Controller
    {
        private static int _count = 2;
        private List<ModuleVm> models = new List<ModuleVm> {
            new ModuleVm{
                Id = 0,
                Name = "Module 1"
            },
            new ModuleVm{
                Id = 1,
                Name = "Module 2"
            }
        };

        [HttpGet]
        public ActionResult Create()
        {
            var model = new ModuleVm();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(ModuleVm vm)
        {
            vm.Id = _count++;
            models.Add(vm);
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var models = new List<ModuleVm>();
            return View(models);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var vm = models.FirstOrDefault(m => m.Id == id);
            var model = new DetailsModuleVm
            {
                Id = vm.Id,
                Name = vm.Name
            };
            return View(model);
        }

        [HttpDelete]
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

        [HttpPut]
        public ActionResult Edit(ModuleVm vm)
        {
            var model = models.FirstOrDefault(m => m.Id == vm.Id);
            models.Remove(model);
            models.Add(vm);
            return RedirectToAction("GetAll");
        }
    }
}