using System;
namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.Adhd
{
	public interface IAdhdInattentiveIndex
	{
		byte Calculate(List<Question> questions);
	}
}

