using Load_BusinessDataLogic;

namespace ConsoleApp1

{
    internal class Program
    {
        static void Main(string[] args)
        {

            int userPin = 0;

            Console.WriteLine("Log-in");

            do
            {
                Console.Write("Enter PIN: ");
                userPin = Convert.ToInt16(Console.ReadLine());

                if (!LoadProcess.PinVerification(userPin))
                {
                    Console.WriteLine("WRONG PIN. Try again.\n");
                }

            } while (!LoadProcess.PinVerification(userPin));

            Console.WriteLine("Login Successful");

            while (true)
            {
                DisplayMainMenu();
                int userAction = GetUserInput();

                if (userAction == 1)
                {
                    CashIn();
                }
                else if (userAction == 2)
                {
                    SendCash();
                }
                else if (userAction == 3)
                {
                    DisplayDataMenu();

                    Console.Write("\nEnter Number: ");
                    int dataChoice = Convert.ToInt16(Console.ReadLine());

                    switch (dataChoice)
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
        static void DisplayMainMenu()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("WELCOME");
            Console.WriteLine($"BAL: {LoadProcess.balance}");
            Console.WriteLine("\n1) CASH IN \n2) SEND CASH \n3) Buy DATA \n4) Balance \n0) EXIT");
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

            LoadProcess.UpdateCurrency(1, addAmount);
            Console.WriteLine($"Your new Balance is: {LoadProcess.balance}");
        }
        static void SendCash()
        {
            string userNumber;
            do
            {
                Console.WriteLine("\nSEND CASH");
                Console.Write("[Number]: ");
                userNumber = Console.ReadLine();

                if (!LoadProcess.NumberConfirmation(userNumber))
                {
                    Console.WriteLine("ERROR: Please enter a valid 11 digits number.");
                }

            } while (!LoadProcess.NumberConfirmation(userNumber));

            Console.Write("[Amount to Send]: ");
            double removeAmount = Convert.ToDouble(Console.ReadLine());

            if (LoadProcess.CheckAmount(removeAmount))
            {
                LoadProcess.UpdateCurrency(2, removeAmount);
                Console.WriteLine($"Successfully sent {removeAmount} to {userNumber}");
                Console.WriteLine($"Your new Balance is: {LoadProcess.balance}");
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
            if (LoadProcess.BuyingDataProcess(action))
            {
                switch (action)
                {
                    case 1:
                        Console.WriteLine("500mb data.");
                        Console.WriteLine("Purchase Complete.");
                        break;
                    case 2:
                        Console.WriteLine("1000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        break;
                    case 3:
                        Console.WriteLine("3000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        break;
                    case 4:
                        Console.WriteLine("6000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        break;
                    case 5:
                        Console.WriteLine("10000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Balance is Insufficient.");
            }
        }
        static void DisplayBalance()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Your Balance:");
            Console.WriteLine($"\nBalance: P{LoadProcess.balance}");
            Console.WriteLine($"Data: {LoadProcess.userData}mb");
        }
    }
}
