namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.PiAndNi;

public class PiAndNiIndexCalculator : IPiAndNiIndexCalculator
{
    public PiAndNiIndex Calculate(List<Question> questions)
    {
        var pi = questions.Where(q => q.Categories.Contains("PI")).Sum(q => q.Score);
        var ni = questions.Where(q => q.Categories.Contains("NI")).Sum(q => q.Score);

        return new PiAndNiIndex
        {
            Pi = (byte)pi,
            Ni = (byte)ni
        };
    }
}
