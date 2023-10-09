using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.AdhdConners3;

namespace PsychologicalTesting;

public class AdhdConners3Calculator : IAdhdConners3Calculator
{
    private readonly IEnumerable<AdhdConners3Rule> _rules;

    public AdhdConners3Calculator()
    {
        _rules = GetRules();
    }

    public AdhdConners3Index Calculate(List<Question> questions)
    {
        var items = new List<KeyValuePair<byte, byte>>();

        foreach (var rule in _rules)
        {
            foreach (var id in rule.Ids!)
            {
                var question = questions.FirstOrDefault(x => x.Id == id);

                if (question == null)
                {
                    throw new Exception($"Question with id {id} not found.");
                }

                rule.Apply(question.Score);
                items.Add(new KeyValuePair<byte, byte>(id, rule.Score));
            }
        }

        return new AdhdConners3Index
        {
            Items = items
        };
    }

    private IEnumerable<AdhdConners3Rule> GetRules()
    {
        yield return new AdhdConners3Rule
        {
            Ids = new List<byte> { 6, 9, 15, 21, 43, 63 },
            Func = GetRule1Transformation
        };

        yield return new AdhdConners3Rule
        {
            Ids = new List<byte> { 34, 50 },
            Func = GetRule1Transformation
        };

        yield return new AdhdConners3Rule
        {
            Ids = new List<byte> { 35, 61 },
            Func = GetRule1Transformation
        };
    }

    private byte GetRule1Transformation(byte initialScore)
    {
        if (initialScore == 0 || initialScore == 1)
        {
            return 0;
        }
        else if (initialScore == 2)
        {
            return 1;
        }
        else if (initialScore == 3)
        {
            return 2;
        }
        else
        {
            throw new Exception($"Invalid score: {initialScore}, expected between one and three.");
        }
    }
    private byte GetRule2Transformation(byte initialScore)
    {
        if (initialScore == 0 || initialScore == 1)
        {
            return 0;
        }
        else if (initialScore == 2 || initialScore == 3)
        {
            return 1;
        }
        else
        {
            throw new Exception($"Invalid score: {initialScore}, expected between one and three.");
        }
    }
    private byte GetRule3Transformation(byte initialScore)
    {
        if (initialScore == 0 || initialScore == 1)
        {
            return 0;
        }
        else if (initialScore == 2 || initialScore == 3)
        {
            return 2;
        }
        else
        {
            throw new Exception($"Invalid score: {initialScore}, expected between one and three.");
        }
    }
}
