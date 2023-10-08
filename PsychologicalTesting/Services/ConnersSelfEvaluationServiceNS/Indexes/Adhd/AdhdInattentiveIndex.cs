using Services.ConnersSelfEvaluationServiceNS.Indexes.Adhd;
namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.Adhd;

public class AdhdInattentiveIndex : IAdhdInattentiveIndex
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
			Name = "A1a",
			Value1 = questions.Where(x => x.Id == 31).FirstOrDefault().Score,
			Value2 = questions.Where(x => x.Id == 39).FirstOrDefault().Score,
			Predicate = (value1, value2) => value1 == 2 || value1 == 3 || value2 == 2 || value2 == 3
		};

		yield return new AdhdRule()
		{
			Name = "A1b",
			Value1 = questions.Where(x => x.Id == 63).FirstOrDefault().Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 == 2 || value1 == 3
		};

		yield return new AdhdRule()
		{
			Name = "A1c",
			Value1 = questions.Where(x => x.Id == 42).FirstOrDefault().Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 == 2 || value1 == 3
		};

		yield return new AdhdRule()
		{
			Name = "A1d",
			Value1 = questions.Where(x => x.Id == 61).FirstOrDefault().Score,
			Value2 = questions.Where(x => x.Id == 17).FirstOrDefault().Score,
			Predicate = (value1, value2) => (value1 == 2 || value1 == 3) && (value2 == 2 || value2 == 3)
		};

		yield return new AdhdRule()
		{
			Name = "A1e",
			Value1 = questions.Where(x => x.Id == 21).FirstOrDefault().Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 == 2 || value1 == 3
		};

		yield return new AdhdRule()
		{
			Name = "A1f",
			Value1 = questions.Where(x => x.Id == 51).FirstOrDefault().Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 == 2 || value1 == 3
		};

		yield return new AdhdRule()
		{
			Name = "A1g",
			Value1 = questions.Where(x => x.Id == 5).FirstOrDefault().Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 == 2 || value1 == 3
		};

		yield return new AdhdRule()
		{
			Name = "A1h",
			Value1 = questions.Where(x => x.Id == 77).FirstOrDefault().Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 == 2 || value1 == 3
		};

		yield return new AdhdRule()
		{
			Name = "A1i",
			Value1 = questions.Where(x => x.Id == 32).FirstOrDefault().Score,
			Value2 = null,
			Predicate = (value1, value2) => value1 == 2 || value1 == 3
		};
	}
}


