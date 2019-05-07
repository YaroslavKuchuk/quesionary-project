using FinalProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject.Repositories
{
    public class UserRepository
    {
        private List<User> userList = new List<User>
        {
            new User
            {
                Login = "test",
                Password = "test"

            }
        };

        public User Get(string login, string password)
        {
            return userList.SingleOrDefault(u => u.Login == login && u.Password == password);
        }
    }
}