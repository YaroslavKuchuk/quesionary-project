using FinalProject.BusinessLogic.Services;
using FinalProject.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProjectMVC.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherService teacherService
            = new TeacherService();
    
        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult List()
        {
            var teachers = teacherService.GetTeacherList();

            var teacherViewModel = teachers.Select(x=>new TeacherViewModel(x));
            return View(teacherViewModel);
        }
    }
}