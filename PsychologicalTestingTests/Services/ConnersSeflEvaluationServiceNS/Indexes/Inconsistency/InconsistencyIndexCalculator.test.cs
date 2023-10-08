using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS;
using Services.ConnersSelfEvaluationServiceNS.Indexes;
using NUnit.Framework;

namespace PsychologicalTesting.Tests.Services.ConnersSelfEvaluationServiceNS.Indexes.Inconsistency
{
    [TestFixture]
    public class InconsistencyIndexCalculatorTests
    {
        private InconsistencyIndexCalculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new InconsistencyIndexCalculator();
        }

        [Test]
        public void Calculate_ReturnsInconsistencyIndex()
        {
            // Arrange
            var questions = new List<Question>
            {
                new Question { Id = 73, Answer = 1 },
                new Question { Id = 85, Answer = 2 },
                new Question { Id = 50, Answer = 3 },
                new Question { Id = 60, Answer = 3 },
                new Question { Id = 81, Answer = 2 },
                new Question { Id = 79, Answer = 1 },
                new Question { Id = 46, Answer = 1 },
                new Question { Id = 90, Answer = 2 },
                new Question { Id = 17, Answer = 3 },
                new Question { Id = 30, Answer = 2 },
                new Question { Id = 56, Answer = 1 },
                new Question { Id = 70, Answer = 3 },
                new Question { Id = 42, Answer = 2 },
                new Question { Id = 63, Answer = 1 },
                new Question { Id = 69, Answer = 3 },
                new Question { Id = 83, Answer = 2 },
                new Question { Id = 43, Answer = 1 },
                new Question { Id = 61, Answer = 2 },
                new Question { Id = 25, Answer = 3 },
                new Question { Id = 38, Answer = 1 },
            };

            // Act
            var result = _calculator.Calculate(questions);

            // Assert
            Assert.That(result.A, Is.EqualTo(16));
            Assert.That(result.B, Is.EqualTo(0));
        }
    }
}
// END: 6b8d5f8fj3p5