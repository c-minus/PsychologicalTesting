namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.Disorder
{
	public class BehaviorDisorderIndex : IBehaviorDisorderIndex
	{
		public byte Calculate(List<Question> questions)
		{
			var rules = GetRules(questions);

			var count = rules.Count(x => x.IsMatch());

			return (byte)count;
		}

		private IEnumerable<DisorderRule> GetRules(List<Question> questions)
		{
			yield return new DisorderRule()
			{
				Name = "A1",
				Value = questions.FirstOrDefault(x => x.Id == 25)!.Score,
				Predicate = (value) => value is 1 or 2 or 3
			};

			yield return new DisorderRule()
			{
				Name = "A2",
				Value = questions.FirstOrDefault(x => x.Id == 38)!.Score,
				Predicate = (value) => value is 1 or 2 or 3
			};

			yield return new DisorderRule()
			{
				Name = "A3",
				Value = questions.FirstOrDefault(x => x.Id == 59)!.Score,
				Predicate = (value) => value is 1 or 2 or 3
			};

			yield return new DisorderRule()
			{
				Name = "A4",
				Value = questions.FirstOrDefault(x => x.Id == 86)!.Score,
				Predicate = (value) => value is 1 or 2 or 3
			};

			yield return new DisorderRule()
			{
				Name = "A5",
				Value = questions.FirstOrDefault(x => x.Id == 47)!.Score,
				Predicate = (value) => value is 1 or 2 or 3
			};

			yield return new DisorderRule()
			{
				Name = "A6",
				Value = questions.FirstOrDefault(x => x.Id == 13)!.Score,
				Predicate = (value) => value is 1 or 2 or 3
			};

			yield return new DisorderRule()
			{
				Name = "A8",
				Value = questions.FirstOrDefault(x => x.Id == 72)!.Score,
				Predicate = (value) => value is 1 or 2 or 3
			};

			yield return new DisorderRule()
			{
				Name = "A9",
				Value = questions.FirstOrDefault(x => x.Id == 82)!.Score,
				Predicate = (value) => value is 1 or 2 or 3
			};

			yield return new DisorderRule()
			{
				Name = "A10",
				Value = questions.FirstOrDefault(x => x.Id == 78)!.Score,
				Predicate = (value) => value is 1 or 2 or 3
			};

			yield return new DisorderRule()
			{
				Name = "A11",
				Value = questions.FirstOrDefault(x => x.Id == 16)!.Score,
				Predicate = (value) => value is 1 or 2 or 3
			};

			yield return new DisorderRule()
			{
				Name = "A12",
				Value = questions.FirstOrDefault(x => x.Id == 52)!.Score,
				Predicate = (value) => value is 1 or 2 or 3
			};

			yield return new DisorderRule()
			{
				Name = "A13",
				Value = questions.FirstOrDefault(x => x.Id == 91)!.Score,
				Predicate = (value) => value is 1 or 2 or 3
			};

			yield return new DisorderRule()
			{
				Name = "A14",
				Value = questions.FirstOrDefault(x => x.Id == 8)!.Score,
				Predicate = (value) => value is 1 or 2 or 3
			};

			yield return new DisorderRule()
			{
				Name = "A15",
				Value = questions.FirstOrDefault(x => x.Id == 33)!.Score,
				Predicate = (value) => value is 1 or 2 or 3
			};
		}
	}
}

