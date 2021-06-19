using pollSystemTurkcell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pollSystemTurkcell.Services.Interfaces
{
    public interface IQuestionService
    {
        List<Question> GetQuestionsByPollID(int pollID);
        Question GetQuestionByID(int quID);
        void Add(Question question);
        void DeleteQuestion(Question question);
        void UpdateQuestion(Question question);
    }
}
