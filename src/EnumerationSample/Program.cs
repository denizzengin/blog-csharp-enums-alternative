// See https://aka.ms/new-console-template for more information
using EnumerationSample;

Console.WriteLine("Hello, World!");


//int bank = ServicePointTypeEnumeration.Bank;
IWithdraw withdraw = new WithdrawService();

Console.WriteLine(withdraw.Withdraw(new Account
{
    ServicePointType = ServicePointType.Bank,
    Balance = 100.000m,
    ServicePointTypeEnumeration = ServicePointTypeEnumeration.Bank
}));

Console.ReadLine();