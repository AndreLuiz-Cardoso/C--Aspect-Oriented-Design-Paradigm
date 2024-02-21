using System;

namespace Projec_c
{
    class Program
    {
        static void Main()
        {
            var currentAccount = new CurrentAccount { Balance = 1000 };
            var savingsAccount = new SavingsAccount { Balance = 500 };

            MakeWithdrawal(currentAccount, 800);
            MakeWithdrawal(savingsAccount, 600);
        }

        static void MakeWithdrawal(BankAccount account, decimal value)
        {
            account.MakeWithdrawal(value);
        }
    }
}