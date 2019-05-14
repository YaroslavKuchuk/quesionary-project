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
            var model = new GroupVm();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(GroupVm vm)
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
            var model = new DetailsGroupVm();
            model.Name = "TestGroup";
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
            GroupVm vm = new GroupVm();
            return View(vm);
        }

        [HttpPut]
        public ActionResult Edit(GroupVm vm)
        {
            return View();
        }
    }
}