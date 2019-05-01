using FinalProject.BusinessLogic.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.ViewModels
{
    public class UserViewModel : UserDto
    {
        public UserViewModel() { }

        public UserViewModel(UserDto userDto)
        {
            Id = userDto.Id;
            FirstName = userDto.FirstName;
            LastName = userDto.LastName;
            Login = userDto.Login;
            Password = userDto.Password;
            AdminsList = userDto.AdminsList;
            StudentsList = userDto.StudentsList;
            TeachersList = userDto.TeachersList;
        }
    }
}
