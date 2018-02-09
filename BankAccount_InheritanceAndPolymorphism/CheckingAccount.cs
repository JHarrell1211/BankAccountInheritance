using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_InheritanceAndPolymorphism
{
    public class CheckingAccount : Account
    {
        //fields - none
        //properties - none


        //Constructor
        public CheckingAccount() : base(2319.04, 725630982, "Checking")
        {
            //With get only for these properties, this info wont work, have to base above
            //AccountNumber = 725498167;
            //AccountBalance = 2319.04;
            //AccountType = "Checking";
        }

        //Methods
        public override string PrintAccType()
        {
            return AccountType;
        }

        public override int PrintAccountNum()
        {
            return AccountNumber;
        }

        public override void PrintBalance()
        {
            base.PrintBalance();
        }

        public override double DepositBalance()
        {
            return base.DepositBalance();
        }

        public override double WithdrawBalance()
        {
            return base.WithdrawBalance();
        }
    }
}
