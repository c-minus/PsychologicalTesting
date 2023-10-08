namespace PsychologicalTesting;

public class DepresionIndex
{
    public byte UselessnessScore { get; set; }
    public byte LostOfInterestOrPleasureScore { get; set; }
    public byte SadnessOrIrritableScore { get; set; }
    public byte TiredOrLowEnergyScore { get; set; }

    public bool Uselessness => UselessnessScore >= 1;
    public bool LostOfInterestOrPleasure => LostOfInterestOrPleasureScore >= 1;
    public bool SadnessOrIrritable => SadnessOrIrritableScore >= 1;
    public bool TiredOrLowEnergy => TiredOrLowEnergyScore >= 1;
}
