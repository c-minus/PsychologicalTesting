namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Profiles;

public interface IProfileFactory
{
    public Profile Create(IdentifyAs? identifyAs, byte age);
}