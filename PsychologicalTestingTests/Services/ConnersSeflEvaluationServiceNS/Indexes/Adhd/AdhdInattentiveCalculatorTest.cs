using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.Adhd;

namespace PsychologicalTestingTests.Services.ConnersSeflEvaluationServiceNS.Indexes.Adhd;

[TestFixture]
public class AdhdInattentiveCalculatorTests
{
    private AdhdInattentiveCalculator _calculator = new();

    [SetUp]
    public void Setup()
    {
        _calculator = new AdhdInattentiveCalculator();
    }

    [Test]
    public void GetRules_ReturnsExpectedRules()
    {
        // Arrange
        var questions = new List<Question>
        {
            new() { Id = 31, Score = 2 },
            new() { Id = 39, Score = 3 },
            new() { Id = 63, Score = 2 },
            new() { Id = 42, Score = 3 },
            new() { Id = 61, Score = 2 },
            new() { Id = 17, Score = 3 },
            new() { Id = 21, Score = 2 },
            new() { Id = 51, Score = 3 },
            new() { Id = 5, Score = 2 },
            new() { Id = 77, Score = 3 },
            new() { Id = 32, Score = 2 }
        };

        // Act
        var rules = _calculator.GetRules(questions);

        // Assert
        var adhdRules = rules.ToList();
        Assert.That(adhdRules, Is.Not.Null);
        Assert.That(adhdRules, Has.Exactly(9).Items);

        Assert.That(adhdRules[0].Name, Is.EqualTo("A1a"));
        Assert.That(adhdRules[0].Value1, Is.EqualTo(2));
        Assert.That(adhdRules[0].Value2, Is.EqualTo(3));
        Assert.That(adhdRules[0].Predicate!(2, 3), Is.True);

        Assert.That(adhdRules[1].Name, Is.EqualTo("A1b"));
        Assert.That(adhdRules[1].Value1, Is.EqualTo(2));
        Assert.That(adhdRules[1].Value2, Is.Null);
        Assert.That(adhdRules[1].Predicate!(2, null), Is.True);

        Assert.That(adhdRules[2].Name, Is.EqualTo("A1c"));
        Assert.That(adhdRules[2].Value1, Is.EqualTo(3));
        Assert.That(adhdRules[2].Value2, Is.Null);
        Assert.That(adhdRules[2].Predicate!(3, null), Is.True);

        Assert.That(adhdRules[3].Name, Is.EqualTo("A1d"));
        Assert.That(adhdRules[3].Value1, Is.EqualTo(2));
        Assert.That(adhdRules[3].Value2, Is.EqualTo(3));
        Assert.That(adhdRules[3].Predicate!(2, 3), Is.True);

        Assert.That(adhdRules[4].Name, Is.EqualTo("A1e"));
        Assert.That(adhdRules[4].Value1, Is.EqualTo(2));
        Assert.That(adhdRules[4].Value2, Is.Null);
        var predicate = adhdRules[4].Predicate;
        Assert.That(predicate != null && predicate(2, null), Is.True);

        Assert.That(adhdRules[5].Name, Is.EqualTo("A1f"));
        Assert.That(adhdRules[5].Value1, Is.EqualTo(3));
        Assert.That(adhdRules[5].Value2, Is.Null);
        Assert.That(adhdRules[5].Predicate!(3, null), Is.True);

        Assert.That(adhdRules[6].Name, Is.EqualTo("A1g"));
        Assert.That(adhdRules[6].Value1, Is.EqualTo(2));
        Assert.That(adhdRules[6].Value2, Is.Null);
        Assert.That(adhdRules[6].Predicate!(2, null), Is.True);

        Assert.That(adhdRules[7].Name, Is.EqualTo("A1h"));
        Assert.That(adhdRules[7].Value1, Is.EqualTo(3));
        Assert.That(adhdRules[7].Value2, Is.Null);
        Assert.That(adhdRules[7].Predicate!(3, null), Is.True);

        Assert.That(adhdRules[8].Name, Is.EqualTo("A1i"));
        Assert.That(adhdRules[8].Value1, Is.EqualTo(2));
        Assert.That(adhdRules[8].Value2, Is.Null);
        Assert.That(adhdRules[8].Predicate!(2, null), Is.True);
    }
}