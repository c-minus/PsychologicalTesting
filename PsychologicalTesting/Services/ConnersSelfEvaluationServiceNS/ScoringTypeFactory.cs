namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS
{
	public class ScoringTypeFactory : IScoringTypeFactory
	{
		public string Get(byte id)
		{
			if (id < 1 || id > 97)
			{
				throw new Exception($"Invalid question id, found:{id} expecting between 1 and 97");
			}

			switch (id)
			{
				case 1: return "3210";
				case 10:
				case 11:
				case 19:
				case 40:
				case 41: return "1100";
				case 12:
				case 93: return "1000";
				case 28: return "0011";
				case 37:
				case 48:
				case 54:
				case 75: return "0001";
				default: return "0123";
			}
		}

		/*
		   3210-> 1,
		   1100-> 10,11,19,40,41
		   1000-> 12,93
		   0011-> 28
		   0001-> 37,48,54,75
		*/
	}
}

