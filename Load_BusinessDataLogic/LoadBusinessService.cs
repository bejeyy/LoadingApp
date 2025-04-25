using LoadCommon;
using LoadDataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Load_BusinessDataLogic
{
    public class LoadBusinessService
    {
        LoadDataProcess loadDataProcess = new LoadDataProcess();

        public static List<string> historyList = new List<string>();

        public bool AddUserAccount(string phoneNum, string userName, string userPin)
        {
            return loadDataProcess.RegisterAccount(phoneNum, userName, userPin);
        }

        public bool AccountVerification(string enteredPhoneNumber, string userPIN)
        {
            return loadDataProcess.AccountVerificationProcess(enteredPhoneNumber, userPIN);
        }

        public LoadAccount SetUser(string phoneNum)
        {
            return loadDataProcess.GetUserAccount(phoneNum);
        }

        public bool PhoneNumberExist(string phoneNum)
        {
            return loadDataProcess.CheckPhoneNumber(phoneNum);
        }

        public bool UpdateBalance(int userInput, double amount, string phoneNum)
        {
            double balance = loadDataProcess.GetAccountBalance(phoneNum);

            if (userInput == 1 && amount > 0)
            {
                balance += amount;
                loadDataProcess.UpdateBalance(phoneNum, balance);
                return true;
            }
            else if (userInput == 2 && amount <= balance)
            {
                balance -= amount;
                loadDataProcess.UpdateBalance(phoneNum, balance);
                return true;
            }
            return false;
        }

        public bool CheckCashInAmount(double amount)
        {
            return amount > 50;
        }

        public bool CheckSendAmount(double amount, string phoneNum)
        {
            double balance = loadDataProcess.GetAccountBalance(phoneNum);
            return amount > 0 && amount <= balance;
        }

        public bool BuyingDataProcess(int action, string phoneNum)
        {
            double balance = loadDataProcess.GetAccountBalance(phoneNum);
            double userData = loadDataProcess.GetUserData(phoneNum);

            if (action == 1)
            {
                if (balance >= 30)
                {
                    balance -= 30;
                    userData += 500;
                    loadDataProcess.UpdateBalance(phoneNum, balance);
                    loadDataProcess.UpdateData(phoneNum, userData);
                    return true;
                }
            }
            else if (action == 2)
            {
                if (balance >= 49)
                {
                    balance -= 49;
                    userData += 1000;
                    loadDataProcess.UpdateBalance(phoneNum, balance);
                    loadDataProcess.UpdateData(phoneNum, userData);
                    return true;
                }
            }
            else if (action == 3)
            {
                if (balance >= 99)
                {
                    balance -= 99;
                    userData += 3000;
                    loadDataProcess.UpdateBalance(phoneNum, balance);
                    loadDataProcess.UpdateData(phoneNum, userData);
                    return true;
                }
            }
            else if (action == 4)
            {
                if (balance >= 149)
                {
                    balance -= 149;
                    userData += 6000;
                    loadDataProcess.UpdateBalance(phoneNum, balance);
                    loadDataProcess.UpdateData(phoneNum, userData);
                    return true;
                }
            }
            else if (action == 5)
            {
                if (balance >= 199)
                {
                    balance -= 199;
                    userData += 10000;
                    loadDataProcess.UpdateBalance(phoneNum, balance);
                    loadDataProcess.UpdateData(phoneNum, userData);
                    return true;
                }
            }
            return false;
        }

        public bool NumberConfirmation(string num)
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

        public bool IsValidPin(string pin)
        {
            return int.TryParse(pin, out _) && pin.Length >= 4 && pin.Length <= 6;
        }

        public bool CurrentPinVerification(string pin)
        {
            return loadDataProcess.CurrentPinChecker(pin);
        }

        public bool ChangeName(string phoneNumber, string newName)
        {
            return loadDataProcess.ChangeName(phoneNumber, newName);
        }

        public bool ChangePIN(string phoneNumber, string newPIN)
        {
            return loadDataProcess.ChangePin(phoneNumber, newPIN);
        }

        public void AddToHistory(LoadAccount user, string bought)
        {
            loadDataProcess.AddHistory(user, bought);
        }
    }
}
