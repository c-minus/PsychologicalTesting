namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Result;

public class ResultCalculator : IResultCalculator
{
    public Result? Calculate(Subject subject)
    {
        return new Result()
        {
            ResultT = GetResultT(subject).ToList(),
            ResultBool = GetResultBool(subject).ToList(),
            ResultOthers = GetResultOthers(subject).ToList()
        };
    }

    private IEnumerable<ResultCategory<bool?>> GetResultBool(Subject subject)
    {
        yield return new ResultCategory<bool?>()
        {
            Id = "1",
            Name = "Inconsistency Index",
            Value = !(subject?.InconsistencyIndex?.IsProbablyInvalid)
        };
        yield return new ResultCategory<bool?>()
        {
            Id = "2",
            Name = "Adhd Inattentive",
            Value = subject?.AdhdIndex?.IsProbablyInattentive
        };
        yield return new ResultCategory<bool?>()
        {
            Id = "3",
            Name = "Adhd HyperActive",
            Value = subject?.AdhdIndex?.IsProbablyHyperActive
        };
        yield return new ResultCategory<bool?>()
        {
            Id = "4",
            Name = "Adhd Combined",
            Value = subject?.AdhdIndex?.IsProbablyBoth
        };
        yield return new ResultCategory<bool?>()
        {
            Id = "5",
            Name = "Behavior Disorder",
            Value = subject?.DisorderIndex?.IsProbablyBehavior
        };
        yield return new ResultCategory<bool?>()
        {
            Id = "6",
            Name = "Opposition Disorder",
            Value = subject?.DisorderIndex?.IsProbablyOpposition
        };
        yield return new ResultCategory<bool?>()
        {
            Id = "7",
            Name = "Anxiety",
            Value = subject?.ScreeningIndex?.AnxietyIndex?.IsAnxiety
        };
        yield return new ResultCategory<bool?>()
        {
            Id = "7",
            Name = "Depression",
            Value = subject?.ScreeningIndex?.DepressionIndex?.IsDepression
        };
        yield return new ResultCategory<bool?>()
        {
            Id = "8",
            Name = "Severe Behavior",
            Value = subject?.SevereBehaviorIndex?.IsSevereBehavior
        };
    }

    private IEnumerable<ResultCategory<byte>> GetResultT(Subject subject)
    {
        foreach (var profileCategory in subject?.Profile?.Categories!)
        {
            var totalValue = subject?.Questions!
                .Where(q => q.Categories!.Contains(profileCategory.Id))
                .Sum(q => q.Score);

            var mappings = profileCategory?.AgeSegment?.Mappings;
            var max = mappings!.MaxBy(kvp => kvp.Key).Key;
            totalValue = totalValue > max ? max : totalValue;
            
            var scoreT = mappings!.FirstOrDefault(a => a.Key == totalValue).Value;

            yield return new ResultCategory<byte>()
            {
                Id = profileCategory!.Id,
                Name = profileCategory.Name,
                Value = (byte)scoreT!
            };
        }

        yield return new ResultCategory<byte>()
        {
            Id = "9",
            Name = "Adhd Conners3",
            Value = (byte)subject?.AdhdConners3Index?.TotalScore!
        };
    }

    private IEnumerable<ResultCategory<byte>> GetResultOthers(Subject subject)
    {
        yield return new ResultCategory<byte>()
        {
            Id = "10",
            Name = "School activities",
            Value = (byte)subject?.Questions?
                .First(q => q.Id is 95).Score!
        };
        yield return new ResultCategory<byte>()
        {
            Id = "11",
            Name = "Friendship/Relationship",
            Value = (byte)subject?.Questions?
                .First(q => q.Id is 96).Score!
        };
        yield return new ResultCategory<byte>()
        {
            Id = "12",
            Name = "Life at home",
            Value = (byte)subject?.Questions?
                .First(q => q.Id is 97).Score!
        };
        yield return new ResultCategory<byte>()
        {
            Id = "12",
            Name = "Adhd Conners3 Probability Percentage",
            Value = (byte)subject?.AdhdConners3Index?.Probability!
        };
    }
}