using Load_BusinessDataLogic;
using LoadCommon;
using System.Net.NetworkInformation;

namespace ConsoleApp1

{
    internal class Program
    {
        static string[] networks = new string[] { "1) Smart ", "2) Globe", "3) GOMO", "4) DITO", "0) Return" };
        static string[] smartLoads = new string[] { "1) GigaChad30 (500mb)", "2) GigaChad49 (1000mb)", "3) GigaChad99 (3000mb)", "4) GigaChad149 (6000mb)", "5) GigaChad199 (12000mb)", "0) Return" };
        static string[] globeLoads = new string[] { "1) GoSURF30 (500mb)", "2) GoSURF49 (1000mb)", "3) GoSURF99 (3000mb)", "4) GoSURF149 (6000mb)", "5) GoSURF199 (12000mb)", "0) Return" };
        static string[] gomoLoads = new string[] { "1) GomuGomuNo30 (500mb)", "2) GomuGomuNo49 (1000mb)", "3) GomuGomuNo99 (3000mb)", "4) GomuGomuNo149 (6000mb)", "5) GomuGomuNo199 (12000mb)", "0) Return" };
        static string[] ditoLoads = new string[] { "1) Level30 (500mb)", "2) Level49 (1000mb)", "3) Level99 (3000mb)", "4) Level149 (6000mb)", "5) Level199 (12000mb)", "0) Return" };
        static string[] profileActions = new string[] { "1) Change Name", "2) Change PIN", "0) Back" };

        static LoadBusinessService LoadProcess = new LoadBusinessService();
        static LoadAccount loggedInUser = null;
        static string phoneNumber = "";
        static string pin = "";

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
                Console.WriteLine("0. Exit");
                Console.Write("\nSelect an option: ");
                int choice = Convert.ToInt16(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        LogIn();
                        break;
                    case 2:
                        SignUp();
                        break;
                    case 0:
                        Console.WriteLine("Thank you for using this system. Exiting....");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
        static void SignUp()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("REGISTER ACCOUNT\n");

            do
            {
                Console.Write("Enter Phone Number: ");
                phoneNumber = Console.ReadLine();

                if (!LoadProcess.NumberConfirmation(phoneNumber))
                {
                    Console.WriteLine("ERROR: Enter a valid number with 11 digits\n");

                }
                else if (LoadProcess.PhoneNumberExist(phoneNumber))
                {
                    Console.WriteLine("ERROR: Account number already exist.\n");
                }

            } while (!LoadProcess.NumberConfirmation(phoneNumber) || LoadProcess.PhoneNumberExist(phoneNumber));

            string userName;
            do
            {
                Console.Write("Enter Name: ");
                userName = Console.ReadLine();

                if(string.IsNullOrEmpty(userName))
                {
                    Console.WriteLine("ERROR: Enter a Name.\n");
                }

            } while (string.IsNullOrEmpty(userName));

            string PIN;
            do
            {
                Console.Write("Enter PIN: ");
                PIN = Console.ReadLine();

                if (!LoadProcess.IsValidPin(PIN))
                {
                    Console.WriteLine("ERROR: Enter a valid 4-6 digits PIN\n.");
                }

            } while (!LoadProcess.IsValidPin(PIN));

            Console.WriteLine("Account registered. You can now Log In.");
            Console.WriteLine("-------------------------------------------");
            LoadProcess.AddUserAccount(phoneNumber, userName, PIN);

        }

        static void LogIn()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("LOG IN ACCOUNT\n");

            do
            {
                Console.Write("Enter your phone number: ");
                phoneNumber = Console.ReadLine();

                Console.Write("Enter your PIN: ");
                pin = Console.ReadLine();

                if (!LoadProcess.AccountVerification(phoneNumber, pin))
                {
                    Console.WriteLine("ERROR: Either wrong Phone Number or PIN.\n");
                }
            } while (!LoadProcess.AccountVerification(phoneNumber, pin));

            loggedInUser = LoadProcess.SetUser(phoneNumber, pin);
            Console.WriteLine("Log In successful.");
            Console.Clear();
            LoadingSystem();
        }

        static void LoadingSystem()
        {
            while (true)
            {
                DisplaySystemActions();
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
                else if (userAction == 6)
                {
                    ShowProfile();
                }
                else if (userAction == 0)
                {
                    loggedInUser = null;
                    Console.WriteLine("Logging out...");
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Action");

                }
            }
        }

