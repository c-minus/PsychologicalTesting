namespace PsychologicalTesting;

public class AnxietyIndex
{
    public byte NervousOrAgitatedScore { get; set; }
    public byte IrritableScore { get; set; }
    public byte WorriedControlScore { get; set; }
    public byte WorriedScore { get; set; }

    public bool NervousOrAgitated => NervousOrAgitatedScore >= 1;
    public bool Irritable => IrritableScore >= 1;
    public bool WorriedControl => WorriedControlScore >= 1;
    public bool Worried => WorriedScore >= 1;
    
    public bool IsAnxiety => NervousOrAgitated || Irritable || WorriedControl || Worried;
}
