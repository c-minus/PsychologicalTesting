namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.Adhd;

public class AdhdInattentiveCalculator : IAdhdInattentiveIndex
{
	public AdhdInattentiveCalculator()
	{
		
	}
	public byte Calculate(List<Question> questions)
	{
		var rules = GetRules(questions);

		var count = rules.Count(x => x.IsMatch());

		return (byte)count;
	}

	public IEnumerable<AdhdRule> GetRules(List<Question> questions)
	{

		yield return new AdhdRule()
		{
			Name = "A1a",
			Value1 = questions.FirstOrDefault(x => x.Id == 31)!.Score,
			Value2 = questions.FirstOrDefault(x => x.Id == 39)?.Score,
			Predicate = (value1, value2) => value1 is 2 or  3 || value2 is 2 or 3
		};

		yield return new AdhdRule()
		{
			Name = "A1b",
			Value1 = questions.FirstOrDefault(x => x.Id == 63)!.Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 is 2 or 3
		};

		yield return new AdhdRule()
		{
			Name = "A1c",
			Value1 = questions.FirstOrDefault(x => x.Id == 42)!.Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 is 2 or 3
		};

		yield return new AdhdRule()
		{
			Name = "A1d",
			Value1 = questions.FirstOrDefault(x => x.Id == 61)!.Score,
			Value2 = questions.FirstOrDefault(x => x.Id == 17)?.Score,
			Predicate = (value1, value2) => value1 is 2 or 3 && value2 is 2 or 3
		};

		yield return new AdhdRule()
		{
			Name = "A1e",
			Value1 = questions.FirstOrDefault(x => x.Id == 21)!.Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 is 2 or 3
		};

		yield return new AdhdRule()
		{
			Name = "A1f",
			Value1 = questions.FirstOrDefault(x => x.Id == 51)!.Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 is 2 or 3
		};

		yield return new AdhdRule()
		{
			Name = "A1g",
			Value1 = questions.FirstOrDefault(x => x.Id == 5)!.Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 is 2 or 3
		};

		yield return new AdhdRule()
		{
			Name = "A1h",
			Value1 = questions.FirstOrDefault(x => x.Id == 77)!.Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 is 2 or 3
		};

		yield return new AdhdRule()
		{
			Name = "A1i",
			Value1 = questions.FirstOrDefault(x => x.Id == 32)!.Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 is 2 or 3
		};
	}
}


