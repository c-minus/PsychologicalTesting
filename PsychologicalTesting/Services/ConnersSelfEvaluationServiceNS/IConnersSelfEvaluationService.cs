using Microsoft.AspNetCore.Components.Forms;

namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS
{
    public interface IConnersSelfEvaluationService
    {
        public Task<Snapshot?> InitAsync(IBrowserFile file);
    }
}

