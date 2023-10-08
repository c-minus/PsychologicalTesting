using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS;
using Services.ConnersSelfEvaluationServiceNS.Indexes.Inconsistency;

namespace Services.ConnersSelfEvaluationServiceNS.Indexes
{
    public class InconsistencyIndexCalculator : IinconsistencyIndexCalculator
    {
        public InconsistencyIndex Calculate(List<Question> questions)
        {
            var pairs = GetPairs();

            foreach (var pair in pairs)
            {
                pair.FirstValue = questions.FirstOrDefault(q => q.Id == pair.FirstId)?.Score ?? default;
                pair.SecondValue = questions.FirstOrDefault(q => q.Id == pair.SecondId)?.Score ?? default;
            }

            var a = pairs.Sum(p => p.FinalValue);
            var b = pairs
            .Where(p => p.FinalValue == 2 && p.FinalValue == 3)
            .Sum(p => p.FinalValue);

            var index = new InconsistencyIndex
            {
                A = (byte)a,
                B = (byte)b,
            };

            return index;
        }

        private IEnumerable<InconsistencyPair> GetPairs()
        {
            return new List<InconsistencyPair> {
                new InconsistencyPair { FirstId = 73, SecondId = 85 },
                new InconsistencyPair { FirstId = 50, SecondId = 60 },
                new InconsistencyPair { FirstId = 81, SecondId = 79 },
                new InconsistencyPair { FirstId = 46, SecondId = 90 },
                new InconsistencyPair { FirstId = 17, SecondId = 30 },
                new InconsistencyPair { FirstId = 56, SecondId = 70 },
                new InconsistencyPair { FirstId = 42, SecondId = 63 },
                new InconsistencyPair { FirstId = 69, SecondId = 83 },
                new InconsistencyPair { FirstId = 43, SecondId = 61 },
                new InconsistencyPair { FirstId = 25, SecondId = 38 },
                };
        }
    }
}