using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Load_BusinessDataLogic
{
    public class LoadProcess
    {
        public static double balance = 0.0;
        public static int userData = 0;
        static string userNumber = "09471111111";
        static int pin = 1111;
        public static string[] networks = new string[] { "1) Smart ", "2) Globe", "3) GOMO", "4) DITO", "0) Return" };
        public static string[] smartLoads = new string[] { "1) GigaChad30 (500mb)", "2) GigaChad49 (1000mb)", "3) GigaChad99 (3000mb)", "4) GigaChad149 (6000mb)", "5) GigaChad199 (12000mb)", "0) Return" };
        public static string[] globeLoads = new string[] { "1) GoSURF30 (500mb)", "2) GoSURF49 (1000mb)", "3) GoSURF99 (3000mb)", "4) GoSURF149 (6000mb)", "5) GoSURF199 (12000mb)", "0) Return" };
        public static string[] gomoLoads = new string[] { "1) GomuGomuNo30 (500mb)", "2) GomuGomuNo49 (1000mb)", "3) GomuGomuNo99 (3000mb)", "4) GomuGomuNo149 (6000mb)", "5) GomuGomuNo199 (12000mb)", "0) Return" };
        public static string[] ditoLoads = new string[] { "1) Level30 (500mb)", "2) Level49 (1000mb)", "3) Level99 (3000mb)", "4) Level149 (6000mb)", "5) Level199 (12000mb)", "0) Return" };

        public static List<string> historyList = new List<string>(); 

        public static bool AccountVerification(string phoneNumber, int userPin)
        {
            return phoneNumber == userNumber && userPin == pin;
        }
        public static bool UpdateBalance(int userInput, double amount)
        {
            if (userInput == 1 && amount > 0)
            {
                balance += amount;
                return true;
            }
            else if (userInput == 2 && amount <= balance)
            {
                balance -= amount;
                return true;
            }
            return false;
        }
        public static bool CheckCashInAmount(double amount)
        {
            return amount > 50;
        }
        public static bool CheckSendAmount(double amount)
        {
            return amount > 0 && amount <= balance;
        }
        public static bool BuyingDataProcess(int action)
        {
            if (action == 1)
            {
                if (balance >= 30)
                {
                    balance -= 30;
                    userData += 500;
                    return true;
                }
            }
            else if (action == 2)
            {
                if (balance >= 49)
                {
                    balance -= 49;
                    userData += 1000;
                    return true;
                }
            }
            else if (action == 3)
            {
                if (balance >= 99)
                {
                    balance -= 99;
                    userData += 3000;
                    return true;
                }
            }
            else if (action == 4)
            {
                if (balance >= 149)
                {
                    balance -= 149;
                    userData += 6000;
                    return true;
                }
            }
            else if (action == 5)
            {
                if (balance >= 199)
                {
                    balance -= 199;
                    userData += 10000;
                    return true;
                }
            }
            return false;
        }
        public static bool NumberConfirmation(string num)
        {
            string numbersAllowed = "0123456789";

            if (num.Length != 11)
            {
                return false;
            }

            foreach (char c in num)
            {
                if (!numbersAllowed.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }
        public static void AddToHistory(string cash)
        {
            historyList.Add(cash);
        }
    }
}
