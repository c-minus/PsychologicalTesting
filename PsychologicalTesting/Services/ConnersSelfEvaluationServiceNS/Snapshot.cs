using Services.ConnersSelfEvaluationServiceNS;

namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS;

public class Snapshot
{
    public List<Subject>? States { get; set; }

    public Snapshot()
    {
        States = new List<Subject>();
    }
}
