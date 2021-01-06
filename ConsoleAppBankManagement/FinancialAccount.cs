using System;

namespace ConsoleAppAccount
{
    internal static class FinancialAccount
    {
        

        private static Account[] account = new Account[2000];
        private static int count = 0;
        private static int total = 0;

        internal static void StartSystem()
        {
            Console.WriteLine("1.Add new Account");
            Console.WriteLine("2.Search Account");
            Console.WriteLine("3.Show All Account Information");
            Console.WriteLine("4.Delete Account");
            Console.WriteLine("5.Deposit");
            Console.WriteLine("6.Withdraw");
            Console.WriteLine("7.Transfer");
            Console.WriteLine("8.Check Balance");
            Console.WriteLine("9.Exit System");
            Console.WriteLine();

            Console.WriteLine("Reply: ");
            string input = Console.ReadLine();
            if(input == "9")
            {
                Console.WriteLine("System has exited.");
            }
            else if(input == "1")
            {
                int decision = count;
                Console.WriteLine("Account types: 1.Savings 2.Current 3.Loan");
                Console.WriteLine("Reply: ");
                string type = Console.ReadLine(); ;
                if(type == "1")
                {
                    Console.WriteLine("Savings Account: ");
                    Console.WriteLine("Enter your name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter account opening date(Day, Month and Year): ");
                    byte myDay = Convert.ToByte(Console.ReadLine());
                    byte myMonth = Convert.ToByte(Console.ReadLine());
                    ushort myYear = Convert.ToUInt16(Console.ReadLine());

                    Console.WriteLine("Enter apartment no:");
                    byte apartmentNo = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("Enter  road no:");
                    byte roadNo = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("Enter district name:");
                    string district = Console.ReadLine();
                    Console.WriteLine("Enter country name:");
                    string country = Console.ReadLine();

                    Console.WriteLine("Enter balance: ");
                    double balance = Convert.ToDouble(Console.ReadLine());

                    FinancialAccount.AddPerson(new Savings(name, new OpeningDate(myDay, myMonth, myYear), new ClientAddress(apartmentNo, roadNo, district, country), balance));



                }
                else if(type == "2")
                {
                    Console.WriteLine("Current Account: ");
                    Console.WriteLine("Enter your name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter account opening date(Day, Month and Year): ");
                    byte myDay = Convert.ToByte(Console.ReadLine());
                    byte myMonth = Convert.ToByte(Console.ReadLine());
                    ushort myYear = Convert.ToUInt16(Console.ReadLine());

                    Console.WriteLine("Enter apartment no:");
                    byte apartmentNo = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("Enter  road no:");
                    byte roadNo = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("Enter district name:");
                    string district = Console.ReadLine();
                    Console.WriteLine("Enter country name:");
                    string country = Console.ReadLine();

                    Console.WriteLine("Enter balance: ");
                    double balance = Convert.ToDouble(Console.ReadLine());

                    FinancialAccount.AddPerson(new Current(name, new OpeningDate(myDay, myMonth, myYear), new ClientAddress(apartmentNo, roadNo, district, country), balance));

                }
                else if(type == "3")
                {
                    Console.WriteLine("Loan Account: ");
                    Console.WriteLine("Enter your name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter account opening date(Day, Month and Year): ");
                    byte myDay = Convert.ToByte(Console.ReadLine());
                    byte myMonth = Convert.ToByte(Console.ReadLine());
                    ushort myYear = Convert.ToUInt16(Console.ReadLine());

                    Console.WriteLine("Enter apartment no:");
                    byte apartmentNo = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("Enter  road no:");
                    byte roadNo = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("Enter district name:");
                    string district = Console.ReadLine();
                    Console.WriteLine("Enter country name:");
                    string country = Console.ReadLine();

                    Console.WriteLine("Enter balance: ");
                    double balance = Convert.ToDouble(Console.ReadLine());

                    FinancialAccount.AddPerson(new Loan(name, new OpeningDate(myDay, myMonth, myYear), new ClientAddress(apartmentNo, roadNo, district, country), balance));

                }
                else
                {
                    Console.WriteLine("Enter valid input and try again!");
                }

                if(decision == count)
                {
                    Console.WriteLine("Account can't be created");
                }
                Console.WriteLine();
                FinancialAccount.StartSystem();
            }

           else if (input == "2")
            {
                Console.WriteLine("Enter the ID:");
                string id = Console.ReadLine();
                int index = FinancialAccount.SearchIndividual(id);
                if(index >= 0)
                {
                    account[index].ShowInfo();
                }
                Console.WriteLine();
                FinancialAccount.StartSystem();

            }

            else if(input == "3")
            {
                FinancialAccount.ShowAll();
                if(total == 0)
                {
                    Console.WriteLine("There is no account available");
                }
                Console.WriteLine();
                FinancialAccount.StartSystem();
            }

            else if(input == "4")
            {
                Console.WriteLine("Enter the ID:");
                string id = Console.ReadLine();
                FinancialAccount.DeleteAccount(id);
                Console.WriteLine();
                FinancialAccount.StartSystem();
            }

            else if (input == "5")
            {
                Console.WriteLine("Enter the ID:");
                string id = Console.ReadLine();
                Console.WriteLine("Enter the amount:");           
                double amount = Convert.ToDouble(Console.ReadLine());
                int index = FinancialAccount.SearchIndividual(id);
                if (index >= 0)
                {
                    double balance = account[index].Balance;
                    account[index].Deposit(amount);
                    if(balance != account[index].Balance)
                    {
                        Console.WriteLine("Transaction Successfull");
                        Console.WriteLine("Updated balance with informations of the account: ");
                        account[index].ShowInfo();
                    }
                    else
                    {
                        Console.WriteLine("Transaction unsuccessfull");
                    }
                }
                else
                {
                    Console.WriteLine("Transaction unsuccessfull");
                }
                Console.WriteLine();
                FinancialAccount.StartSystem();

            }

            else if (input == "6")
            {
                Console.WriteLine("Enter the ID:");
                string id = Console.ReadLine();
                Console.WriteLine("Enter the amount:");
                double amount = Convert.ToDouble(Console.ReadLine());
                int index = FinancialAccount.SearchIndividual(id);
                if (index >= 0)
                {
                    double balance = account[index].Balance;
                    account[index].Withdraw(amount);
                    if (balance != account[index].Balance)
                    {
                        Console.WriteLine("Transaction Successfull");
                        Console.WriteLine("Updated balance with informations of the account: ");
                        account[index].ShowInfo();
                    }
                    else
                    {
                        Console.WriteLine("Transaction unsuccessfull");
                    }
                }
                else
                {
                    Console.WriteLine("Transaction unsuccessfull");
                }
                Console.WriteLine();
                FinancialAccount.StartSystem();

            }

            else if (input == "7")
            {
                Console.WriteLine("Enter sender's ID:");
                string senderId = Console.ReadLine();
                Console.WriteLine("Enter receiver's ID:");
                string receiverId = Console.ReadLine();
                Console.WriteLine("Enter the amount:");
                double amount = Convert.ToDouble(Console.ReadLine());
                FinancialAccount.Transfer(senderId, receiverId, amount);

                Console.WriteLine();
                FinancialAccount.StartSystem();
            }

            else if (input == "8")
            {
                Console.WriteLine("Enter the ID:");
                string id = Console.ReadLine();
                int index = FinancialAccount.SearchIndividual(id);
                if (index >= 0)
                {
                    Console.WriteLine("Current balance of the account : {0}", account[index].Balance);
                }
                Console.WriteLine();
                FinancialAccount.StartSystem();
            }

            else
            {
                Console.WriteLine("Enter valid input and try again!");
                Console.WriteLine();
                FinancialAccount.StartSystem();
            }

        }

