namespace PsychologicalTesting;

public class AdhdConners3Rule
{
    public List<byte>? Ids { get; set; }
    public byte Score { get; private set; }

    public Func<byte, byte>? Func { get; set; }

    public void Apply(byte initialScore)
    {
        Score = Func!(initialScore);
    }
}
