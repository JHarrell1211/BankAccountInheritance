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
        private double deposit;
        private double withdraw;

        //properties
        public double AccountBalance
        {
            get { return this.accountBalance; }
        }

        public int AccountNumber
        {
            get { return this.accountNumber; }
        }

        public string AccountType
        {
            get { return this.accountType; }
        }
        
        public double Withdraw
        {
            get { return this.withdraw; }
            set { this.withdraw = value; }
        }

        public double Deposit
        {
            get { return this.deposit; }
            set { this.deposit = value; }
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
        public virtual double DepositBalance()
        {
            accountBalance += deposit;
            return accountBalance;
        }

        public virtual double WithdrawBalance()
        {
            accountBalance -= withdraw;
            return accountBalance;
        }

        public abstract int PrintAccountNum();

        public abstract string PrintAccType();

    }
}
