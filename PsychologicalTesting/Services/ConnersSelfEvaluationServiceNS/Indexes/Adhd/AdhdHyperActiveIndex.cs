
using Services.ConnersSelfEvaluationServiceNS.Indexes.Adhd;

namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.Adhd;

public class AdhdHyperActiveIndex : IAdhdHyperActiveIndex
{
	public byte Calculate(List<Question> questions)
	{
		var rules = GetRules(questions);

		var count = rules.Where(x => x.IsMatch()).Count();

		return (byte)count;
	}

	private IEnumerable<AdhdRule> GetRules(List<Question> questions)
	{
		yield return new AdhdRule()
		{
			Name = "A2a",
			Value1 = questions.Where(x => x.Id == 60).FirstOrDefault().Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 == 2 || value1 == 3
		};

		yield return new AdhdRule()
		{
			Name = "A2b",
			Value1 = questions.Where(x => x.Id == 64).FirstOrDefault().Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 == 2 || value1 == 3
		};

		yield return new AdhdRule()
		{
			Name = "A2c",
			Value1 = questions.Where(x => x.Id == 20).FirstOrDefault().Score,
			Value2 = questions.Where(x => x.Id == 7).FirstOrDefault().Score,
			Predicate = (value1, value2) => value1 == 2 || value1 == 3 || value2 == 2 || value2 == 3
		};

		yield return new AdhdRule()
		{
			Name = "A2d",
			Value1 = questions.Where(x => x.Id == 84).FirstOrDefault().Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 == 2 || value1 == 3
		};

		yield return new AdhdRule()
		{
			Name = "A2e",
			Value1 = questions.Where(x => x.Id == 66).FirstOrDefault().Score,
			Value2 = questions.Where(x => x.Id == 55).FirstOrDefault().Score,
			Predicate = (value1, value2) => value1 == 1 || value1 == 2 || value1 == 3 || value2 == 2 || value2 == 3
		};

		yield return new AdhdRule()
		{
			Name = "A2f",
			Value1 = questions.Where(x => x.Id == 34).FirstOrDefault().Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 == 2 || value1 == 3
		};

		yield return new AdhdRule()
		{
			Name = "A2g",
			Value1 = questions.Where(x => x.Id == 9).FirstOrDefault().Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 == 2 || value1 == 3
		};

		yield return new AdhdRule()
		{
			Name = "A2h",
			Value1 = questions.Where(x => x.Id == 27).FirstOrDefault().Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 == 2 || value1 == 3
		};

		yield return new AdhdRule()
		{
			Name = "A2i",
			Value1 = questions.Where(x => x.Id == 6).FirstOrDefault().Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 == 2 || value1 == 3
		};
	}
}


