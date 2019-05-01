using System.Linq;
using FinalProject.BusinessLogic.Dto;
using FinalProject.EFLayer.DataModels;

namespace FinalProject.BusinessLogic.Extensions
{
    public static class CourseExtension
    {
        public static CourseDto ToCourseDto(this Course course)
        {
            if (course == null)
                return null;

            var courseDto = new CourseDto
            {
                Id = course.Id,
                Name = course.Name,
                GroupsList = course.Groups.Select(x => x.ToGroupDto()).ToList(),
                ModulesList = course.Modules.Select(x => x.ToModuleDto()).ToList(),
                TeachersList = course.Teachers.Select(x => x.ToTeacherDto()).ToList()
            };

            return courseDto;
        }
    }
}
