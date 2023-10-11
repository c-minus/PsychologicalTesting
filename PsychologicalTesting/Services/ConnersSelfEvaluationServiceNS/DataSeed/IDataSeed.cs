using Microsoft.AspNetCore.Components.Forms;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS;

namespace Services.ConnersSelfEvaluationServiceNS.DataSeed
{
    public interface IDataSeed
    {
        public Task<Subject> GetAsync(IBrowserFile file);
    }
}
