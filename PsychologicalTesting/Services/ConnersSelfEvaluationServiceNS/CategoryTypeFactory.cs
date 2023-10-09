using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS;

namespace Services.ConnersSelfEvaluationServiceNS
{
    public class CategoryTypeFactory : ICategoryTypeFactory
    {
        private IEnumerable<CategoryMap> categories;

        public CategoryTypeFactory()
        {
            CategoryMap();
        }

        public IEnumerable<string> Get(byte id)
        {
            var result = categories.FirstOrDefault(c => c.Id == id)?.Categories;

            return result ?? Enumerable.Empty<string>();
        }

        private void CategoryMap()
        {
            categories = new List<CategoryMap>
            {
                new CategoryMap
                {
                    Id = 1,
                    Categories = new List<string>
                    {
                        "OD"
                    }
                },
                new CategoryMap
                {
                    Id = 2,
                    Categories = new List<string>{}
                },
                new CategoryMap
                {
                    Id = 3,
                    Categories = new List<string>
                    {
                        "OD"
                    }
                },
                new CategoryMap
                {
                    Id = 4,
                    Categories = new List<string>
                    {
                        "HY"
                    }
                },
                new CategoryMap
                {
                    Id = 5,
                    Categories = new List<string>
                    {
                        "AN"
                    }
                },
                new CategoryMap
                {
                    Id = 6,
                    Categories = new List<string>
                    {
                        "HY", "AN"
                    }
                },
                new CategoryMap
                {
                    Id = 7,
                    Categories = new List<string>
                    {
                        "HY", "AN"
                    }
                },
                new CategoryMap
                {
                    Id = 8,
                    Categories = new List<string>
                    {
                        "AG", "CD"
                    }
                },
                new CategoryMap
                {
                    Id = 9,
                    Categories = new List<string>
                    {
                        "HY", "AH"
                    }
                },
                new CategoryMap
                {
                    Id = 10,
                    Categories = new List<string>
                    {
                        "NI"
                    }
                },
                new CategoryMap
                {
                    Id = 11,
                    Categories = new List<string>
                    {
                        "NI"
                    }
                },
                new CategoryMap
                {
                    Id = 12,
                    Categories = new List<string>
                    {
                        "PI"
                    }
                },
                new CategoryMap
                {
                    Id = 13,
                    Categories = new List<string>
                    {
                        "CD"
                    }
                },
                new CategoryMap
                {
                    Id = 14,
                    Categories = new List<string>
                    {
                        "FR"
                    }
                },
                new CategoryMap
                {
                    Id = 15,
                    Categories = new List<string>
                    {
                        "LP"
                    }
                },
                new CategoryMap
                {
                    Id = 16,
                    Categories = new List<string>
                    {
                        "AG", "CD"
                    }
                },
                new CategoryMap
                {
                    Id = 17,
                    Categories = new List<string>
                    {
                        "IN", "AN"
                    }
                },
                new CategoryMap
                {
                    Id = 18,
                    Categories = new List<string>
                    {
                        "AG"
                    }
                },
                new CategoryMap
                {
                    Id = 19,
                    Categories = new List<string>
                    {
                        "NI"
                    }
                },
                new CategoryMap
                {
                    Id = 20,
                    Categories = new List<string>
                    {
                        "HY", "AH"
                    }
                },
                new CategoryMap
                {
                    Id = 21,
                    Categories = new List<string>
                    {
                        "AN"
                    }
                },
                new CategoryMap
                {
                    Id = 22,
                    Categories = new List<string>
                    {
                        "AG"
                    }
                },
                new CategoryMap
                {
                    Id = 23,
                    Categories = new List<string>
                    {
                        "FR"
                    }
                },
                new CategoryMap
                {
                    Id = 24,
                    Categories = new List<string>
                    {
                        "OD1"
                    }
                },
                new CategoryMap
                {
                    Id = 25,
                    Categories = new List<string>
                    {
                        "AG", "CD"
                    }
                },
                new CategoryMap
                {
                    Id = 26,
                    Categories = new List<string>
                    {
                        "FR"
                    }
                },
                new CategoryMap
                {
                    Id = 27,
                    Categories = new List<string>
                    {
                        "AH"
                    }
                },
                new CategoryMap
                {
                    Id = 28,
                    Categories = new List<string>
                    {
                        "NI"
                    }
                },
                new CategoryMap
                {
                    Id = 29,
                    Categories = new List<string> {}
                },
                new CategoryMap
                {
                    Id = 30,
                    Categories = new List<string>
                    {
                        "IN"
                    }
                },
                new CategoryMap
                {
                    Id = 31,
                    Categories = new List<string>
                    {
                        "IN", "AN"
                    }
                },
                new CategoryMap
                {
                    Id = 32,
                    Categories = new List<string>
                    {
                        "AN"
                    }
                },
                new CategoryMap
                {
                    Id = 33,
                    Categories = new List<string>
                    {
                        "AG", "CD"
                    }
                },
                new CategoryMap
                {
                    Id = 34,
                    Categories = new List<string>
                    {
                        "HY","AH"
                    }
                },
                new CategoryMap
                {
                    Id = 35,
                    Categories = new List<string>
                    {
                        "LP"
                    }
                },
                new CategoryMap
                {
                    Id = 36,
                    Categories = new List<string>{}
                },
                new CategoryMap
                {
                    Id = 37,
                    Categories = new List<string>
                    {
                        "PI"
                    }
                },
                new CategoryMap
                {
                    Id = 38,
                    Categories = new List<string>
                    {
                        "AG", "CD"
                    }
                },
                new CategoryMap
                {
                    Id = 39,
                    Categories = new List<string>
                    {
                        "AN"
                    }
                },
                new CategoryMap
                {
                    Id = 40,
                    Categories = new List<string>
                    {
                        "NI"
                    }
                },
                new CategoryMap
                {
                    Id = 41,
                    Categories = new List<string>
                    {
                        "NI"
                    }
                },
                new CategoryMap
                {
                    Id = 42,
                    Categories = new List<string>
                    {
                        "AN"
                    }
                },
                new CategoryMap
                {
                    Id = 43,
                    Categories = new List<string>
                    {
                        "IN"
                    }
                },
                new CategoryMap
                {
                    Id = 44,
                    Categories = new List<string>{}
                },
                new CategoryMap
                {
                    Id = 45,
                    Categories = new List<string>
                    {
                        "LP"
                    }
                },
                new CategoryMap
                {
                    Id = 46,
                    Categories = new List<string>{}
                },
                new CategoryMap
                {
                    Id = 47,
                    Categories = new List<string>
                    {
                        "CD"
                    }
                },
                new CategoryMap
                {
                    Id = 48,
                    Categories = new List<string>
                    {
                        "PI"
                    }
                },
                new CategoryMap
                {
                    Id = 49,
                    Categories = new List<string>
                    {
                        "IN"
                    }
                },
                new CategoryMap
                {
                    Id = 50,
                    Categories = new List<string>
                    {
                        "HY"
                    }
                },
                new CategoryMap
                {
                    Id = 51,
                    Categories = new List<string>
                    {
                        "AN"
                    }
                },
                new CategoryMap
                {
                    Id = 52,
                    Categories = new List<string>
                    {
                        "AG", "CD"
                    }
                },
                new CategoryMap
                {
                    Id = 53,
                    Categories = new List<string>
                    {
                        "IN"
                    }
                },
                new CategoryMap
                {
                    Id = 54,
                    Categories = new List<string>
                    {
                        "PI"
                    }
                },
                new CategoryMap
                {
                    Id = 55,
                    Categories = new List<string>
                    {
                        "AH"
                    }
                },
                new CategoryMap
                {
                    Id = 56,
                    Categories = new List<string>
                    {
                        "LP"
                    }
                },
                new CategoryMap
                {
                    Id = 57,
                    Categories = new List<string>
                    {
                        "HY2"
                    }
                },
                new CategoryMap
                {
                    Id = 58,
                    Categories = new List<string>
                    {
                        "LP"
                    }
                },
                new CategoryMap
                {
                    Id = 59,
                    Categories = new List<string>
                    {
                        "AG", "CD"
                    }
                },
                new CategoryMap
                {
                    Id = 60,
                    Categories = new List<string>
                    {
                        "HY2", "AH"
                    }
                },
                new CategoryMap
                {
                    Id = 61,
                    Categories = new List<string>
                    {
                        "AN"
                    }
                },
                new CategoryMap
                {
                    Id = 62,
                    Categories = new List<string>
                    {
                        "AG", "OD"
                    }
                },
                new CategoryMap
                {
                    Id = 63,
                    Categories = new List<string>
                    {
                        "IN", "AN"
                    }
                },
                new CategoryMap
                {
                    Id = 64,
                    Categories = new List<string>
                    {
                        "HY", "AH"
                    }
                },
                new CategoryMap
                {
                    Id = 65,
                    Categories = new List<string>
                    {
                        "LP"
                    }
                },
                new CategoryMap
                {
                    Id = 66,
                    Categories = new List<string>
                    {
                        "HY", "AH"
                    }
                },
                new CategoryMap
                {
                    Id = 67,
                    Categories = new List<string>
                    {
                        "OD"
                    }
                },
                new CategoryMap
                {
                    Id = 68,
                    Categories = new List<string>{}
                },
                new CategoryMap
                {
                    Id = 69,
                    Categories = new List<string>
                    {
                        "FR"
                    }
                },
                new CategoryMap
                {
                    Id = 70,
                    Categories = new List<string>
                    {
                        "LP"
                    }
                },
                new CategoryMap
                {
                    Id = 71,
                    Categories = new List<string>
                    {
                        "IN"
                    }
                },
                new CategoryMap
                {
                    Id = 72,
                    Categories = new List<string>
                    {
                        "AG", "CD"
                    }
                },
                new CategoryMap
                {
                    Id = 73,
                    Categories = new List<string>
                    {
                        "FR"
                    }
                },
                new CategoryMap
                {
                    Id = 74,
                    Categories = new List<string>
                    {
                        "OD"
                    }
                },
                new CategoryMap
                {
                    Id = 75,
                    Categories = new List<string>
                    {
                        "PI"
                    }
                },
                new CategoryMap
                {
                    Id = 76,
                    Categories = new List<string>
                    {
                        "LP"
                    }
                },
                new CategoryMap
                {
                    Id = 77,
                    Categories = new List<string>
                    {
                        "IN", "AN"
                    }
                },
                new CategoryMap
                {
                    Id = 78,
                    Categories = new List<string>
                    {
                        "CD"
                    }
                },
                new CategoryMap
                {
                    Id = 79,
                    Categories = new List<string>
                    {
                        "IN"
                    }
                },
                new CategoryMap
                {
                    Id = 80,
                    Categories = new List<string>{}
                },
                new CategoryMap
                {
                    Id = 81,
                    Categories = new List<string>
                    {
                        "IN"
                    }
                },
                new CategoryMap
                {
                    Id = 82,
                    Categories = new List<string>
                    {
                        "AG", "CD"
                    }
                },
                new CategoryMap
                {
                    Id = 83,
                    Categories = new List<string>
                    {
                        "FR"
                    }
                },
                new CategoryMap
                {
                    Id = 84,
                    Categories = new List<string>
                    {
                        "HY", "AH"
                    }
                },
                new CategoryMap
                {
                    Id = 85,
                    Categories = new List<string>
                    {
                        "FR"
                    }
                },
                new CategoryMap
                {
                    Id = 86,
                    Categories = new List<string>
                    {
                        "AG", "CD"
                    }
                },
                new CategoryMap
                {
                    Id = 87,
                    Categories = new List<string>
                    {
                        "OD"
                    }
                },
                new CategoryMap
                {
                    Id = 88,
                    Categories = new List<string>
                    {
                        "HY"
                    }
                },
                new CategoryMap
                {
                    Id = 89,
                    Categories = new List<string>
                    {
                        "FR"
                    }
                },
                new CategoryMap
                {
                    Id = 90,
                    Categories = new List<string>{}
                },
                new CategoryMap
                {
                    Id = 91,
                    Categories = new List<string>
                    {
                        "AG", "CD"
                    }
                },
                new CategoryMap
                {
                    Id = 92,
                    Categories = new List<string>
                    {
                        "HY"
                    }
                },
                new CategoryMap
                {
                    Id = 93,
                    Categories = new List<string>
                    {
                        "PI"
                    }
                },
                new CategoryMap
                {
                    Id = 94,
                    Categories = new List<string>
                    {
                        "AG", "OD"
                    }
                },
                new CategoryMap
                {
                    Id = 95,
                    Categories = new List<string>{}
                },
                new CategoryMap
                {
                    Id = 96,
                    Categories = new List<string>{}
                },
                new CategoryMap
                {
                    Id = 97,
                    Categories = new List<string>{}
                }
            };
        }
    }
}