using System.Collections;

namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Profiles;

public class ProfileFactory : IProfileFactory
{
    private readonly IdentifyAs _identifyAs;

    public ProfileFactory(IdentifyAs identifyAs)
    {
        _identifyAs = identifyAs;
    }

    public Profile Create()
    {
        return _identifyAs is IdentifyAs.Female ? GetFemaleProfile() : GetMaleProfile();
    }

    private Profile GetMaleProfile()
    {
        var profile = new Profile
        {
            Name = "Male",
            Categories = GetMaleCategories().ToList()
        };

        return profile;
    }
    
    private Profile GetFemaleProfile()
    {
        var profile = new Profile
        {
            Name = "Female",
            Categories = GetFemaleCategories().ToList()
        };

        return profile;
    }

    private IEnumerable<ProfileCategory> GetFemaleCategories()
    {
        return Enumerable.Empty<ProfileCategory>();
    }

    private IEnumerable<ProfileCategory> GetMaleCategories()
    {
        yield return new()
        {
            Id = "IN",
            Name = "Inattention",
            AgeSegments = GetInattentionAgeSegments().ToList()
        };
        yield return new()
        {
            Id = "HY",
            Name = "Hyperactivity/Impulsivity",
            AgeSegments = GetHyperImpulsAgeSegments().ToList()
        };
        yield return new()
        {
            Id = "LP",
            Name = "Learning Problems",
            AgeSegments = GetLearningProblemsAgeSegments().ToList()
        };
        yield return new()
        {
            Id = "AN",
            Name = "ADHD Inadvertently",
            AgeSegments = GetAdhdInadvertentlyAgeSegments().ToList()
        };
        yield return new()
        {
            Id = "AH",
            Name = "ADHD Hyperactive/Impulsive",
            AgeSegments = GetAdhdHyperImpulsAgeSegments().ToList()
        };
        yield return new()
        {
            Id = "CD",
            Name = "Behavioral Disorder",
            AgeSegments = GetBehavioralDisorderAgeSegments().ToList()
        };
        yield return new()
        {
            Id = "OD",
            Name = "Oppositional Defiant Disorder",
            AgeSegments = GetOppositionalDefiantDisorderAgeSegments().ToList()
        };
        yield return new()
        {
            Id = "AG",
            Name = "Aggression",
            AgeSegments = GetAggresionAgeSegments().ToList()
        };
        yield return new()
        {
            Id = "FR",
            Name = "Family Relations",
            AgeSegments = GetFamilyRelationsAgeSegments().ToList()
        };
    }

