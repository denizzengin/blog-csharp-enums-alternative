namespace EnumerationSample;

public class ServicePointTypeEnumeration : Enumeration
{
    public static readonly ServicePointTypeEnumeration IndependentAtm = new(1, nameof(IndependentAtm), 5_000.000m);

    public static readonly ServicePointTypeEnumeration BankAtm = new(2, nameof(BankAtm), 50_000.000m);

    public static readonly ServicePointTypeEnumeration Bank = new(3, nameof(Bank), decimal.MaxValue);

    protected ServicePointTypeEnumeration(int id, string name, decimal limit) : base(id, name)
    {
        Limit = limit;
    }

    public decimal Limit { get; set; }
}

