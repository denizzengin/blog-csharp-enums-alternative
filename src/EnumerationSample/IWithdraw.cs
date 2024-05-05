namespace EnumerationSample;


public interface IWithdraw
{
    public bool Withdraw(Account account);
}

public class Account
{
    public decimal Balance { get; set; }

    public ServicePointType ServicePointType { get; set; }

    public ServicePointTypeEnumeration? ServicePointTypeEnumeration { get; set; }
}

public class WithdrawService : IWithdraw
{
    public bool Withdraw(Account account)
    {
        if (!CanWithdraw(account))
        {
            return false;
        }

        // todo

        return true;
    }

    private static decimal GetLimit(ServicePointType servicePointType) => servicePointType switch
    {
        ServicePointType.IndependentAtm => 5_000.000m,
        ServicePointType.BankAtm => 50_000.000m,
        ServicePointType.Bank => decimal.MaxValue,
        _ => default
    };

    private static bool CanWithdraw(Account account)
    {

        // todo validations
        //GetLimit(account.ServicePointType) >= account.Balance;
        return account.ServicePointTypeEnumeration!.Limit >= account.Balance;
    }
}