using FinalProjectMVC.Areas.Admin.Models.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProjectMVC.Areas.Admin.Controllers
{
    public class StudentController : Controller
    {
        private static int _count = 2;
        private List<StudentVm> models = new List<StudentVm> {
            new StudentVm{
                Id = 0,
                FirstName = "StudentFN 1",
                LastName = "StudentLN 1"
            },
            new StudentVm{
                Id = 1,
                FirstName = "StudentFN 2",
                LastName = "StudentLN 2"
            }
        };

        [HttpGet]
        public ActionResult Create()
        {
            var model = new StudentVm();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(StudentVm vm)
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
            var model = new DetailsStudentVm
            {
                Id = vm.Id,
                FirstName = "StudentFN 1",
                LastName = "StudentLN 1",
                TestPassings = new List<Models.Test.TestPassingVm> { new Models.Test.TestPassingVm { Id = 0, Date = DateTime.Now, LectorName = "LectorFN 1 " + "LectorLN 1", TestName = "Test 1" } },
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
        public ActionResult Edit(StudentVm vm)
        {
            var model = models.FirstOrDefault(m => m.Id == vm.Id);
            models.Remove(model);
            models.Add(vm);
            return RedirectToAction("GetAll");
        }
    }
}