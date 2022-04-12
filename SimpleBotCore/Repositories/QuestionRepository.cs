using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace SimpleBotCore.Repositories
{
    public class QuestionRepository //: IQuestionRepository
    {
        string _connectionString;
        public QuestionRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void CadastrarPergunta(string pergunta)
        {
            var cliente = new MongoClient(_connectionString);
            var db = cliente.GetDatabase("TestBot");
            var col = db.GetCollection<BsonDocument>("Pergunta");
            var doc = BsonDocument.Parse("{Pergunta: '" + pergunta + "'}");
            col.InsertOne(doc);
        }
    }
}
