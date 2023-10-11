namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Profiles;

public class AgeSegment
{
    // ReSharper disable once InconsistentNaming
    public readonly byte[] _interval;

    public List<KeyValuePair<byte, byte>> Mappings { get; set; } = new();

    public string? Interval { get; set; }

    public AgeSegment()
    {
    }

    public AgeSegment(byte[] interval)
    {
        _interval = interval;

        foreach (var item in _interval)
        {
            Interval += item + ",";
        }

        Interval = Interval?.Remove(Interval.Length - 1, 1);
    }

    public bool IsMatch(byte age)
    {
        return _interval.Contains(age);
    }
}