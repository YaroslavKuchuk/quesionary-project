using FinalProject.EFLayer.DataModels;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject.DataLayer.Repositories
{
    public class QuestionTypeRepository
    {
        public IEnumerable<QuestionType> GetListOfQuestionTypes()
        {
            using (var context = new FinalProjectDBEntities1())
            {
                return context.QuestionTypes.ToList();
            }
        }

        public void AddQuestionType(QuestionType questiontype)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                context.QuestionTypes.Add(questiontype);
            }
        }

        public void DeleteQuestionType(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                QuestionType questiontype = context.QuestionTypes.Find(Id);
                context.QuestionTypes.Remove(questiontype);
            }
        }

        public QuestionType GetQuestionTypeById(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                return context.QuestionTypes.Find(Id);
            }
        }
    }
}
