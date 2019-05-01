using FinalProject.EFLayer.DataModels;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject.DataLayer.Repositories
{
    public class UserTypeRepository
    {
        public IEnumerable<UserType> GetListOfUserType()
        {
            using (var context = new FinalProjectDBEntities1())
            {
                return context.UserTypes.ToList();
            }
        }

        public void AddUserType(UserType userType)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                context.UserTypes.Add(userType);
            }
        }

        public void DeleteUserType(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                UserType userType = context.UserTypes.Find(Id);
                context.UserTypes.Remove(userType);
            }
        }

        public UserType GetUserTypeById(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                return context.UserTypes.Find(Id);
            }
        }
    }
}