    private IEnumerable<AgeSegment> GetFamilyRelationsAgeSegments()
    {
        yield return new(new byte[] { 8, 9, 10 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 42),
                new(1, 44),
                new(2, 47),
                new(3, 59),
                new(4, 52),
                new(5, 54),
                new(6, 56),
                new(7, 59),
                new(8, 61),
                new(9, 64),
                new(10, 66),
                new(11, 68),
                new(12, 71),
                new(13, 73),
                new(14, 76),
                new(15, 78),
                new(16, 80),
                new(17, 83),
                new(18, 85),
                new(19, 87),
                new(20, 90)
            }
        };
        yield return new(new byte[] { 11, 12 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 42),
                new(1, 44),
                new(2, 47),
                new(3, 49),
                new(4, 52),
                new(5, 54),
                new(6, 57),
                new(7, 59),
                new(8, 62),
                new(9, 64),
                new(10, 67),
                new(11, 69),
                new(12, 72),
                new(13, 74),
                new(14, 77),
                new(15, 79),
                new(16, 82),
                new(17, 84),
                new(18, 87),
                new(19, 89),
                new(20, 90)
            }
        };
        yield return new(new byte[] { 13, 14 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 42),
                new(1, 44),
                new(2, 47),
                new(3, 49),
                new(4, 52),
                new(5, 54),
                new(6, 57),
                new(7, 59),
                new(8, 62),
                new(9, 65),
                new(10, 67),
                new(11, 70),
                new(12, 72),
                new(13, 75),
                new(14, 77),
                new(15, 80),
                new(16, 82),
                new(17, 85),
                new(18, 88),
                new(19, 90)
            }
        };
        yield return new(new byte[] { 15, 16 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 41),
                new(1, 44),
                new(2, 46),
                new(3, 49),
                new(4, 51),
                new(5, 54),
                new(6, 56),
                new(7, 59),
                new(8, 61),
                new(9, 64),
                new(10, 66),
                new(11, 69),
                new(12, 71),
                new(13, 74),
                new(14, 76),
                new(15, 79),
                new(16, 81),
                new(17, 84),
                new(18, 86),
                new(19, 89),
                new(20, 90)
            }
        };
        yield return new(new byte[] { 17, 18 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 43),
                new(2, 45),
                new(3, 48),
                new(4, 50),
                new(5, 52),
                new(6, 55),
                new(7, 57),
                new(8, 60),
                new(9, 62),
                new(10, 64),
                new(11, 67),
                new(12, 69),
                new(13, 71),
                new(14, 74),
                new(15, 76),
                new(16, 79),
                new(17, 81),
                new(18, 83),
                new(19, 86),
                new(20, 88),
                new(21, 90)
            }
        };
    }

    private IEnumerable<AgeSegment> GetAggresionAgeSegments()
    {
        yield return new(new byte[] { 8, 9, 10 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 43),
                new(1, 47),
                new(2, 51),
                new(3, 55),
                new(4, 59),
                new(5, 63),
                new(6, 67),
                new(7, 71),
                new(8, 75),
                new(9, 79),
                new(10, 83),
                new(11, 87),
                new(12, 90)
            }
        };
        yield return new(new byte[] { 11, 12 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 42),
                new(1, 47),
                new(2, 51),
                new(3, 55),
                new(4, 59),
                new(5, 64),
                new(6, 68),
                new(7, 72),
                new(8, 76),
                new(9, 81),
                new(10, 85),
                new(11, 89),
                new(12, 90)
            }
        };
        yield return new(new byte[] { 13, 14 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 43),
                new(1, 46),
                new(2, 50),
                new(3, 53),
                new(4, 57),
                new(5, 60),
                new(6, 64),
                new(7, 67),
                new(8, 71),
                new(9, 74),
                new(10, 78),
                new(11, 81),
                new(12, 85),
                new(13, 87),
                new(14, 90)
            }
        };
        yield return new(new byte[] { 15, 16 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 43),
                new(1, 45),
                new(2, 48),
                new(3, 51),
                new(4, 53),
                new(5, 56),
                new(6, 59),
                new(7, 61),
                new(8, 64),
                new(9, 67),
                new(10, 69),
                new(11, 72),
                new(12, 75),
                new(13, 77),
                new(14, 80),
                new(15, 82),
                new(16, 85),
                new(17, 88),
                new(18, 90)
            }
        };
        yield return new(new byte[] { 17, 18 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 42),
                new(1, 45),
                new(2, 47),
                new(3, 49),
                new(4, 51),
                new(5, 53),
                new(6, 55),
                new(7, 58),
                new(8, 60),
                new(9, 62),
                new(10, 64),
                new(11, 66),
                new(12, 68),
                new(13, 70),
                new(14, 73),
                new(15, 75),
                new(16, 77),
                new(17, 79),
                new(18, 81),
                new(19, 83),
                new(20, 86),
                new(21, 88),
                new(22, 90)
            }
        };
    }

    private IEnumerable<AgeSegment> GetOppositionalDefiantDisorderAgeSegments()
    {
        yield return new(new byte[] { 8, 9, 10 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 42),
                new(2, 45),
                new(3, 48),
                new(4, 51),
                new(5, 53),
                new(6, 56),
                new(7, 59),
                new(8, 62),
                new(9, 64),
                new(10, 67),
                new(11, 70),
                new(12, 73),
                new(13, 75),
                new(14, 78),
                new(15, 81),
                new(16, 84),
                new(17, 86),
                new(18, 89),
                new(19, 90)
            }
        };
        yield return new(new byte[] { 11, 12 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 42),
                new(2, 45),
                new(3, 48),
                new(4, 51),
                new(5, 54),
                new(6, 57),
                new(7, 60),
                new(8, 63),
                new(9, 66),
                new(10, 69),
                new(11, 72),
                new(12, 75),
                new(13, 78),
                new(14, 81),
                new(15, 84),
                new(16, 87),
                new(17, 90)
            }
        };
        yield return new(new byte[] { 13, 14 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 42),
                new(2, 45),
                new(3, 48),
                new(4, 51),
                new(5, 53),
                new(6, 56),
                new(7, 59),
                new(8, 62),
                new(9, 65),
                new(10, 68),
                new(11, 71),
                new(12, 74),
                new(13, 76),
                new(14, 79),
                new(15, 82),
                new(16, 85),
                new(17, 88),
                new(18, 90)
            }
        };
        yield return new(new byte[] { 15, 16 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 41),
                new(2, 44),
                new(3, 46),
                new(4, 49),
                new(5, 52),
                new(6, 54),
                new(7, 57),
                new(8, 59),
                new(9, 62),
                new(10, 65),
                new(11, 67),
                new(12, 70),
                new(13, 73),
                new(14, 75),
                new(15, 78),
                new(16, 80),
                new(17, 83),
                new(18, 86),
                new(19, 88),
                new(20, 90)
            }
        };
        yield return new(new byte[] { 17, 18 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 40),
                new(2, 43),
                new(3, 45),
                new(4, 47),
                new(5, 50),
                new(6, 52),
                new(7, 54),
                new(8, 57),
                new(9, 59),
                new(10, 61),
                new(11, 64),
                new(12, 66),
                new(13, 68),
                new(14, 71),
                new(15, 73),
                new(16, 76),
                new(17, 78),
                new(18, 80),
                new(19, 83),
                new(20, 85),
                new(21, 87),
                new(22, 90)
            }
        };
    }

    private IEnumerable<AgeSegment> GetBehavioralDisorderAgeSegments()
    {
        yield return new(new byte[] { 8, 9, 10 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 44),
                new(1, 50),
                new(2, 56),
                new(3, 62),
                new(4, 68),
                new(5, 74),
                new(6, 80),
                new(7, 86),
                new(8, 90)
            }
        };
        yield return new(new byte[] { 11, 12 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 44),
                new(1, 50),
                new(2, 56),
                new(3, 62),
                new(4, 67),
                new(5, 73),
                new(6, 79),
                new(7, 85),
                new(8, 90)
            }
        };
        yield return new(new byte[] { 13, 14 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 44),
                new(1, 49),
                new(2, 54),
                new(3, 59),
                new(4, 63),
                new(5, 68),
                new(6, 73),
                new(7, 78),
                new(8, 82),
                new(9, 87),
                new(10, 90)
            }
        };
        yield return new(new byte[] { 15, 16 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 44),
                new(1, 48),
                new(2, 51),
                new(3, 55),
                new(4, 59),
                new(5, 62),
                new(6, 66),
                new(7, 69),
                new(8, 73),
                new(9, 77),
                new(10, 80),
                new(11, 84),
                new(12, 87),
                new(13, 90)
            }
        };
        yield return new(new byte[] { 17, 18 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 44),
                new(1, 47),
                new(2, 50),
                new(3, 53),
                new(4, 55),
                new(5, 58),
                new(6, 61),
                new(7, 64),
                new(8, 67),
                new(9, 70),
                new(10, 73),
                new(11, 76),
                new(12, 78),
                new(13, 81),
                new(14, 84),
                new(15, 87),
                new(16, 90)
            }
        };
    }

    private IEnumerable<AgeSegment> GetAdhdHyperImpulsAgeSegments()
    {
        yield return new(new byte[] { 8, 9, 10 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 40),
                new(2, 42),
                new(3, 44),
                new(4, 46),
                new(5, 48),
                new(6, 50),
                new(7, 52),
                new(8, 53),
                new(9, 55),
                new(10, 57),
                new(11, 59),
                new(12, 61),
                new(13, 63),
                new(14, 65),
                new(15, 67),
                new(16, 69),
                new(17, 71),
                new(18, 73),
                new(19, 75),
                new(20, 77),
                new(21, 78),
                new(22, 80),
                new(23, 82),
                new(24, 84),
                new(25, 86),
                new(26, 88),
                new(27, 90)
            }
        };
        yield return new(new byte[] { 11, 12 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 40),
                new(2, 42),
                new(3, 44),
                new(4, 45),
                new(5, 47),
                new(6, 49),
                new(7, 51),
                new(8, 53),
                new(9, 55),
                new(10, 57),
                new(11, 59),
                new(12, 61),
                new(13, 63),
                new(14, 65),
                new(15, 67),
                new(16, 68),
                new(17, 70),
                new(18, 72),
                new(19, 74),
                new(20, 76),
                new(21, 78),
                new(22, 80),
                new(23, 82),
                new(24, 84),
                new(25, 86),
                new(26, 88),
                new(27, 89),
                new(28, 90)
            }
        };
        yield return new(new byte[] { 13, 14 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 40),
                new(2, 41),
                new(3, 43),
                new(4, 45),
                new(5, 47),
                new(6, 49),
                new(7, 51),
                new(8, 53),
                new(9, 54),
                new(10, 56),
                new(11, 58),
                new(12, 60),
                new(13, 62),
                new(14, 64),
                new(15, 65),
                new(16, 67),
                new(17, 69),
                new(18, 71),
                new(19, 73),
                new(20, 75),
                new(21, 77),
                new(22, 78),
                new(23, 80),
                new(24, 82),
                new(25, 84),
                new(26, 86),
                new(27, 88),
                new(28, 90),
            }
        };
        yield return new(new byte[] { 15, 16 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 40),
                new(2, 41),
                new(3, 43),
                new(4, 45),
                new(5, 46),
                new(6, 48),
                new(7, 50),
                new(8, 51),
                new(9, 53),
                new(10, 55),
                new(11, 57),
                new(12, 58),
                new(13, 60),
                new(14, 62),
                new(15, 63),
                new(16, 65),
                new(17, 67),
                new(18, 69),
                new(19, 70),
                new(20, 72),
                new(21, 74),
                new(22, 75),
                new(23, 77),
                new(24, 79),
                new(25, 81),
                new(26, 82),
                new(27, 84),
                new(28, 86),
                new(29, 87),
                new(30, 89),
                new(31, 90)
            }
        };
        yield return new(new byte[] { 17, 18 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 40),
                new(2, 41),
                new(3, 42),
                new(4, 44),
                new(5, 46),
                new(6, 47),
                new(7, 49),
                new(8, 50),
                new(9, 52),
                new(10, 54),
                new(11, 55),
                new(12, 57),
                new(13, 58),
                new(14, 60),
                new(15, 62),
                new(16, 63),
                new(17, 65),
                new(18, 66),
                new(19, 68),
                new(20, 70),
                new(21, 71),
                new(22, 73),
                new(23, 74),
                new(24, 76),
                new(25, 78),
                new(26, 79),
                new(27, 81),
                new(28, 82),
                new(29, 84),
                new(30, 86),
                new(31, 87),
                new(32, 89),
                new(33, 90)
            }
        };
    }

    private IEnumerable<AgeSegment> GetAdhdInadvertentlyAgeSegments()
    {
        yield return new(new byte[] { 8, 9, 10 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 40),
                new(2, 40),
                new(3, 40),
                new(4, 42),
                new(5, 44),
                new(6, 47),
                new(7, 49),
                new(8, 51),
                new(9, 54),
                new(10, 56),
                new(11, 58),
                new(12, 60),
                new(13, 63),
                new(14, 65),
                new(15, 67),
                new(16, 69),
                new(17, 72),
                new(18, 74),
                new(19, 76),
                new(20, 79),
                new(21, 81),
                new(22, 83),
                new(23, 85),
                new(24, 88),
                new(25, 90)
            }
        };
        yield return new(new byte[] { 11, 12 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 40),
                new(2, 40),
                new(3, 40),
                new(4, 42),
                new(5, 44),
                new(6, 47),
                new(7, 49),
                new(8, 51),
                new(9, 54),
                new(10, 56),
                new(11, 58),
                new(12, 60),
                new(13, 63),
                new(14, 65),
                new(15, 67),
                new(16, 69),
                new(17, 72),
                new(18, 74),
                new(19, 76),
                new(20, 79),
                new(21, 81),
                new(22, 83),
                new(23, 85),
                new(24, 88),
                new(25, 90)
            }
        };
        yield return new(new byte[] { 13, 14 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 40),
                new(2, 40),
                new(3, 40),
                new(4, 42),
                new(5, 44),
                new(6, 46),
                new(7, 48),
                new(8, 51),
                new(9, 53),
                new(10, 55),
                new(11, 57),
                new(12, 60),
                new(13, 62),
                new(14, 64),
                new(15, 66),
                new(16, 69),
                new(17, 71),
                new(18, 73),
                new(19, 75),
                new(20, 78),
                new(21, 80),
                new(22, 82),
                new(23, 84),
                new(24, 86),
                new(25, 89),
                new(26, 90)
            }
        };
        yield return new(new byte[] { 15, 16 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 40),
                new(2, 40),
                new(3, 40),
                new(4, 41),
                new(5, 43),
                new(6, 45),
                new(7, 47),
                new(8, 49),
                new(9, 52),
                new(10, 54),
                new(11, 56),
                new(12, 58),
                new(13, 60),
                new(14, 62),
                new(15, 65),
                new(16, 67),
                new(17, 69),
                new(18, 71),
                new(19, 73),
                new(20, 75),
                new(21, 78),
                new(22, 80),
                new(23, 82),
                new(24, 84),
                new(25, 86),
                new(26, 88),
                new(27, 90)
            }
        };
        yield return new(new byte[] { 17, 18 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 40),
                new(2, 40),
                new(3, 40),
                new(4, 40),
                new(5, 42),
                new(6, 44),
                new(7, 46),
                new(8, 48),
                new(9, 50),
                new(10, 52),
                new(11, 54),
                new(12, 56),
                new(13, 58),
                new(14, 61),
                new(15, 63),
                new(16, 65),
                new(17, 67),
                new(18, 69),
                new(19, 71),
                new(20, 73),
                new(21, 75),
                new(22, 77),
                new(23, 79),
                new(24, 82),
                new(25, 84),
                new(26, 86),
                new(27, 88),
                new(28, 90)
            }
        };
    }

    private IEnumerable<AgeSegment> GetLearningProblemsAgeSegments()
    {
        yield return new(new byte[] { 8, 9, 10 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 40),
                new(2, 43),
                new(3, 46),
                new(4, 49),
                new(5, 52),
                new(6, 56),
                new(7, 59),
                new(8, 62),
                new(9, 65),
                new(10, 69),
                new(11, 72),
                new(12, 75),
                new(13, 78),
                new(14, 82),
                new(15, 85),
                new(16, 88),
                new(17, 90)
            }
        };
        yield return new(new byte[] { 11, 12 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 40),
                new(2, 43),
                new(3, 46),
                new(4, 50),
                new(5, 53),
                new(6, 56),
                new(7, 59),
                new(8, 63),
                new(9, 66),
                new(10, 69),
                new(11, 72),
                new(12, 75),
                new(13, 79),
                new(14, 82),
                new(15, 85),
                new(16, 88),
                new(17, 90)
            }
        };
        yield return new(new byte[] { 13, 14 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 40),
                new(2, 43),
                new(3, 46),
                new(4, 49),
                new(5, 53),
                new(6, 56),
                new(7, 59),
                new(8, 62),
                new(9, 65),
                new(10, 69),
                new(11, 72),
                new(12, 75),
                new(13, 78),
                new(14, 81),
                new(15, 85),
                new(16, 88),
                new(17, 90)
            }
        };
        yield return new(new byte[] { 15, 16 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 40),
                new(2, 43),
                new(3, 46),
                new(4, 49),
                new(5, 52),
                new(6, 55),
                new(7, 58),
                new(8, 61),
                new(9, 64),
                new(10, 67),
                new(11, 70),
                new(12, 73),
                new(13, 76),
                new(14, 79),
                new(15, 82),
                new(16, 85),
                new(17, 88),
                new(18, 90)
            }
        };
        yield return new(new byte[] { 17, 18 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 40),
                new(2, 43),
                new(3, 45),
                new(4, 48),
                new(5, 51),
                new(6, 54),
                new(7, 56),
                new(8, 59),
                new(9, 62),
                new(10, 65),
                new(11, 67),
                new(12, 70),
                new(13, 73),
                new(14, 75),
                new(15, 78),
                new(16, 81),
                new(17, 84),
                new(18, 86),
                new(19, 89),
                new(20, 90)
            }
        };
    }

    private IEnumerable<AgeSegment> GetHyperImpulsAgeSegments()
    {
        yield return new(new byte[] { 8, 9, 10 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 40),
                new(2, 40),
                new(3, 42),
                new(4, 43),
                new(5, 45),
                new(6, 47),
                new(7, 48),
                new(8, 50),
                new(9, 51),
                new(10, 53),
                new(11, 54),
                new(12, 56),
                new(13, 58),
                new(14, 59),
                new(15, 61),
                new(16, 62),
                new(17, 64),
                new(18, 66),
                new(19, 67),
                new(20, 69),
                new(21, 70),
                new(22, 72),
                new(23, 74),
                new(24, 75),
                new(25, 77),
                new(26, 78),
                new(27, 80),
                new(28, 81),
                new(29, 83),
                new(30, 85),
                new(31, 86),
                new(32, 88),
                new(33, 89),
                new(34, 90)
            }
        };
        yield return new(new byte[] { 11, 12 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 40),
                new(2, 41),
                new(3, 42),
                new(4, 44),
                new(5, 46),
                new(6, 47),
                new(7, 49),
                new(8, 50),
                new(9, 52),
                new(10, 54),
                new(11, 55),
                new(12, 57),
                new(13, 59),
                new(14, 60),
                new(15, 62),
                new(16, 63),
                new(17, 65),
                new(18, 67),
                new(19, 68),
                new(20, 70),
                new(21, 72),
                new(22, 73),
                new(23, 75),
                new(24, 76),
                new(25, 78),
                new(26, 80),
                new(27, 81),
                new(28, 83),
                new(29, 84),
                new(30, 86),
                new(31, 88),
                new(32, 89),
                new(33, 90)
            }
        };
        yield return new(new byte[] { 13, 14 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 40),
                new(2, 41),
                new(3, 42),
                new(4, 44),
                new(5, 45),
                new(6, 47),
                new(7, 59),
                new(8, 50),
                new(9, 52),
                new(10, 53),
                new(11, 55),
                new(12, 56),
                new(13, 58),
                new(14, 59),
                new(15, 61),
                new(16, 62),
                new(17, 64),
                new(18, 66),
                new(19, 67),
                new(20, 69),
                new(21, 70),
                new(22, 72),
                new(23, 73),
                new(24, 75),
                new(25, 76),
                new(26, 78),
                new(27, 79),
                new(28, 81),
                new(29, 83),
                new(30, 84),
                new(31, 86),
                new(32, 87),
                new(33, 89),
                new(34, 90)
            }
        };
        yield return new(new byte[] { 15, 16 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 40),
                new(2, 40),
                new(3, 42),
                new(4, 43),
                new(5, 45),
                new(6, 46),
                new(7, 47),
                new(8, 49),
                new(9, 50),
                new(10, 52),
                new(11, 53),
                new(12, 54),
                new(13, 56),
                new(14, 57),
                new(15, 59),
                new(16, 60),
                new(17, 62),
                new(18, 63),
                new(19, 64),
                new(20, 66),
                new(21, 67),
                new(22, 69),
                new(23, 70),
                new(24, 71),
                new(25, 73),
                new(26, 74),
                new(27, 76),
                new(28, 77),
                new(29, 78),
                new(30, 80),
                new(31, 81),
                new(32, 83),
                new(33, 84),
                new(34, 85),
                new(35, 87),
                new(36, 88),
                new(37, 90)
            }
        };
        yield return new(new byte[] { 17, 18 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 40),
                new(2, 40),
                new(3, 41),
                new(4, 43),
                new(5, 44),
                new(6, 45),
                new(7, 46),
                new(8, 48),
                new(9, 49),
                new(10, 50),
                new(11, 52),
                new(12, 53),
                new(13, 54),
                new(14, 56),
                new(15, 57),
                new(16, 58),
                new(17, 59),
                new(18, 61),
                new(19, 62),
                new(20, 63),
                new(21, 65),
                new(22, 66),
                new(23, 67),
                new(24, 69),
                new(25, 70),
                new(26, 71),
                new(27, 72),
                new(28, 74),
                new(29, 75),
                new(30, 76),
                new(31, 78),
                new(32, 79),
                new(33, 80),
                new(34, 82),
                new(35, 83),
                new(36, 84),
                new(37, 85),
                new(38, 87),
                new(39, 88),
                new(40, 89),
                new(41, 90)
            }
        };
    }

    private IEnumerable<AgeSegment> GetInattentionAgeSegments()
    {
        yield return new(new byte[] { 8, 9, 10 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 40),
                new(2, 42),
                new(3, 44),
                new(4, 47),
                new(5, 49),
                new(6, 51),
                new(7, 54),
                new(8, 56),
                new(9, 59),
                new(10, 61),
                new(11, 63),
                new(12, 66),
                new(13, 68),
                new(14, 70),
                new(15, 73),
                new(16, 75),
                new(17, 77),
                new(18, 80),
                new(19, 82),
                new(20, 85),
                new(21, 87),
                new(22, 89),
                new(23, 90),
            }
        };
        yield return new(new byte[] { 11, 12 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 40),
                new(2, 42),
                new(3, 44),
                new(4, 47),
                new(5, 49),
                new(6, 51),
                new(7, 54),
                new(8, 56),
                new(9, 59),
                new(10, 61),
                new(11, 64),
                new(12, 66),
                new(13, 68),
                new(14, 71),
                new(15, 73),
                new(16, 76),
                new(17, 78),
                new(18, 80),
                new(19, 83),
                new(20, 85),
                new(21, 88),
                new(22, 90)
            }
        };
        yield return new(new byte[] { 13, 14 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 40),
                new(2, 41),
                new(3, 44),
                new(4, 46),
                new(5, 49),
                new(6, 51),
                new(7, 53),
                new(8, 56),
                new(9, 58),
                new(10, 61),
                new(11, 63),
                new(12, 65),
                new(13, 68),
                new(14, 70),
                new(15, 73),
                new(16, 75),
                new(17, 78),
                new(18, 80),
                new(19, 82),
                new(21, 87),
                new(22, 90)
            }
        };
        yield return new(new byte[] { 15, 16 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 40),
                new(2, 41),
                new(3, 43),
                new(4, 45),
                new(5, 48),
                new(6, 50),
                new(7, 52),
                new(8, 55),
                new(9, 57),
                new(10, 59),
                new(11, 62),
                new(12, 64),
                new(13, 66),
                new(14, 68),
                new(15, 71),
                new(16, 73),
                new(17, 75),
                new(18, 78),
                new(19, 80),
                new(20, 82),
                new(21, 85),
                new(22, 87),
                new(23, 89),
                new(24, 90)
            }
        };
        yield return new(new byte[] { 17, 18 })
        {
            Mappings = new List<KeyValuePair<byte, byte>>
            {
                new(0, 40),
                new(1, 40),
                new(2, 40),
                new(3, 42),
                new(4, 44),
                new(5, 46),
                new(6, 49),
                new(7, 51),
                new(8, 53),
                new(9, 55),
                new(10, 58),
                new(11, 60),
                new(12, 62),
                new(13, 64),
                new(14, 66),
                new(15, 69),
                new(16, 71),
                new(17, 73),
                new(18, 75),
                new(19, 78),
                new(20, 80),
                new(21, 82),
                new(22, 84),
                new(23, 87),
                new(24, 89),
                new(25, 90)
            }
        };
    }
}