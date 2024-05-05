using System.Reflection;

namespace EnumerationSample;

public class Enumeration : IComparable
{
    public int Id { get; private set; }

    public string Name { get; private set; }

    protected Enumeration(int id, string name) => (Id, Name) = (id, name);

    public override string ToString() => Name;

    public static IEnumerable<T> GetAll<T>() where T : Enumeration =>
        typeof(T).GetFields(BindingFlags.Public |
                            BindingFlags.Static |
                            BindingFlags.DeclaredOnly)
                .Select(x => x.GetValue(null))
                .Cast<T>();

    public int CompareTo(object? other)
    {
        ArgumentNullException.ThrowIfNull(other);

        return Id.CompareTo(((Enumeration)other).Id);
    }

    public static implicit operator int(Enumeration enumeration) => enumeration.Id;
}
