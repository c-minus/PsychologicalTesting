namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.PiAndNi;

public class PiAndNiIndex
{
    public byte Pi { get; set; }
    public byte Ni { get; set; }
    public bool IsProbablyInvalidPi
    {
        get
        {
            return Pi >= 0 && Pi < 3;
        }
    }

    public bool IsProbablyInvalidNi
    {
        get
        {
            return Ni >= 0 && Ni < 3;
        }
    }
}
