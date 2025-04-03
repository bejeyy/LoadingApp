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
                    DataNetworkMenu();

                    Console.Write("\nWhich Network: ");
                    int networkChoice = Convert.ToInt16(Console.ReadLine());

                    switch (networkChoice)
                    {
                        case 1:
                            DisplaySmartDataMenu();
                            BuyingSmartLoad();
                            break;
                        case 2:
                            DisplayGlobeDataMenu();
                            break;
                        case 3:
                            DisplayGomoDataMenu();
                            break;
                        case 4:
                            DisplayDitoDataMenu();
                            break;
                        case 0:
                            break;
                        default:
                            Console.WriteLine("ERROR: Invalid Action.");
                            break;
                    }

                }
                else if (userAction == 4)
                {
                    DisplayBalance();
                }
                else if (userAction == 5)
                {
                    ShowHistory();
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
            Console.WriteLine("\n1) CASH IN \n2) SEND CASH \n3) Buy DATA \n4) Balance \n5) History \n0) EXIT");
        }
        static int GetUserInput()
        {
            Console.Write("\nEnter Action: ");
            int userInput = Convert.ToInt16(Console.ReadLine());

            return userInput;
        }
        static void CashIn()
        {
            double addAmount = 0;
            do
            {
                Console.WriteLine("\nADD CURRENCY");
                Console.Write("[Amount]: ");
                addAmount = Convert.ToDouble(Console.ReadLine());

                if (!LoadProcess.CheckCashInAmount(addAmount))
                {
                    Console.WriteLine("ERROR: Enter number higher than 50");
                } else
                {
                    LoadProcess.UpdateBalance(1, addAmount);
                    Console.WriteLine($"Your new Balance is: {LoadProcess.balance}");
                    LoadProcess.AddToHistory($"Received amount: {addAmount}");
                }

            } while (!LoadProcess.CheckCashInAmount(addAmount));
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

            double removeAmount = 0;
            do
            {
                Console.Write("[Amount to Send]: ");
                removeAmount = Convert.ToDouble(Console.ReadLine());

                if (LoadProcess.CheckSendAmount(removeAmount))
                {
                    LoadProcess.UpdateBalance(2, removeAmount);
                    Console.WriteLine($"\nSuccessfully sent {removeAmount} to {userNumber}");
                    Console.WriteLine($"Your new Balance is: {LoadProcess.balance}");
                    LoadProcess.AddToHistory($"Sent {removeAmount} to {userNumber}");
                }
                else
                {
                    Console.WriteLine("\nERROR, Insufficient Balance");
                }
            } while (!LoadProcess.CheckSendAmount(removeAmount));
        }
        static void DataNetworkMenu()
        {
            foreach (var network in LoadProcess.networks)
            {
                Console.WriteLine(network);
            }
        }
        static void DisplaySmartDataMenu()
        {
            Console.WriteLine("\nBUY DATA\n");

            foreach (var load in LoadProcess.smartLoads)
            {
                Console.WriteLine(load);
            }
        }
        static void DisplayGlobeDataMenu()
        {
            Console.WriteLine("\nBUY DATA\n");

            foreach (var load in LoadProcess.globeLoads)
            {
                Console.WriteLine(load);
            }
        }
        static void DisplayGomoDataMenu()
        {
            Console.WriteLine("\nBUY DATA\n");

            foreach (var load in LoadProcess.gomoLoads)
            {
                Console.WriteLine(load);
            }
        }
        static void DisplayDitoDataMenu()
        {
            Console.WriteLine("\nBUY DATA\n");

            foreach (var load in LoadProcess.ditoLoads)
            {
                Console.WriteLine(load);
            }
        }
        static void DisplayBalance()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Your Balance:");
            Console.WriteLine($"\nBalance: P{LoadProcess.balance}");
            Console.WriteLine($"Data: {LoadProcess.userData}mb");
        }

        static void ShowHistory()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("History\n");
            foreach (var history in LoadProcess.historyList)
            {
                Console.WriteLine(history);
            }
        }
        static void BuyingSmartLoad()
        {
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
        static void BuyingData(int action)
        {
            if (LoadProcess.BuyingDataProcess(action))
            {
                switch (action)
                {
                    case 1:
                        Console.WriteLine("500mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory("SMART: You have bought GigaChad30(500mb)");
                        break;
                    case 2:
                        Console.WriteLine("1000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory("SMART: You have bought GigaChad49(1000mb)");
                        break;
                    case 3:
                        Console.WriteLine("3000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory("SMART: You have bought GigaChad99(3000mb)");
                        break;
                    case 4:
                        Console.WriteLine("6000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory("SMART: You have bought GigaChad149 (6000mb)");
                        break;
                    case 5:
                        Console.WriteLine("10000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory("SMART: You have bought GigaChad199 (12000mb)");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Balance is Insufficient.");
            }
        }
    }
}
