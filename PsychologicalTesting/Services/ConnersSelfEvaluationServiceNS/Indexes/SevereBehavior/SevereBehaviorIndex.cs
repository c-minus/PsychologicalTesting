namespace PsychologicalTesting;

public class SevereBehaviorIndex
{
    public byte ConfrontationalTheftScore { get; set; }
    public byte PoliceProblemsScore { get; set; }
    public byte AnimalCrueltyScore { get; set; }
    public byte UsingGunsScore { get; set; }
    public byte FireStarterScore { get; set; }
    public byte BreakingAndEnteringScore { get; set; }

    public bool ConfrontationalTheft => ConfrontationalTheftScore >= 1;
    public bool PoliceProblems => PoliceProblemsScore >= 1;
    public bool AnimalCruelty => AnimalCrueltyScore >= 1;
    public bool UsingGuns => UsingGunsScore >= 1;
    public bool FireStarter => FireStarterScore >= 1;
    public bool BreakingAndEntering => BreakingAndEnteringScore >= 1;
}
