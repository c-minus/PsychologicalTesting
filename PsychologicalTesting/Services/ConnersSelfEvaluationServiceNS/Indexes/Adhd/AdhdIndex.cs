namespace Services.ConnersSelfEvaluationServiceNS.Indexes.Adhd;

public class AdhdIndex
{
    public byte HyperActiveIndex { get; set; }
    public byte InattentiveIndex { get; set; }

    public bool IsProbablyBoth => IsProbablyHyperActive && IsProbablyInattentive;
    public bool IsProbablyHyperActive => HyperActiveIndex >= 6;
    public bool IsProbablyInattentive => InattentiveIndex >= 6;
}