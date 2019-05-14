﻿using FinalProjectMVC.Areas.Admin.Models.Groups;
using FinalProjectMVC.Areas.Admin.Models.Modules;
using FinalProjectMVC.Areas.Admin.Models.Teachers;
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

        public List<TeacherVm> teachersList { get; set; }

        public List<ModuleVm> modulesList { get; set; }

        public List<GroupVm> groupsList { get; set; }

        public DetailsCourseVm()
        {
            teachersList = new List<TeacherVm>();
            modulesList = new List<ModuleVm>();
            groupsList = new List<GroupVm>();
        }
    }
}