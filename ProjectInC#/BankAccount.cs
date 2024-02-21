using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using Projec_c;

namespace Projec_c
{
    public class BankAccount
    {
        public decimal Balance { get; set; }
        public virtual void MakeWithdrawal(decimal value)
        {
            if (Balance >= value)
            {
                Balance -= value;
                Console.WriteLine($"Withdrawal of {value:C} success. ");
            }
            else
            {
                Console.WriteLine($"Insufficient balance to withdraw {value:C}. ");
            }
        }
    }
    public class CurrentAccount : BankAccount { }
    public class SalaryAccount : BankAccount { }
    public class SavingsAccount : BankAccount { }
    public class InvestmentAccount : BankAccount { }
}