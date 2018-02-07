using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_InheritanceAndPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            string userChoice;
            double deposit = 0;
            double withdrawl = 0;
            string userName = " ";

            Client clientOne = new Client(userName, true, true);
            Console.WriteLine("To Login, Please enter your first and last name");
            userName = Console.ReadLine().ToUpper();
            Console.WriteLine("Hello " + userName + "\n");
            SavingsAccount savOne = new SavingsAccount(100);
            CheckingAccount checkOne = new CheckingAccount();

            while (userInput != 5)
            {
                Console.WriteLine("1.View Client Information");
                Console.WriteLine("2.View Account Balance");
                Console.WriteLine("3.Deposit Funds");
                Console.WriteLine("4.Withdraw Funds");
                Console.WriteLine("5.Exit");
                userInput = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if ((userInput < 1) || (userInput > 5))
                {
                    Console.WriteLine("Invald Entry!");
                }

                if (userInput == 1) // user info
                {
                    Console.WriteLine(userName);
                    Console.WriteLine("Checking Account Number: " + checkOne.AccountNum());
                    Console.WriteLine("Savings Account Number: " + savOne.AccountNum() + "\n");
                }

                if (userInput == 2) //Check Account Balance
                {
                    Console.WriteLine("Account Balance");
                    Console.WriteLine("a. Checking Account");
                    Console.WriteLine("b. Savings Account");
                    userChoice = Console.ReadLine().ToLower();
                    Console.WriteLine("");

                    if (userChoice == "a")
                    {
                        if (clientOne.CheckingStatus == true)
                        {
                            checkOne.Balance();
                        }
                        else
                        {
                            Console.WriteLine("You don't have a Checking Account \n");
                        }
                    }

                    if (userChoice == "b")
                    {
                        if (clientOne.SavingsStatus == true)
                        {
                            savOne.Balance();
                        }
                        else
                        {
                            Console.WriteLine("You don't have a Savings Account \n");
                        }
                    }
                }

                if (userInput == 3) //Deposit
                {
                    Console.WriteLine("Deposit Funds");
                    Console.WriteLine("a. Checking");
                    Console.WriteLine("b. Savings");
                    userChoice = Console.ReadLine().ToLower();
                    Console.WriteLine("");

                    if (userChoice == "a")
                    {
                        if (clientOne.CheckingStatus == true)
                        {
                            Console.WriteLine("Enter Deposit Amount");
                            deposit = int.Parse(Console.ReadLine());

                            while (deposit < 0)
                            {
                                Console.WriteLine("Error!! Enter Deposit Amount: ");
                                deposit = int.Parse(Console.ReadLine());
                            }

                            checkOne.AccountBalance += deposit;
                            checkOne.Balance();
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("You don't have a Checking Account \n");
                        }
                    }

                    if (userChoice == "b")
                    {
                        if (clientOne.SavingsStatus == true)
                        {
                            Console.WriteLine("Enter Deposit Amount");
                            deposit = int.Parse(Console.ReadLine());

                            while (deposit < 0)
                            {
                                Console.WriteLine("Error!! Enter Deposit Amount: ");
                                deposit = int.Parse(Console.ReadLine());
                            }

                            savOne.AccountBalance += deposit;
                            savOne.Balance();
                            Console.WriteLine("");
                        }

                        else
                        {
                            Console.WriteLine("You don't have a Savings Account \n");
                        }
                    }
                }

                if (userInput == 4) //Withdrawl
                {
                    Console.WriteLine("Withdraw Funds");
                    Console.WriteLine("a. Checking");
                    Console.WriteLine("b. Savings");
                    userChoice = Console.ReadLine().ToLower();
                    Console.WriteLine("");

                    if (userChoice == "a")
                    {
                        if (clientOne.CheckingStatus == true)
                        {
                            Console.WriteLine("Enter Withdrawl Amount");
                            withdrawl = int.Parse(Console.ReadLine());

                            while (withdrawl > checkOne.AccountBalance)
                            {
                                Console.WriteLine("Insufficient Funds: Your Account Balance is: " + checkOne.AccountBalance);
                                Console.WriteLine("Enter Withdrawl Amount: ");
                                withdrawl = int.Parse(Console.ReadLine());
                            }
                            
                            checkOne.AccountBalance -= withdrawl;
                            checkOne.Balance();
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("You don't have a Checking Account \n");
                        }
                    }

                    if (userChoice == "b")
                    {
                        if (clientOne.SavingsStatus == true)
                        {
                            Console.WriteLine("Enter Withdrawl Amount");
                            withdrawl = int.Parse(Console.ReadLine());

                            while (withdrawl > savOne.AccountBalance)
                            {
                                Console.WriteLine("Insufficient Funds: Your Account Balance is: " + savOne.AccountBalance);
                                Console.WriteLine("Enter Withdrawl Amount: ");
                                withdrawl = int.Parse(Console.ReadLine());
                            }
                            while ((savOne.AccountBalance - withdrawl) < savOne.MinBalance)
                            {
                                Console.WriteLine("Account balance cannot drop below " + savOne.MinBalance);
                                Console.WriteLine("Enter Withdrawl Amount: ");
                                withdrawl = int.Parse(Console.ReadLine());
                            }

                            savOne.AccountBalance -= withdrawl;
                            savOne.Balance();
                            Console.WriteLine("");
                        }

                        else
                        {
                            Console.WriteLine("You don't have a Savings Account \n");
                        }
                    }
                }

                if (userInput == 5)
                {
                    Console.WriteLine("GoodBye!!!");
                }



            }

        }
    }
}
