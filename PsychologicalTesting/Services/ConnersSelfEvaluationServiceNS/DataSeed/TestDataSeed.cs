using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS;
using Services.ConnersSelfEvaluationServiceNS.DataSeed;

namespace Services.ConnersSelfEvaluationServiceNS.Data
{
    public class TestDataSeed : IDataSeed
    {
        public Subject Get()
        {
            return new Subject
            {
                Id = "1",
                Name = "John Doe",
                Age = 30,
                IdentifyAs = IdentifyAs.Male,
                Questions = GetQuestions().ToList(),
                CreatedAt = DateTime.Now
            };
        }

        private IEnumerable<Question> GetQuestions()
        {
            var rnd = new Random();

            for (int i = 1; i < 98; i++)
            {
                yield return new Question { Id = (byte)i, Answer = (byte)rnd.Next(1, 5) };
            }
        }
    }
}