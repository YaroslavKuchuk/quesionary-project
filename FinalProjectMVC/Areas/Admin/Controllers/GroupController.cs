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
        private static int _count = 2;
        private List<GroupVm> models = new List<GroupVm> {
            new GroupVm{
                Id = 0,
                Name = "Group 1"
            },
            new GroupVm{
                Id = 1,
                Name = "Group 2"
            }
        };

        [HttpGet]
        public ActionResult Create()
        {
            var model = new GroupVm();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(GroupVm vm)
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
            var model = new DetailsGroupVm
            {
                Id = vm.Id,
                Name = vm.Name
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
        public ActionResult Edit(GroupVm vm)
        {
            var model = models.FirstOrDefault(m => m.Id == vm.Id);
            models.Remove(model);
            models.Add(vm);
            return RedirectToAction("GetAll");
        }
    }
}