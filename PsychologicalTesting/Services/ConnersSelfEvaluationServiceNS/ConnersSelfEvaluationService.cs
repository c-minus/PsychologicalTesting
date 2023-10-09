using System.Text.Json;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.Adhd;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.Disorder;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.PiAndNi;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.Screening;
using Services.ConnersSelfEvaluationServiceNS;
using Services.ConnersSelfEvaluationServiceNS.DataSeed;
using Services.ConnersSelfEvaluationServiceNS.Indexes;
using Services.ConnersSelfEvaluationServiceNS.Indexes.Adhd;

namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS;

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

	private readonly Snapshot? _snapshot = new();

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
		_data = data ?? throw new ArgumentNullException(nameof(data));
		_scoringTypeFactory = scoringTypeFactory ?? throw new ArgumentNullException(nameof(scoringTypeFactory));
		_categoryFactory = categoryFactory ?? throw new ArgumentNullException(nameof(categoryFactory));
		_inconsistencyIndexCalculator = inconsistencyIndexCalculator ?? throw new ArgumentNullException(nameof(inconsistencyIndexCalculator));
		_piAndNiIndexCalculator = piAndNiIndexCalculator ?? throw new ArgumentNullException(nameof(piAndNiIndexCalculator));
		_adhdHyperActiveIndex = adhdHyperActiveIndex ?? throw new ArgumentNullException(nameof(adhdHyperActiveIndex));
		_adhdInattentiveIndex = adhdInattentiveIndex ?? throw new ArgumentNullException(nameof(adhdInattentiveIndex));
		_behaviorDisorderIndex = behaviorDisorderIndex ?? throw new ArgumentNullException(nameof(behaviorDisorderIndex));
		_oppositionDisorderIndex = oppositionDisorderIndex ?? throw new ArgumentNullException(nameof(oppositionDisorderIndex));
		_adhdConners3Calculator = adhdConners3Calculator ?? throw new ArgumentNullException(nameof(adhdConners3Calculator));
	}

	public Snapshot? Init()
	{
		var subject = _data.Get();
		CloneAndAddToSnapshot(subject, State.InitialData);
			
		if(subject.Questions == null)
		{
			return null;
		}

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

		subject.ScreeningIndex = GetScreeningIndex(subject.Questions);
		CloneAndAddToSnapshot(subject, State.ScreeningIndex);

		subject.SevereBehaviorIndex = GetSevereBehaviorIndex(subject.Questions);
		CloneAndAddToSnapshot(subject, State.SevereBehaviorIndex);

		return _snapshot;
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
			School = questions.FirstOrDefault(q => q.Id == 95)!.Score,
			Home = questions.FirstOrDefault(q => q.Id == 97)!.Score,
			Friends = questions.FirstOrDefault(q => q.Id == 96)!.Score
		};

		return deteriorationIndex;
	}

	private ScreeningIndex GetScreeningIndex(List<Question> questions)
	{
		var anxietyIndex = new AnxietyIndex
		{
			IrritableScore = questions.FirstOrDefault(q => q.Id == 29)!.Score,
			NervousOrAgitatedScore = questions.FirstOrDefault(q => q.Id == 2)!.Score,
			WorriedControlScore = questions.FirstOrDefault(q => q.Id == 46)!.Score,
			WorriedScore = questions.FirstOrDefault(q => q.Id == 90)!.Score
		};

		var depressionIndex = new DepressionIndex
		{
			LostOfInterestOrPleasureScore = questions.FirstOrDefault(q => q.Id == 44)!.Score,
			SadnessOrIrritableScore = questions.FirstOrDefault(q => q.Id == 68)!.Score,
			TiredOrLowEnergyScore = questions.FirstOrDefault(q => q.Id == 80)!.Score,
			UselessnessScore = questions.FirstOrDefault(q => q.Id == 36)!.Score
		};

		var screeningIndex = new ScreeningIndex
		{
			AnxietyIndex = anxietyIndex,
			DepressionIndex = depressionIndex
		};

		return screeningIndex;
	}

	private SevereBehaviorIndex GetSevereBehaviorIndex(List<Question> questions)
	{
		return new SevereBehaviorIndex
		{
			AnimalCrueltyScore = questions.FirstOrDefault(q => q.Id == 47)!.Score,
			BreakingAndEnteringScore = questions.FirstOrDefault(q => q.Id == 78)!.Score,
			ConfrontationalTheftScore = questions.FirstOrDefault(q => q.Id == 13)!.Score,
			FireStarterScore = questions.FirstOrDefault(q => q.Id == 72)!.Score,
			PoliceProblemsScore = questions.FirstOrDefault(q => q.Id == 22)!.Score,
			UsingGunsScore = questions.FirstOrDefault(q => q.Id == 59)!.Score
		};
	}

	private void CloneAndAddToSnapshot(Subject subject, State state)
	{
		subject.CurrentState = state;
		var serialized = JsonSerializer.Serialize(subject);
		var cloned = JsonSerializer.Deserialize<Subject>(serialized);

		if (cloned != null) _snapshot?.States?.Add(cloned);
	}
}


