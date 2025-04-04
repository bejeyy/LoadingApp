using Load_BusinessDataLogic;

namespace ConsoleApp1

{
    internal class Program
    {
        static void Main(string[] args)
        {

            string userPhoneNumber = "";
            int userPin = 0;

            Console.WriteLine("Log-in");
            do
            {
                Console.Write("Phone Number: ");
                userPhoneNumber = Console.ReadLine();
                Console.Write("Enter PIN: ");
                userPin = Convert.ToInt16(Console.ReadLine());

                if (!LoadProcess.AccountVerification(userPhoneNumber, userPin))
                {
                    Console.WriteLine("ERROR: Either wrong NUMBER or PIN. Try again.\n");
                }

            } while (!LoadProcess.AccountVerification(userPhoneNumber, userPin));

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
                            BuyingGlobeLoad();
                            break;
                        case 3:
                            DisplayGomoDataMenu();
                            BuyingGomoLoad();
                            break;
                        case 4:
                            DisplayDitoDataMenu();
                            BuyingDitoLoad();
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
            Console.WriteLine("\nADD CURRENCY");
            Console.WriteLine("NOTE: Amount must be higher than 50 pesos.");
            double addAmount = 0;
            do
            {
                Console.Write("[Amount]: ");
                addAmount = Convert.ToDouble(Console.ReadLine());

                if (!LoadProcess.CheckCashInAmount(addAmount))
                {
                    Console.WriteLine("\nERROR: Enter amount higher than 50");
                }
                else
                {
                    LoadProcess.UpdateBalance(1, addAmount);
                    Console.WriteLine($"Your new Balance is: {LoadProcess.balance}");
                    LoadProcess.AddToHistory($"CASH IN: You have received {addAmount}.");
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

                if (!LoadProcess.CheckSendAmount(removeAmount))
                {
                    Console.WriteLine("\nERROR, Insufficient Balance");
                }
                else
                {
                    LoadProcess.UpdateBalance(2, removeAmount);
                    Console.WriteLine($"\nSuccessfully sent {removeAmount} to {userNumber}");
                    Console.WriteLine($"Your new Balance is: {LoadProcess.balance}");
                    LoadProcess.AddToHistory($"SEND CASH: You have sent {removeAmount} to {userNumber}.");
                    break;
                }

            } while (!LoadProcess.CheckSendAmount(removeAmount));
        }
        static void DataNetworkMenu()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Available Networks\n");
            foreach (var network in LoadProcess.networks)
            {
                Console.WriteLine(network);
            }
        }
        static void DisplaySmartDataMenu()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("BUY DATA\n");
            foreach (var load in LoadProcess.smartLoads)
            {
                Console.WriteLine(load);
            }
        }
        static void DisplayGlobeDataMenu()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("BUY DATA\n");
            foreach (var load in LoadProcess.globeLoads)
            {
                Console.WriteLine(load);
            }
        }
        static void DisplayGomoDataMenu()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("BUY DATA\n");
            foreach (var load in LoadProcess.gomoLoads)
            {
                Console.WriteLine(load);
            }
        }
        static void DisplayDitoDataMenu()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("BUY DATA\n");
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
                    SmartLoadConfirmation(1);
                    break;
                case 2:
                    SmartLoadConfirmation(2);
                    break;
                case 3:
                    SmartLoadConfirmation(3);
                    break;
                case 4:
                    SmartLoadConfirmation(4);
                    break;
                case 5:
                    SmartLoadConfirmation(5);
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Invalid Action.");
                    break;
            }
        }
        static void SmartLoadConfirmation(int action)
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
        static void BuyingGlobeLoad()
        {
            Console.Write("\nEnter Number: ");
            int dataChoice = Convert.ToInt16(Console.ReadLine());

            switch (dataChoice)
            {
                case 1:
                    GlobeLoadConfirmation(1);
                    break;
                case 2:
                    GlobeLoadConfirmation(2);
                    break;
                case 3:
                    GlobeLoadConfirmation(3);
                    break;
                case 4:
                    GlobeLoadConfirmation(4);
                    break;
                case 5:
                    GlobeLoadConfirmation(5);
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Invalid Action.");
                    break;
            }
        }
        static void GlobeLoadConfirmation(int action)
        {
            if (LoadProcess.BuyingDataProcess(action))
            {
                switch (action)
                {
                    case 1:
                        Console.WriteLine("500mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory("GLOBE: You have bought GoSURF30(500mb)");
                        break;
                    case 2:
                        Console.WriteLine("1000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory("GLOBE: You have bought GoSURF49(1000mb)");
                        break;
                    case 3:
                        Console.WriteLine("3000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory("GLOBE: You have bought GoSURF99(3000mb)");
                        break;
                    case 4:
                        Console.WriteLine("6000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory("GLOBE: You have bought GoSURF149 (6000mb)");
                        break;
                    case 5:
                        Console.WriteLine("10000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory("GLOBE: You have bought GoSURF199 (12000mb)");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Balance is Insufficient.");
            }
        }
        static void BuyingGomoLoad()
        {
            Console.Write("\nEnter Number: ");
            int dataChoice = Convert.ToInt16(Console.ReadLine());

            switch (dataChoice)
            {
                case 1:
                    GomoLoadConfirmation(1);
                    break;
                case 2:
                    GomoLoadConfirmation(2);
                    break;
                case 3:
                    GomoLoadConfirmation(3);
                    break;
                case 4:
                    GomoLoadConfirmation(4);
                    break;
                case 5:
                    GomoLoadConfirmation(5);
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Invalid Action.");
                    break;
            }
        }
        static void GomoLoadConfirmation(int action)
        {
            if (LoadProcess.BuyingDataProcess(action))
            {
                switch (action)
                {
                    case 1:
                        Console.WriteLine("500mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory("GOMO: You have bought GomuGomuNo30(500mb)");
                        break;
                    case 2:
                        Console.WriteLine("1000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory("GOMO: You have bought GomuGomuNo49(1000mb)");
                        break;
                    case 3:
                        Console.WriteLine("3000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory("GOMO: You have bought GomuGomuNo99(3000mb)");
                        break;
                    case 4:
                        Console.WriteLine("6000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory("GOMO: You have bought GomuGomuNo149(6000mb)");
                        break;
                    case 5:
                        Console.WriteLine("10000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory("GOMO: You have bought GomuGomuNo199(12000mb)");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Balance is Insufficient.");
            }
        }
        static void BuyingDitoLoad()
        {
            Console.Write("\nEnter Number: ");
            int dataChoice = Convert.ToInt16(Console.ReadLine());

            switch (dataChoice)
            {
                case 1:
                    DitoLoadConfirmation(1);
                    break;
                case 2:
                    DitoLoadConfirmation(2);
                    break;
                case 3:
                    DitoLoadConfirmation(3);
                    break;
                case 4:
                    DitoLoadConfirmation(4);
                    break;
                case 5:
                    DitoLoadConfirmation(5);
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Invalid Action.");
                    break;
            }
        }
        static void DitoLoadConfirmation(int action)
        {
            if (LoadProcess.BuyingDataProcess(action))
            {
                switch (action)
                {
                    case 1:
                        Console.WriteLine("500mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory("DITO: You have bought Level30(500mb)");
                        break;
                    case 2:
                        Console.WriteLine("1000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory("DITO: You have bought Level49(1000mb)");
                        break;
                    case 3:
                        Console.WriteLine("3000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory("DITO: You have bought Level99(3000mb)");
                        break;
                    case 4:
                        Console.WriteLine("6000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory("DITO: You have bought Level149(6000mb)");
                        break;
                    case 5:
                        Console.WriteLine("10000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory("DITO: You have bought Level199(12000mb)");
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
