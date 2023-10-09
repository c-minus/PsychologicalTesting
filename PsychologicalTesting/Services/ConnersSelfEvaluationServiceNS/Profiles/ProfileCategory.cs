namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Profiles;

public class ProfileCategory
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public List<AgeSegment>? AgeSegments { get; set; }
}