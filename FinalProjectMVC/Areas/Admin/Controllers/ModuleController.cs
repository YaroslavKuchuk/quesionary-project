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
            var model = new CreateModuleVm();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(CreateModuleVm vm)
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

        [HttpPut]
        public ActionResult Edit(int id)
        {
            return View();
        }
    }
}