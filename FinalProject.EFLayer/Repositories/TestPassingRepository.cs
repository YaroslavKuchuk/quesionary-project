using FinalProject.EFLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataLayer.Repositories
{
    public class TestPassingRepository
    {
        public IEnumerable<TestPassing> GetListOfTestPassing()
        {
            using (var context = new FinalProjectDBEntities1())
            {
                return context.TestPassings.ToList();
            }
        }

        public void AddTestPassing(TestPassing testPassing)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                context.TestPassings.Add(testPassing);
            }
        }

        public void DeleteTestPassing(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                TestPassing testPassing = context.TestPassings.Find(Id);
                context.TestPassings.Remove(testPassing);
            }
        }

        public TestPassing GetTestPassingById(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                return context.TestPassings.Find(Id);
            }
        }
    }
}
