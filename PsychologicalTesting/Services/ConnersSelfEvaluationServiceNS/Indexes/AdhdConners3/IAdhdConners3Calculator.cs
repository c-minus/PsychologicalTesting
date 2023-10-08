using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS;

namespace PsychologicalTesting;

public interface IAdhdConners3Calculator
{
    AdhdConners3Index Calculate(List<Question> questions);
}
