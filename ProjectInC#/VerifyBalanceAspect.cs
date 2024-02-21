using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PostSharp.Aspects;

namespace Projec_c
{
    [Serializable]
    public class CheckBalanceAspect : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            if (args.Arguments.Count > 0 && args.Arguments[0] is decimal value)
            {
                BankAccount account = args.Instance as BankAccount;
                if (account != null)
                {
                    if (account.Balance < value)
                    {
                        Console.WriteLine($"Insufficient balance in {account.GetType().Name} to withdraw {value:C}. ");
                        args.FlowBehavior = FlowBehavior.Return;
                    }
                }
            }
        }
    }
}