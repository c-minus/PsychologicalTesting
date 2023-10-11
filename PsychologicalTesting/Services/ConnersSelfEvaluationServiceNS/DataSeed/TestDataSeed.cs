using Microsoft.AspNetCore.Components.Forms;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS;
using Services.ConnersSelfEvaluationServiceNS.DataSeed;

namespace Services.ConnersSelfEvaluationServiceNS.Data
{
    public class TestDataSeed : IDataSeed
    {
        public async Task<Subject> GetAsync(IBrowserFile file)
        {
           return await Task.FromResult(GetSubject()); 
        }

        private Subject GetSubject()
        {
            return new Subject
            {
                Id = "1",
                Name = "John Doe",
                Age = 30,
                IdentifyAsExcelValue = 1,
                Questions = GetQuestions().ToList()
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