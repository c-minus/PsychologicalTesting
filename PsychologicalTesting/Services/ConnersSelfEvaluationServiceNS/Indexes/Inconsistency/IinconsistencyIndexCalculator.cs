using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS;

namespace Services.ConnersSelfEvaluationServiceNS.Indexes
{
    public interface IinconsistencyIndexCalculator
    {
        public InconsistencyIndex Calculate(List<Question> questions);
    }
}