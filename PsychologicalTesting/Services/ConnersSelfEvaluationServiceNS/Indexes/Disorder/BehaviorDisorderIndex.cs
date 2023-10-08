namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.Disorder
{
	public class BehaviorDisorderIndex : IBehaviorDisorderIndex
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
				Value = questions.Where(x => x.Id == 25).FirstOrDefault().Score,
				Predicate = (value) => value == 1 || value == 2 || value == 3
			};

			yield return new DisorderRule()
			{
				Name = "A2",
				Value = questions.Where(x => x.Id == 38).FirstOrDefault().Score,
				Predicate = (value) => value == 1 || value == 2 || value == 3
			};

			yield return new DisorderRule()
			{
				Name = "A3",
				Value = questions.Where(x => x.Id == 59).FirstOrDefault().Score,
				Predicate = (value) => value == 1 || value == 2 || value == 3
			};

			yield return new DisorderRule()
			{
				Name = "A4",
				Value = questions.Where(x => x.Id == 86).FirstOrDefault().Score,
				Predicate = (value) => value == 1 || value == 2 || value == 3
			};

			yield return new DisorderRule()
			{
				Name = "A5",
				Value = questions.Where(x => x.Id == 47).FirstOrDefault().Score,
				Predicate = (value) => value == 1 || value == 2 || value == 3
			};

			yield return new DisorderRule()
			{
				Name = "A6",
				Value = questions.Where(x => x.Id == 13).FirstOrDefault().Score,
				Predicate = (value) => value == 1 || value == 2 || value == 3
			};

			yield return new DisorderRule()
			{
				Name = "A8",
				Value = questions.Where(x => x.Id == 72).FirstOrDefault().Score,
				Predicate = (value) => value == 1 || value == 2 || value == 3
			};

			yield return new DisorderRule()
			{
				Name = "A9",
				Value = questions.Where(x => x.Id == 82).FirstOrDefault().Score,
				Predicate = (value) => value == 1 || value == 2 || value == 3
			};

			yield return new DisorderRule()
			{
				Name = "A10",
				Value = questions.Where(x => x.Id == 78).FirstOrDefault().Score,
				Predicate = (value) => value == 1 || value == 2 || value == 3
			};

			yield return new DisorderRule()
			{
				Name = "A11",
				Value = questions.Where(x => x.Id == 16).FirstOrDefault().Score,
				Predicate = (value) => value == 1 || value == 2 || value == 3
			};

			yield return new DisorderRule()
			{
				Name = "A12",
				Value = questions.Where(x => x.Id == 52).FirstOrDefault().Score,
				Predicate = (value) => value == 1 || value == 2 || value == 3
			};

			yield return new DisorderRule()
			{
				Name = "A13",
				Value = questions.Where(x => x.Id == 91).FirstOrDefault().Score,
				Predicate = (value) => value == 1 || value == 2 || value == 3
			};

			yield return new DisorderRule()
			{
				Name = "A14",
				Value = questions.Where(x => x.Id == 8).FirstOrDefault().Score,
				Predicate = (value) => value == 1 || value == 2 || value == 3
			};

			yield return new DisorderRule()
			{
				Name = "A15",
				Value = questions.Where(x => x.Id == 33).FirstOrDefault().Score,
				Predicate = (value) => value == 1 || value == 2 || value == 3
			};
		}
	}
}

