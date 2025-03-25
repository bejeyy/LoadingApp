namespace ConsoleApp1

{
    internal class Program
    {
        static double balance = 0.0;
        static int userData = 0;

        static void Main(string[] args)
        {
            int pin = 1111;
            int userPin = 0;
            int attempts = 3;

            do
            {
                Console.Write("Enter PIN: ");
                userPin = Convert.ToInt16(Console.ReadLine());

                if (userPin != pin)
                {
                    Console.WriteLine("WRONG PIN. Try again");
                    attempts--;
                    Console.WriteLine($"{attempts} attemps remaining.\n");
                }

            } while (userPin != pin && attempts > 0);

            Console.WriteLine("Login Successful");

            while (true)
            {
                DisplayMenu();
                int userAction = GetUserInput();

                if (userAction == 1)
                {
                    CashIn();
                }
                else if (userAction == 2)
                {
                    CashOut();
                }
                else if (userAction == 3)
                {
                    DisplayDataMenu();

                    Console.Write("\nEnter Number: ");
                    int actionInput = Convert.ToInt16(Console.ReadLine());

                    switch (actionInput)
                    {
                        case 1:
                            BuyingData(1);
                            break;
                        case 2:
                            BuyingData(2);
                            break;
                        case 3:
                            BuyingData(3);
                            break;
                        case 4:
                            BuyingData(4);
                            break;
                        case 5:
                            BuyingData(5);
                            break;
                        case 0:
                            break;
                        default:
                            Console.WriteLine("Invalid Action.");
                            break;
                    }

                }
                else if (userAction == 4)
                {
                    DisplayBalance();
                }
                else if (userAction == 0)
                {
                    Console.WriteLine("Thank you for using this system. Exiting...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Action");

                }
            }
        }
        static void DisplayMenu()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("WELCOME");
            Console.WriteLine($"BAL: {balance}");
            Console.WriteLine("\n1) Add Currency \n2) CASHOUT \n3) Buy DATA \n4) Balance \n0) EXIT");
        }
        static int GetUserInput()
        {
            Console.Write("\nEnter Action: ");
            int userInput = Convert.ToInt16(Console.ReadLine());

            return userInput;
        }
        static void CashIn()
        {
            Console.WriteLine("\nADD CURRENCY");
            Console.Write("[Amount]: ");
            double addAmount = Convert.ToDouble(Console.ReadLine());

            balance += addAmount;
            Console.WriteLine($"Your new Balance is: {balance}");
        }
        static void CashOut()
        {
            Console.WriteLine("\nCASH OUT");
            Console.Write("[Amount]: ");
            double removeAmount = Convert.ToDouble(Console.ReadLine());

            if (balance >= removeAmount)
            {
                balance -= removeAmount;
                Console.WriteLine($"Your new Balance is: {balance}");
            }
            else
            {
                Console.WriteLine("ERROR, Insufficient Balance");
            }
        }
        static void DisplayDataMenu()
        {
            Console.WriteLine("\nBUY DATA\n");

            string[] loads = new string[] { "1) GigaChad30 (500mb)", "2) GigaChad49 (1000mb)", "3) GigaChad99 (3000mb)", "4) GigaChad149 (6000mb)", "5) GigaChad199 (12000mb)", "0) Return" };

            foreach (var load in loads)
            {
                Console.WriteLine(load);
            }
        }
        static void BuyingData(int action)
        {
            if (action == 1)
            {
                if (balance >= 30)
                {
                    Console.WriteLine("\n500mb Data");
                    Console.WriteLine("Purchase Complete.");

                    balance -= 30;
                    userData += 500;
                }
                else
                {
                    Console.WriteLine("Insufficient Balance.");
                }
            }
            else if (action == 2)
            {
                if (balance >= 49)
                {
                    Console.WriteLine("\n1000mb Data");
                    Console.WriteLine("Purchase Complete.");

                    balance -= 49;
                    userData += 1000;
                }
                else
                {
                    Console.WriteLine("Insufficient Balance.");
                }
            }
            else if (action == 3)
            {
                if (balance >= 99)
                {
                    Console.WriteLine("\n3000mb Data");
                    Console.WriteLine("Purchase Complete.");

                    balance -= 99;
                    userData += 3000;

                }
                else
                {
                    Console.WriteLine("Insufficient Balance.");

                }
            }
            else if (action == 4)
            {
                if (balance >= 149)
                {
                    Console.WriteLine("\n6000mb Data");
                    Console.WriteLine("Purchase Complete.");

                    balance -= 149;
                    userData += 6000;
                }
                else
                {
                    Console.WriteLine("Insufficient Balance.");

                }
            }
            else if (action == 5)
            {
                if (balance >= 199)
                {
                    Console.WriteLine("\n12000mb Data");
                    Console.WriteLine("Purchase Complete.");

                    balance -= 199;
                    userData += 12000;
                }
                else
                {
                    Console.WriteLine("Insufficient Balance.");
                }
            }
        }
        static void DisplayBalance()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Your Balance:");
            Console.WriteLine($"\nBalance: P{balance}");
            Console.WriteLine($"Data: {userData}mb");
        }
    }
}
