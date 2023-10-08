namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.PiAndNi;

public interface IPiAndNiIndexCalculator
{
    PiAndNiIndex Calculate(List<Question> questions);
}
