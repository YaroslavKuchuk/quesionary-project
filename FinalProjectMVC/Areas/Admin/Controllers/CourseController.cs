using FinalProject.BusinessLogic.Services;
using FinalProject.EFLayer.DataModels;
using FinalProjectMVC.Areas.Admin.Models.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProjectMVC.Areas.Admin.Controllers
{
    public class CourseController : Controller
    {
        private static int _count = 2;
        private List<CourseVm> models = new List<CourseVm> {
            new CourseVm{
                Id = 0,
                Name = "Course 1"
            },
            new CourseVm{
                Id = 1,
                Name = "Course 2"
            }
        };

        [HttpGet]
        public ActionResult Create()
        {
            var model = new CourseVm();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(CourseVm vm)
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
            var model = new DetailsCourseVm {
                Id = vm.Id,
                Name = vm.Name,
                lectorsList = new List<Models.Lector.LectorVm> { new Models.Lector.LectorVm { FirstName = "LectorFN", LastName = "LectorLN" } },
                modulesList = new List<Models.Modules.ModuleVm> { new Models.Modules.ModuleVm { Name = "Module 1" } },
                groupsList = new List<Models.Groups.GroupVm> { new Models.Groups.GroupVm { Name = "Group 1" } },
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
        public ActionResult Edit(CourseVm vm)
        {
            var model = models.FirstOrDefault(m => m.Id == vm.Id);
            models.Remove(model);
            models.Add(vm);
            return RedirectToAction("GetAll");
        }
    }
}