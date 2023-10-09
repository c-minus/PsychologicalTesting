using System;

namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.Disorder
{
	public class OppositionDisorderIndex : IOppositionDisorderIndex
	{
		public byte Calculate(List<Question> questions)
		{
			var rules = GetRules(questions);

			var count = rules.Where(x => x.IsMatch()).Count();

			return (byte)count;
		}

		private IEnumerable<DisorderRule> GetRules(List<Question> questions)
		{
			yield return new DisorderRule()
			{
				Name = "A1",
				Value = questions.FirstOrDefault(x => x.Id == 67)!.Score,
				Predicate = (value) => value == 2 || value == 3
			};

			yield return new DisorderRule()
			{
				Name = "A2",
				Value = questions.FirstOrDefault(x => x.Id == 24)!.Score,
				Predicate = (value) => value == 2 || value == 3
			};

			yield return new DisorderRule()
			{
				Name = "A3",
				Value = questions.FirstOrDefault(x => x.Id == 1)!.Score,
				Predicate = (value) => value == 2 || value == 3
			};

			yield return new DisorderRule()
			{
				Name = "A4",
				Value = questions.FirstOrDefault(x => x.Id == 3)!.Score,
				Predicate = (value) => value == 2 || value == 3
			};

			yield return new DisorderRule()
			{
				Name = "A5",
				Value = questions.FirstOrDefault(x => x.Id == 62)!.Score,
				Predicate = (value) => value == 2 || value == 3
			};

			yield return new DisorderRule()
			{
				Name = "A6",
				Value = questions.FirstOrDefault(x => x.Id == 74)!.Score,
				Predicate = (value) => value == 2 || value == 3
			};

			yield return new DisorderRule()
			{
				Name = "A7",
				Value = questions.FirstOrDefault(x => x.Id == 87)!.Score,
				Predicate = (value) => value == 2 || value == 3
			};

			yield return new DisorderRule()
			{
				Name = "A8",
				Value = questions.FirstOrDefault(x => x.Id == 94)!.Score,
				Predicate = (value) => value == 2 || value == 3
			};
		}
	}
}
