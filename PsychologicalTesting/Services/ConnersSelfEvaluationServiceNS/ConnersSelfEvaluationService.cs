using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS;
using Services.ConnersSelfEvaluationServiceNS.DataSeed;
using Services.ConnersSelfEvaluationServiceNS;
using Services.ConnersSelfEvaluationServiceNS.Indexes;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.PiAndNi;
using System.Text.Json;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.Adhd;
using Services.ConnersSelfEvaluationServiceNS.Indexes.Adhd;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.Disorder;

namespace PsychologicalTesting.Services;

public class ConnersSelfEvaluationService : IConnersSelfEvaluationService
{
	private readonly IDataSeed _data;
	private readonly IScoringTypeFactory _scoringTypeFactory;
	private readonly ICategoryTypeFactory _categoryFactory;
	private readonly IinconsistencyIndexCalculator _inconsistencyIndexCalculator;
	private readonly IPiAndNiIndexCalculator _piAndNiIndexCalculator;
	private readonly IAdhdHyperActiveIndex _adhdHyperActiveIndex;
	private readonly IAdhdInattentiveIndex _adhdInattentiveIndex;
	private readonly IBehaviorDisorderIndex _behaviorDisorderIndex;
	private readonly IOppositionDisorderIndex _oppositionDisorderIndex;
	private readonly IAdhdConners3Calculator _adhdConners3Calculator;

	private Snapshot snapshot = new Snapshot();

	public ConnersSelfEvaluationService
	(
		IScoringTypeFactory scoringTypeFactory,
		IDataSeed data,
		ICategoryTypeFactory categoryFactory,
		IinconsistencyIndexCalculator inconsistencyIndexCalculator,
		IPiAndNiIndexCalculator piAndNiIndexCalculator,
		IAdhdHyperActiveIndex adhdHyperActiveIndex,
		IAdhdInattentiveIndex adhdInattentiveIndex,
		IBehaviorDisorderIndex behaviorDisorderIndex,
		IOppositionDisorderIndex oppositionDisorderIndex,
		IAdhdConners3Calculator adhdConners3Calculator
	)
	{
		_data = data;
		_scoringTypeFactory = scoringTypeFactory;
		_categoryFactory = categoryFactory;
		_inconsistencyIndexCalculator = inconsistencyIndexCalculator;
		_piAndNiIndexCalculator = piAndNiIndexCalculator;
		_adhdHyperActiveIndex = adhdHyperActiveIndex;
		_adhdInattentiveIndex = adhdInattentiveIndex;
		_behaviorDisorderIndex = behaviorDisorderIndex;
		_oppositionDisorderIndex = oppositionDisorderIndex;
		_adhdConners3Calculator = adhdConners3Calculator;
	}

	public Snapshot Init()
	{
		try
		{
			var subject = _data.Get();
			CloneAndAddToSnapshot(subject, State.InitialData);

			ApplyScoringType(subject.Questions);
			CloneAndAddToSnapshot(subject, State.ScoringType);

			ApplyScore(subject.Questions);
			CloneAndAddToSnapshot(subject, State.Score);

			ApplyCategories(subject.Questions);
			CloneAndAddToSnapshot(subject, State.Categories);

			subject.InconsistencyIndex = _inconsistencyIndexCalculator.Calculate(subject.Questions);
			CloneAndAddToSnapshot(subject, State.InconsistencyIndex);

			subject.PiAndNiIndex = _piAndNiIndexCalculator.Calculate(subject.Questions);
			CloneAndAddToSnapshot(subject, State.PiAndNiIndex);

			subject.AdhdIndex = GetAdhdIndex(subject.Questions);
			CloneAndAddToSnapshot(subject, State.AdhdIndex);

			subject.DisorderIndex = GetDisorderIndex(subject.Questions);
			CloneAndAddToSnapshot(subject, State.DisorderIndex);

			subject.DeteriorationIndex = GetDeteriorationIndex(subject.Questions);
			CloneAndAddToSnapshot(subject, State.DeteriorationIndex);

			subject.AdhdConners3Index = _adhdConners3Calculator.Calculate(subject.Questions);
			CloneAndAddToSnapshot(subject, State.AdhdConners3Index);

			return snapshot;
		}
		catch (System.Exception ex)
		{

			throw;
		}
	}

	private void ApplyScoringType(List<Question> questions)
	{
		foreach (var question in questions)
		{
			question.ScoringType = _scoringTypeFactory.Get(question.Id);
		}
	}

	private void ApplyCategories(List<Question> questions)
	{
		foreach (var question in questions)
		{
			question.Categories = _categoryFactory.Get(question.Id);
		}
	}

	private void ApplyScore(List<Question> questions)
	{
		foreach (var question in questions)
		{
			question.Score = Convert.ToByte((question.ScoringType?[question.Answer - 1]).ToString());
		}
	}

	private AdhdIndex GetAdhdIndex(List<Question> questions)
	{
		var adhdIndex = new AdhdIndex
		{
			HyperActiveIndex = _adhdHyperActiveIndex.Calculate(questions),
			InattentiveIndex = _adhdInattentiveIndex.Calculate(questions)
		};

		return adhdIndex;
	}

	private DisorderIndex GetDisorderIndex(List<Question> questions)
	{
		var disorderIndex = new DisorderIndex
		{
			BehaviorIndex = _behaviorDisorderIndex.Calculate(questions),
			OppositionIndex = _oppositionDisorderIndex.Calculate(questions)
		};

		return disorderIndex;
	}

	private DeteriorationIndex GetDeteriorationIndex(List<Question> questions)
	{
		var deteriorationIndex = new DeteriorationIndex
		{
			School = questions.Where(q => q.Id == 95).FirstOrDefault().Score,
			Home = questions.Where(q => q.Id == 97).FirstOrDefault().Score,
			Friends = questions.Where(q => q.Id == 96).FirstOrDefault().Score
		};

		return deteriorationIndex;
	}

	private void CloneAndAddToSnapshot(Subject subject, State state)
	{
		subject.CurrentState = state;
		var serialized = JsonSerializer.Serialize(subject);
		var cloned = JsonSerializer.Deserialize<Subject>(serialized);

		snapshot.States.Add(cloned);
	}
}


