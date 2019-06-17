using FinalProjectMVC.Areas.Admin.Models.Groups;
using FinalProjectMVC.Areas.Admin.Models.Modules;
using FinalProjectMVC.Areas.Admin.Models.Lector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectMVC.Areas.Admin.Models.Courses
{
    public class DetailsCourseVm
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<LectorVm> lectorsList { get; set; }

        public List<ModuleVm> modulesList { get; set; }

        public List<GroupVm> groupsList { get; set; }

        public DetailsCourseVm()
        {
            lectorsList = new List<LectorVm>();
            modulesList = new List<ModuleVm>();
            groupsList = new List<GroupVm>();
        }
    }
}