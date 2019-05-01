using FinalProject.BusinessLogic.Services;
using FinalProject.EFLayer.DataModels;
using FinalProject.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FinalProjectMVC.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseSrvice
            = new CourseService();
        // GET: Course
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult List()
        {
            var course = _courseSrvice.GetCourseList();
            var courseViewModel = course.Select(x => new CourseViewModel(x));

            return View(courseViewModel);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Course course)
        {
            if(ModelState.IsValid)
            {
                _courseSrvice.Add(course);
                return View();
            }
            return View(course);         
        }

       
        public ActionResult Delete(int? Id)
        {           
            if(Id == null)
            {
                return View("Index");
            }
            _courseSrvice.Delete(Id);
            return View("Index");
        }

    }
}