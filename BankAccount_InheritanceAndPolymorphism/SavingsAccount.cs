using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_InheritanceAndPolymorphism
{
    public class SavingsAccount : Account
    {
        //fields
        private double minBalance;

        //properties
        public double MinBalance
        {
            get { return this.minBalance; }
            //set { this.minBalance = value; }
        }

        //Constructors
        public SavingsAccount():base (4384.74, 45672301,"Savings" )
        {
            minBalance = 100;
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
