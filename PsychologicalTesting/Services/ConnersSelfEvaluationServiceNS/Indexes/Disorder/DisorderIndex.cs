using System;
namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.Disorder
{
	public class DisorderIndex
	{
		public byte BehaviorIndex { get; set; }
		public byte OppositionIndex { get; set; }

		public bool IsProbablyBehavior => BehaviorIndex >= 3;
		public bool IsProbablyOpposition => OppositionIndex >= 4;
	}
}

