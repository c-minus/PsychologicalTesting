namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Result;

public interface IResultCalculator
{ 
    Result? Calculate(Subject subject);
}