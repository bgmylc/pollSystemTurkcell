using Microsoft.EntityFrameworkCore;
using pollSystemTurkcell.Data;
using pollSystemTurkcell.Models;
using pollSystemTurkcell.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pollSystemTurkcell.Services
{
    public class QuestionService : IQuestionService
    {
        private pollSystemTurkcellDbContext dbContext;

        public QuestionService(pollSystemTurkcellDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Add(Question question)
        {
            dbContext.Questions.Add(question);
            dbContext.SaveChanges();
        }

        public void DeleteQuestion(Question question)
        {
            dbContext.Remove(question);
            dbContext.SaveChanges();
        }

        public Question GetQuestionByID(int quID)
        {
            return dbContext.Questions.Find(quID);
        }

        public List<Question> GetQuestionsByPollID(int pollID)
        {
            return dbContext.Questions.Where(q => q.PollID == pollID)
                                      .Include(p => p.Poll)
                                      .AsNoTracking().ToList();
        }

        public void UpdateQuestion(Question question)
        {
            dbContext.Entry(question).State = EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