        static void DisplaySystemActions()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"WELCOME {loggedInUser.name}");
            Console.WriteLine($"BAL: {loggedInUser.balance}");
            Console.WriteLine("\n1) CASH IN \n2) SEND CASH \n3) Buy DATA \n4) Balance \n5) History \n6) Profile \n0) LOGOUT");
        }

        static int GetUserInput()
        {
            Console.Write("\nEnter Action: ");
            int userInput = Convert.ToInt16(Console.ReadLine());

            return userInput;
        }

        static void CashIn()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("ADD CURRENCY");
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
                    LoadProcess.UpdateBalance(1, addAmount, phoneNumber, pin);
                    loggedInUser = LoadProcess.SetUser(phoneNumber, pin);
                    Console.WriteLine($"Your new Balance is: {loggedInUser.balance}");
                    LoadProcess.AddToHistory(loggedInUser, $"CASH IN: You have received {addAmount}.");
                }

            } while (!LoadProcess.CheckCashInAmount(addAmount));
        }

        static void SendCash()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("SEND CASH");
            string userNumber;
            do
            {
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

                if (!LoadProcess.CheckSendAmount(removeAmount, phoneNumber, pin))
                {
                    Console.WriteLine("\nERROR, Insufficient Balance");
                }
                else
                {
                    LoadProcess.UpdateBalance(2, removeAmount, phoneNumber, pin);
                    loggedInUser = LoadProcess.SetUser(phoneNumber, pin);
                    Console.WriteLine($"\nSuccessfully sent {removeAmount} to {userNumber}");
                    Console.WriteLine($"Your new Balance is: {loggedInUser.balance}");
                    LoadProcess.AddToHistory(loggedInUser, $"SEND CASH: You have sent {removeAmount} to {userNumber}.");
                    break;
                }

            } while (!LoadProcess.CheckSendAmount(removeAmount, phoneNumber, pin));
        }

        static void DataNetworkMenu()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Available Networks\n");
            foreach (var network in networks)
            {
                Console.WriteLine(network);
            }
        }

        static void DisplaySmartDataMenu()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("BUY DATA\n");
            foreach (var load in smartLoads)
            {
                Console.WriteLine(load);
            }
        }

        static void DisplayGlobeDataMenu()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("BUY DATA\n");
            foreach (var load in globeLoads)
            {
                Console.WriteLine(load);
            }
        }

        static void DisplayGomoDataMenu()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("BUY DATA\n");
            foreach (var load in gomoLoads)
            {
                Console.WriteLine(load);
            }
        }

        static void DisplayDitoDataMenu()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("BUY DATA\n");
            foreach (var load in ditoLoads)
            {
                Console.WriteLine(load);
            }
        }

        static void DisplayBalance()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Your Balance:");
            loggedInUser = LoadProcess.SetUser(phoneNumber, pin);
            Console.WriteLine($"\nBalance: P{loggedInUser.balance}");
            Console.WriteLine($"Data: {loggedInUser.data}mb");
        }

        static void ShowHistory()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Your Transactions\n");
            foreach (var boughtHistory in loggedInUser.history)
            {
                Console.WriteLine(boughtHistory);
            }
        }

        static void ShowProfile()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Name: {loggedInUser.name}");
            Console.WriteLine($"Phone Number: {loggedInUser.phoneNumber}\n");

            foreach (var actions in profileActions)
            {
                Console.WriteLine(actions);
            }

            int action = GetUserInput();

            switch (action)
            {
                case 1:
                    ChangeName();
                    break;
                case 2:
                    ChangePIN();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("ERROR: Invalid action input.");
                    break;
            }
        }

        static void ChangeName()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("CHANGE NAME");
            do
            {
                Console.Write("Enter new Name: ");
                string newName = Console.ReadLine();

                if (!string.IsNullOrEmpty(newName))
                {
                    LoadProcess.ChangeName(phoneNumber, pin, newName);
                    loggedInUser = LoadProcess.SetUser(phoneNumber, pin);
                    Console.WriteLine("Name updated sucessfully.");
                    return;
                }
                else
                {
                    Console.WriteLine("\nERROR. Input a name");
                }
            } while (true);
        }

        static void ChangePIN()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("CHANGE PIN");
            Console.Write("Enter your current PIN: ");
            string currentPIN = Console.ReadLine();

            if (LoadProcess.CurrentPinVerification(currentPIN))
            {
                do
                {
                    Console.Write("Enter your new PIN: ");
                    string newPIN = Console.ReadLine();

                    if (LoadProcess.IsValidPin(newPIN))
                    {
                        LoadProcess.ChangePIN(phoneNumber, pin, newPIN);
                        pin = newPIN;
                        loggedInUser = LoadProcess.SetUser(phoneNumber, pin);
                        Console.WriteLine("PIN updated successfully.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("\nERROR: Enter a valid number PIN with 4-6 digits");
                    }

                } while (true);

            }
            else
            {
                Console.WriteLine("ERROR: Wrong PIN.");
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
            if (LoadProcess.BuyingDataProcess(action, phoneNumber, pin))
            {
                switch (action)
                {
                    case 1:
                        Console.WriteLine("500mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory(loggedInUser, "SMART: You have bought GigaChad30(500mb)");
                        break;
                    case 2:
                        Console.WriteLine("1000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory(loggedInUser, "SMART: You have bought GigaChad49(1000mb)");
                        break;
                    case 3:
                        Console.WriteLine("3000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory(loggedInUser, "SMART: You have bought GigaChad99(3000mb)");
                        break;
                    case 4:
                        Console.WriteLine("6000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory(loggedInUser, "SMART: You have bought GigaChad149 (6000mb)");
                        break;
                    case 5:
                        Console.WriteLine("10000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory(loggedInUser, "SMART: You have bought GigaChad199 (12000mb)");
                        break;
                }
                loggedInUser = LoadProcess.SetUser(phoneNumber, pin);
                Console.WriteLine($"\nUpdated Balance: P{loggedInUser.balance}");
                Console.WriteLine($"Updated Data: {loggedInUser.data}mb");
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
            if (LoadProcess.BuyingDataProcess(action, phoneNumber, pin))
            {
                switch (action)
                {
                    case 1:
                        Console.WriteLine("500mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory(loggedInUser, "GLOBE: You have bought GoSURF30(500mb)");
                        break;
                    case 2:
                        Console.WriteLine("1000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory(loggedInUser, "GLOBE: You have bought GoSURF49(1000mb)");
                        break;
                    case 3:
                        Console.WriteLine("3000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory(loggedInUser, "GLOBE: You have bought GoSURF99(3000mb)");
                        break;
                    case 4:
                        Console.WriteLine("6000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory(loggedInUser, "GLOBE: You have bought GoSURF149 (6000mb)");
                        break;
                    case 5:
                        Console.WriteLine("10000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory(loggedInUser, "GLOBE: You have bought GoSURF199 (12000mb)");
                        break;
                }
                loggedInUser = LoadProcess.SetUser(phoneNumber, pin);
                Console.WriteLine($"\nUpdated Balance: P{loggedInUser.balance}");
                Console.WriteLine($"Updated Data: {loggedInUser.data}mb");
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
            if (LoadProcess.BuyingDataProcess(action, phoneNumber, pin))
            {
                switch (action)
                {
                    case 1:
                        Console.WriteLine("500mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory(loggedInUser, "GOMO: You have bought GomuGomuNo30(500mb)");
                        break;
                    case 2:
                        Console.WriteLine("1000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory(loggedInUser, "GOMO: You have bought GomuGomuNo49(1000mb)");
                        break;
                    case 3:
                        Console.WriteLine("3000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory(loggedInUser, "GOMO: You have bought GomuGomuNo99(3000mb)");
                        break;
                    case 4:
                        Console.WriteLine("6000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory(loggedInUser, "GOMO: You have bought GomuGomuNo149(6000mb)");
                        break;
                    case 5:
                        Console.WriteLine("10000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory(loggedInUser, "GOMO: You have bought GomuGomuNo199(12000mb)");
                        break;
                }
                loggedInUser = LoadProcess.SetUser(phoneNumber, pin);
                Console.WriteLine($"\nUpdated Balance: P{loggedInUser.balance}");
                Console.WriteLine($"Updated Data: {loggedInUser.data}mb");
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
            if (LoadProcess.BuyingDataProcess(action, phoneNumber, pin))
            {
                switch (action)
                {
                    case 1:
                        Console.WriteLine("500mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory(loggedInUser, "DITO: You have bought Level30(500mb)");
                        break;
                    case 2:
                        Console.WriteLine("1000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory(loggedInUser, "DITO: You have bought Level49(1000mb)");
                        break;
                    case 3:
                        Console.WriteLine("3000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory(loggedInUser, "DITO: You have bought Level99(3000mb)");
                        break;
                    case 4:
                        Console.WriteLine("6000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory(loggedInUser, "DITO: You have bought Level149(6000mb)");
                        break;
                    case 5:
                        Console.WriteLine("10000mb data.");
                        Console.WriteLine("Purchase Complete.");
                        LoadProcess.AddToHistory(loggedInUser, "DITO: You have bought Level199(12000mb)");
                        break;
                }
                loggedInUser = LoadProcess.SetUser(phoneNumber, pin);
                Console.WriteLine($"\nUpdated Balance: P{loggedInUser.balance}");
                Console.WriteLine($"Updated Data: {loggedInUser.data}mb");
            }
            else
            {
                Console.WriteLine("Balance is Insufficient.");
            }
        }

    }
}
