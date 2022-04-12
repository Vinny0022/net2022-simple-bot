using SimpleBotCore.Logic;
using System.Collections.Generic;

namespace SimpleBotCore.Repositories
{
    public class QuestionMockRepository : IQuestionRepository
    {
        Dictionary<string, string> _questions = new Dictionary<string, string>();
        public void CadastrarPergunta(string pergunta)
        {
            _questions[pergunta] = pergunta;
        }

        //private void SaveQuestion(Question question)
        //{
        //    _questions[question.Id] = question;
        //}

        //public Question TryLoadQuestion(string question)
        //{
        //    if (Exists(question))
        //    {
        //        return GetQuestion(question);
        //    }

        //    return null;
        //}        

        //private Question GetQuestion(string question)
        //{
        //    return _questions[question];
        //}        

        //private bool Exists(string question)
        //{
        //    return _questions.ContainsKey(question);
        //}
    }
}
