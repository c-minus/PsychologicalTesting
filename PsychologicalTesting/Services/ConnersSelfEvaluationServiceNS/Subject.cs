using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.AdhdConners3;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.Disorder;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.PiAndNi;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.Screening;
using Services.ConnersSelfEvaluationServiceNS;
using Services.ConnersSelfEvaluationServiceNS.Indexes;
using Services.ConnersSelfEvaluationServiceNS.Indexes.Adhd;
using PsychologicalTesting.Extensions;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Profiles;

namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS;
public class Subject
{
    public Subject()
    {
        CreatedAt = DateTime.Now;
    }

    public string? Id { get; set; }
    public string? Name { get; set; }
    public State CurrentState { get; set; }
    public string? CurrentStateName => Enum.GetName(typeof(State), CurrentState);
    public byte Age { get; set; }
    public IdentifyAs? GenderInternal => Gender?.GetEnumValueByName<IdentifyAs>();
    public string? Gender { get; set; }
    public List<Question>? Questions { get; set; }
    public InconsistencyIndex? InconsistencyIndex { get; set; }
    public PiAndNiIndex? PiAndNiIndex { get; set; }
    public AdhdIndex? AdhdIndex { get; set; }
    public DateTime? CreatedAt { get; }
    public DisorderIndex? DisorderIndex { get; set; }
    public DeteriorationIndex? DeteriorationIndex { get; set; }
    public AdhdConners3Index? AdhdConners3Index { get; set; }
    public ScreeningIndex? ScreeningIndex { get; set; }
    public SevereBehaviorIndex? SevereBehaviorIndex { get; set; }
    public Profile? Profile { get; set; }
}