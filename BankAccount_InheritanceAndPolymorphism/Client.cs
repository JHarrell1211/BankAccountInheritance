using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_InheritanceAndPolymorphism
{
   public class Client
    {
        private string name;
        private bool checkingStatus;
        private bool savingsStatus;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public bool CheckingStatus
        {
            get { return this.checkingStatus; }
            set { this.checkingStatus = value; }
        }

        public bool SavingsStatus
        {
            get { return this.savingsStatus; }
            set { this.savingsStatus = value; }
        }

        public Client()
        {

        }

        public Client(string name, bool checking, bool savings)
        {
            this.name = name;
            this.checkingStatus = checking;
            this.savingsStatus = savings;
        }

        //public string ClientInfo()
        //{
        //    return name + " Checking Account # " + , Savings Account: " + savings;
        //}
    }
}
