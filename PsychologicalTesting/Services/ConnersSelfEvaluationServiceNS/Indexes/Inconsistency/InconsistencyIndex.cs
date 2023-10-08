namespace Services.ConnersSelfEvaluationServiceNS.Indexes
{
    public class InconsistencyIndex
    {
        public byte A { get; set; }
        public byte B { get; set; }

        public bool IsProbablyInvalid
        {
            get
            {
                return A >= 9 && B >= 2;
            }
        }
    }
}