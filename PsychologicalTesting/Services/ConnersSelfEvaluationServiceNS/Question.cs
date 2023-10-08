namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS
{
    public class Question
    {
        public byte Id { get; set; }
        public byte Answer { get; set; }
        public byte Score { get; set; }
        public string? ScoringType { get; set; }
        public IEnumerable<string>? Categories { get; set; }
    }

    /*
       3210-> 1,
       1100-> 10,11,19,40,41
       1000-> 12,93
       0011-> 28
       0001-> 37,48,54,75
     */
}