        internal static void AddPerson(Account a)
        {
            account[count] = a;
            Console.WriteLine("Account has been created successfully");
            count++;
            total++;
        }

        internal static void ShowAll()
        {
            int index = 0;
            while (index < count)
            {
                if (account[index] != null)
                {
                    account[index].ShowInfo();
                }
                index++;
            }
        }

        internal static int SearchIndividual(string id)
        {
            int index = 0;

            while (index < count)
            {
                if (account[index].Id == id)
                {
                    Console.WriteLine("Account Found");
                    return index;
                }
                index++;
            }

            Console.WriteLine("Account Not found");
            return -1;
           
        }

        internal static void DeleteAccount(string key)
        {
            int index = SearchIndividual(key);

            if ( index >= 0)
            {
                string name = account[index].Name;
                account[index] = null;
                Console.WriteLine(name + "'s account has been deleted.");
                total--;
            }
            else
            {
                Console.WriteLine(" Account can't be deleted.");

            }
        }

        internal static void Transfer(string sender, string receiver, double amount)
        {
            int senderIndex = SearchIndividual(sender);
            int receiverIndex = SearchIndividual(receiver);
            if(senderIndex >= 0 && receiverIndex >= 0)
            {
                if(amount <= account[senderIndex].Balance)
                {
                    account[senderIndex].Balance = account[senderIndex].Balance - amount;
                    account[receiverIndex].Balance = account[receiverIndex].Balance + amount;
                    Console.WriteLine("Transaction Successfull");
                    Console.WriteLine("Updated balance with informations of both accounts: ");
                    account[senderIndex].ShowInfo();
                    account[receiverIndex].ShowInfo();
                }
                else
                {
                    Console.WriteLine("Transaction unsuccessfull");

                }
            }
            else
            {
                Console.WriteLine("Transaction unsuccessfull");

            }

        }
    }
}
