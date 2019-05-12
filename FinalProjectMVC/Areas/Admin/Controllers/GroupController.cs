using FinalProject.Models.ViewModels;
using FinalProjectMVC.Areas.Admin.Models.Groups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProjectMVC.Areas.Admin.Controllers
{
    public class GroupController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            var model = new CreateGroupVm();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(CreateGroupVm vm)
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var models = new List<GroupVm>();
            return View(models);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = new GroupViewModel();
            model.Name = "TestGroup";
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