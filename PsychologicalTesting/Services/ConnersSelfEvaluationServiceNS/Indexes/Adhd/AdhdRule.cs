namespace Services.ConnersSelfEvaluationServiceNS.Indexes.Adhd;

public class AdhdRule
{
    public string? Name { get; set; }
    public byte Value1 { get; set; }
    public byte? Value2 { get; set; }

    public Func<byte, byte?, bool>? Predicate { get; set; }

    public bool IsMatch()
    {
        return Predicate(Value1, Value2);
    }
}