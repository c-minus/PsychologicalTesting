using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.AdhdConners3;

namespace PsychologicalTesting;

public interface IAdhdConners3Calculator
{
    AdhdConners3Index Calculate(List<Question> questions);
}
