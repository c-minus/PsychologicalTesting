namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Profiles;

public class AgeSegment
{
    private readonly byte[] _interval;

    public List<KeyValuePair<byte,byte>> Mappings { get; set; } = new();

    public AgeSegment(byte[] interval)
    {
        _interval = interval;
    }

    public bool IsMatch(byte age)
    {
        return _interval.Contains(age);
    } 
}