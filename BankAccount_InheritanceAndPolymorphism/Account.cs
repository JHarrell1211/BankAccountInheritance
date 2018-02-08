using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_InheritanceAndPolymorphism
{
    public abstract class Account
    {
        //fields
        private double accountBalance;
        private int accountNumber;
        private string accountType;

        //properties
        public double AccountBalance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }

        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }
        
        //Constructor
        public Account()
        {

        }
        public Account(double accountBalance, int accountNumber, string accountType)
        {
            this.accountBalance = accountBalance;
            this.accountNumber = accountNumber;
            this.accountType = accountType;
        }
        //Methods
        public virtual void PrintBalance()
        {
            Console.WriteLine("Your account balance is " + accountBalance);
        }

        public abstract int PrintAccountNum();

        public abstract string PrintAccType();

    }
}
