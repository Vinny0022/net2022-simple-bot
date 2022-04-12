using SimpleBotCore.Logic;
using System.Collections.Generic;

namespace SimpleBotCore.Repositories
{
    public class QuestionMockRepository //: IQuestionRepository
    {
        Dictionary<string, string> _questions = new Dictionary<string, string>();
        public void CadastrarPergunta(string pergunta)
        {
            _questions[pergunta] = pergunta;
        }
        
    }
}
