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
            string userName = " ";

            Client clientOne = new Client(userName, true, true);
            Console.WriteLine("To Login, Please enter your first and last name");
            userName = Console.ReadLine().ToUpper();
            Console.WriteLine("Hello " + userName + "\n");
            SavingsAccount savOne = new SavingsAccount();
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
                    Console.WriteLine(checkOne.PrintAccType() + " Account Number: " + checkOne.PrintAccountNum());
                    Console.WriteLine(savOne.PrintAccType() + "Account Number: " + savOne.PrintAccountNum() + "\n");
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
                            checkOne.PrintBalance();
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
                            savOne.PrintBalance();
                            Console.WriteLine("");
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
                            //deposit = int.Parse(Console.ReadLine());
                            checkOne.Deposit = int.Parse(Console.ReadLine());

                            while (checkOne.Deposit < 0)
                            {
                                Console.WriteLine("Error!! Enter Deposit Amount: ");
                                checkOne.Deposit = int.Parse(Console.ReadLine());
                            }

                            //checkOne.AccountBalance += deposit;
                            checkOne.DepositBalance();
                            checkOne.PrintBalance();
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
                            //deposit = int.Parse(Console.ReadLine());
                            savOne.Deposit = int.Parse(Console.ReadLine());

                            while (savOne.Deposit < 0)
                            {
                                Console.WriteLine("Error!! Enter Deposit Amount: ");
                                savOne.Deposit = int.Parse(Console.ReadLine());
                            }

                            //savOne.AccountBalance += deposit;
                            savOne.DepositBalance();
                            savOne.PrintBalance();
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
                            //withdrawl = int.Parse(Console.ReadLine());
                            checkOne.Withdraw = int.Parse(Console.ReadLine());

                            while (checkOne.Withdraw > checkOne.AccountBalance)
                            {
                                Console.WriteLine("Insufficient Funds: Your Account Balance is: " + checkOne.AccountBalance);
                                Console.WriteLine("Enter Withdrawl Amount: ");
                                checkOne.Withdraw = int.Parse(Console.ReadLine());
                            }

                            //checkOne.AccountBalance -= withdrawl;
                            checkOne.WithdrawBalance();
                            checkOne.PrintBalance();
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
                            savOne.Withdraw = int.Parse(Console.ReadLine());

                            while (savOne.Withdraw > savOne.AccountBalance)
                            {
                                Console.WriteLine("Insufficient Funds: Your Account Balance is: " + savOne.AccountBalance);
                                Console.WriteLine("Enter Withdrawl Amount: ");
                                //withdrawl = int.Parse(Console.ReadLine());
                                savOne.Withdraw = int.Parse(Console.ReadLine());
                            }
                       
                            while ((savOne.AccountBalance - savOne.Withdraw) < savOne.MinBalance)
                            {
                                Console.WriteLine("Account balance cannot drop below " + savOne.MinBalance);
                                Console.WriteLine("Enter Withdrawl Amount: ");
                                //withdrawl = int.Parse(Console.ReadLine());
                                savOne.Withdraw = int.Parse(Console.ReadLine());
                            }

                            //savOne.AccountBalance -= withdrawl;
                            savOne.WithdrawBalance();
                            savOne.PrintBalance();
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
