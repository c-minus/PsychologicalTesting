namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Result;

public class Result
{
    public bool IsInconsistent { get; set; }
    public Tresult? Tresult { get; set; }
    public bool IsAdhdInadvertently { get; set; }
    public bool IsAdhdHyperactiveAndImpulsive { get; set; }
    public bool IsAdhd { get; set; }
    public bool IsOppositionalDefiantDisorder { get; set; }
    public bool IsBehavioralDisorder { get; set; }
}