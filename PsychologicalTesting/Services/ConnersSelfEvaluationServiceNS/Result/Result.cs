namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Result;

public class Result
{
    public List<ResultCategory<byte>>? ResultT { get; set; }
    public List<ResultCategory<bool?>>? ResultBool { get; set; }
    public List<ResultCategory<byte>>? ResultOthers { get; set; }
}