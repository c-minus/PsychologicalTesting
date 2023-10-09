
using Services.ConnersSelfEvaluationServiceNS.Indexes.Adhd;

namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.Adhd;

public class AdhdHyperActiveCalculator : IAdhdHyperActiveIndex
{
	public byte Calculate(List<Question> questions)
	{
		var rules = GetRules(questions);

		var count = rules.Count(x => x.IsMatch());

		return (byte)count;
	}

	private IEnumerable<AdhdRule> GetRules(List<Question> questions)
	{
		yield return new AdhdRule()
		{
			Name = "A2a",
			Value1 = questions.FirstOrDefault(x => x.Id == 60)!.Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 == 2 || value1 == 3
		};

		yield return new AdhdRule()
		{
			Name = "A2b",
			Value1 = questions.FirstOrDefault(x => x.Id == 64)!.Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 is 2 or 3
		};

		yield return new AdhdRule()
		{
			Name = "A2c",
			Value1 = questions.FirstOrDefault(x => x.Id == 20)!.Score,
			Value2 = questions.FirstOrDefault(x => x.Id == 7)?.Score,
			Predicate = (value1, value2) => value1 == 2 || value1 == 3 || value2 == 2 || value2 == 3
		};

		yield return new AdhdRule()
		{
			Name = "A2d",
			Value1 = questions.FirstOrDefault(x => x.Id == 84)!.Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 is 2 or 3
		};

		yield return new AdhdRule()
		{
			Name = "A2e",
			Value1 = questions.FirstOrDefault(x => x.Id == 66)!.Score,
			Value2 = questions.FirstOrDefault(x => x.Id == 55)?.Score,
			Predicate = (value1, value2) => value1 is 1 or 2 or 3 || value2 is 2 or 3
		};

		yield return new AdhdRule()
		{
			Name = "A2f",
			Value1 = questions.FirstOrDefault(x => x.Id == 34)!.Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 is 2 or 3
		};

		yield return new AdhdRule()
		{
			Name = "A2g",
			Value1 = questions.FirstOrDefault(x => x.Id == 9)!.Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 is 2 or 3
		};

		yield return new AdhdRule()
		{
			Name = "A2h",
			Value1 = questions.FirstOrDefault(x => x.Id == 27)!.Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 == 2 || value1 == 3
		};

		yield return new AdhdRule()
		{
			Name = "A2i",
			Value1 = questions.FirstOrDefault(x => x.Id == 6)!.Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 is 2 or 3
		};
	}
}


