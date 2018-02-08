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
        public CheckingAccount()
        {
            AccountNumber = 725498167;
            AccountBalance = 2319.04;
            AccountType = "Checking";
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
    }
}
