using Microsoft.AspNetCore.Components.Forms;

namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.FileManipulator;

public interface IFileManipulatorService
{
    public IEnumerable<Question> ReadFromStream(IBrowserFile file);
}