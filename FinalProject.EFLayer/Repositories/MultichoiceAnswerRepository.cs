using FinalProject.EFLayer.DataModels;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject.DataLayer.Repositories
{
    public class MultichoiceAnswerRepository
    {
        public IEnumerable<MultichoiceAnswer> GetListOfMultiChoiceAnswers()
        {
            using (var context = new FinalProjectDBEntities1())
            {
                return context.MultichoiceAnswers.ToList();
            }
        }

        public void AddMultiChoiceAnswers(MultichoiceAnswer multiChoiseAnswer)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                context.MultichoiceAnswers.Add(multiChoiseAnswer);
            }
        }

        public void DeleteAddMultiChoiceAnswers(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                MultichoiceAnswer multiChoiceAnswer = context.MultichoiceAnswers.Find(Id);
                context.MultichoiceAnswers.Remove(multiChoiceAnswer);
            }
        }

        public MultichoiceAnswer GetMultiChoiceAnswerById(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                return context.MultichoiceAnswers.Find(Id);
            }
        }
    }
}

