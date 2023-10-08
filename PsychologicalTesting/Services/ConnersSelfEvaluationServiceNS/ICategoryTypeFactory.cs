namespace Services.ConnersSelfEvaluationServiceNS
{
    public interface ICategoryTypeFactory
    {
        public IEnumerable<string> Get(byte id);
    }
}