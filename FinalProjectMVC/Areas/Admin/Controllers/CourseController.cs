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
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            var model = new CourseVm();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(CourseVm vm)
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var models = new List<CourseVm>();
            return View(models);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = new DetailsCourseVm();
            model.Name = "TestCourse";
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
            CourseVm vm = new CourseVm();
            return View(vm);
        }

        [HttpPut]
        public ActionResult Edit(CourseVm vm)
        {
            return View();
        }
    }
}