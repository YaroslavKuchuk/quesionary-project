using FinalProjectMVC.Areas.Admin.Models.Lector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProjectMVC.Areas.Admin.Controllers
{
    public class LectorController : Controller
    {
        private static int _count = 2;
        private List<LectorVm> models = new List<LectorVm> {
            new LectorVm{
                Id = 0,
                FirstName = "LectorFN 1",
                LastName = "lectorLN 1"
            },
            new LectorVm{
                Id = 1,
                FirstName = "LectorFN 2",
                LastName = "lectorLN 2"
            }
        };

        [HttpGet]
        public ActionResult Create()
        {
            var model = new LectorVm();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(LectorVm vm)
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
            var model = new DetailsLectorVm
            {
                Id = vm.Id,
                FirstName = "LectorFN 1",
                LastName = "lectorLN 1",
                Courses = new List<Models.Courses.CourseVm> { new Models.Courses.CourseVm { Id = 0, Name = "Course 1" } },
                TestPassings = new List<Models.Test.TestPassingVm> { new Models.Test.TestPassingVm { Id = 0, Date = DateTime.Now, StudentName = "StudentFN 1" + "StudentLN 1", TestName = "Test 1"} },
                Groups = new List<Models.Groups.GroupVm> { new Models.Groups.GroupVm { Name = "Group 1" } },
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
        public ActionResult Edit(LectorVm vm)
        {
            var model = models.FirstOrDefault(m => m.Id == vm.Id);
            models.Remove(model);
            models.Add(vm);
            return RedirectToAction("GetAll");
        }
    }
}