using PsychologicalTesting;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.Disorder;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.PiAndNi;
using Services.ConnersSelfEvaluationServiceNS.Indexes;
using Services.ConnersSelfEvaluationServiceNS.Indexes.Adhd;

namespace Services.ConnersSelfEvaluationServiceNS
{
    public class Subject
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public State CurrentState { get; set; }
        public string? CurrentStateName => Enum.GetName(typeof(State), CurrentState);
        public int Age { get; set; }
        public string? IdentifyAs { get; set; }
        public List<Question>? Questions { get; set; }
        public InconsistencyIndex? InconsistencyIndex { get; set; }
        public PiAndNiIndex? PiAndNiIndex { get; set; }
        public AdhdIndex? AdhdIndex { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DisorderIndex? DisorderIndex { get; set; }
        public DeteriorationIndex? DeteriorationIndex { get; set; }
        public AdhdConners3Index? AdhdConners3Index { get; set; }
        public ScreeningIndex? ScreeningIndex { get; set; }
    }
}