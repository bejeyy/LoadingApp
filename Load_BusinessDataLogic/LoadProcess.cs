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

        public static List<string> historyList = new List<string>();
        public static List<UserAccount> userAccounts = new List<UserAccount>();
        public static UserAccount loggedInUser = null;
        public static bool AccountVerification(string enteredPhoneNumber, string userPIN)
        {
            foreach (var account in userAccounts)
            {
                if (account.phoneNumber == enteredPhoneNumber && account.pin == userPIN)
                {
                    loggedInUser = account;
                    return true;
                }
            }
            return false;
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
        public static bool PhoneNumberExists(string enteredNumber)
        {
            foreach (var user in userAccounts)
            {
                if (user.phoneNumber == enteredNumber)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsValidPin(string pin)
        {
            return int.TryParse(pin, out _) && pin.Length >= 4 && pin.Length <= 6;
        }
        public static void AddUserAccount(string phoneNum, string userName, string userPin)
        {
            UserAccount newUser = new UserAccount(phoneNum, userName, userPin);
            userAccounts.Add(newUser);
        }
        public static void AddToHistory(string cash)
        {
            historyList.Add(cash);
        }
        public static bool CurrentPinVerification(string pin)
        {
            if (pin == loggedInUser.pin)
            {
                return true;
            }
            return false;
        }
    }
    public class UserAccount
    {
        public string phoneNumber { get; set; }
        public string name { get; set; }
        public string pin { get; set; }
        public double balance { get; set; }
        public int data { get; set; }

        public UserAccount(string userPhoneNumber, string userName, string userPIN)
        {
            phoneNumber = userPhoneNumber;
            name = userName;
            pin = userPIN;
            balance = 0;
            data = 0;

        }
    }
}
