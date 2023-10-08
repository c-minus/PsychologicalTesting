namespace Services.ConnersSelfEvaluationServiceNS.Indexes.Inconsistency
{
    public class InconsistencyPair
    {
        public byte FirstId { get; set; }
        public byte SecondId { get; set; }
        public byte FirstValue { get; set; }
        public byte SecondValue { get; set; }

        public byte FinalValue
        {
            get
            {
                return (byte)Math.Abs(FirstValue - SecondValue);
            }
        }
    }
}