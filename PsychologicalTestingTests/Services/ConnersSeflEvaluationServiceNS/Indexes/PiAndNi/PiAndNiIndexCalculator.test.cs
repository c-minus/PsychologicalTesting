// BEGIN: 5d5d7c6d6d6d
using System.Collections.Generic;
using NUnit.Framework;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.PiAndNi;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS;

namespace PsychologicalTesting.Tests.Services.ConnersSelfEvaluationServiceNS.Indexes.PiAndNi
{
    [TestFixture]
    public class PiAndNiIndexCalculatorTests
    {
        private PiAndNiIndexCalculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new PiAndNiIndexCalculator();
        }

        [Test]
        public void Calculate_ReturnsCorrectValues()
        {
            // Arrange
            var questions = new List<Question>
            {
                new Question { Categories = new List<string> { "PI" }, Answer = 2 },
                new Question { Categories = new List<string> { "NI" }, Answer = 3 },
                new Question { Categories = new List<string> { "PI" }, Answer = 1 },
                new Question { Categories = new List<string> { "NI" }, Answer = 4 },
                new Question { Categories = new List<string> { "PI" }, Answer = 3 },
                new Question { Categories = new List<string> { "NI" }, Answer = 2 },
            };

            // Act
            var result = _calculator.Calculate(questions);

            // Assert
            Assert.That(result.Pi, Is.EqualTo(6));
            Assert.That(result.Ni, Is.EqualTo(9));
        }
    }
}
// END: 5d5d7c6d6d6d