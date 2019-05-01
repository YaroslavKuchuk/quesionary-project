using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLogic.Dto
{
    public class CourseDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<GroupDto> GroupsList { get; set; }

        public List<ModuleDto> ModulesList { get; set; }

        public List<TeacherDto> TeachersList { get; set; }
    }
}
