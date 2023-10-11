namespace PsychologicalTesting.Extensions;

public static class StringExtensions
{
    public static T GetEnumValueByName<T>(this string searchValue ) where T : Enum
    {
        foreach (var name in Enum.GetNames(typeof(T)))
        {
            if (string.Equals(name, searchValue, StringComparison.CurrentCultureIgnoreCase))
            {
                return (T)Enum.Parse(typeof(T), name);
            }
        }

        throw new ArgumentException($"Enum with value {searchValue} not found on type {typeof(T).Name}");
    }
}