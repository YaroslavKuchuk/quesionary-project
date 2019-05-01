using FinalProject.EFLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataLayer.Repositories
{
    public class ModuleRepository
    {

        public IEnumerable<Module> GetListOfModule()
        {
            using (var context = new FinalProjectDBEntities1())
            {
                return context.Modules.ToList();
            }
        }

        public void AddModule(Module module)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                context.Modules.Add(module);
            }
        }

        public void DeleteModule(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                Module module = context.Modules.Find(Id);
                context.Modules.Remove(module);
            }
        }

        public Module GetModuleById(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                return context.Modules.Find(Id);
            }
        }
    }
}
