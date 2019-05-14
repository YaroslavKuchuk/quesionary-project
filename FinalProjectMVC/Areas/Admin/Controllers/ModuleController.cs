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
        [HttpGet]
        public ActionResult Create()
        {
            var model = new ModuleVm();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(ModuleVm vm)
        {
            return View();
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
            var model = new DetailsModuleVm();
            model.Name = "TestModule";
            return View(model);
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ModuleVm vm = new ModuleVm();
            return View(vm);
        }

        [HttpPut]
        public ActionResult Edit(ModuleVm vm)
        {
            return View();
        }
    }
}