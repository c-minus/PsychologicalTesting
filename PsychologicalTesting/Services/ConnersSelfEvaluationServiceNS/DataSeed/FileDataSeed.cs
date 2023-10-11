using Microsoft.AspNetCore.Components.Forms;
using MiniExcelLibs;
using Services.ConnersSelfEvaluationServiceNS.DataSeed;

namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.DataSeed
{
    public class FileDataSeed : IDataSeed
    {
        public async Task<Subject> GetAsync(IBrowserFile file)
        {
            MemoryStream ms = new();
            await file.OpenReadStream().CopyToAsync(ms);

            var sheetNames = ms.GetSheetNames();

            if (sheetNames.Count is not 2)
            {
                throw new Exception($"Expecting two sheets, found {sheetNames.Count}");
            }

            var subject =
                (await ms.QueryAsync<Subject>(sheetName: sheetNames[0]))
                .FirstOrDefault() ?? throw new Exception("Subject not found");

            subject.Questions =
                (await ms.QueryAsync<Question>(sheetName: sheetNames[1]))
                .ToList();

            if (subject.Questions.Count is not 97)
            {
                throw new Exception($"Expecting 97 questions, found {subject.Questions.Count}");
            }

            return subject;
        }
    }
}
