using LoadCommon;
using LoadDataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Load_BusinessDataLogic
{
    public class LoadBusinessService
    {
        LoadDataProcess loadDataProcess = new LoadDataProcess();


        public void AddUserAccount(string phoneNum, string userName, string userPin)
        {
            LoadAccount newUser = new LoadAccount(phoneNum, userName, userPin);
            loadDataProcess.RegisterAccount(newUser);
        }

        public bool AccountVerification(string enteredPhoneNumber, string userPIN)
        {
            var account = GetLoadAccount(enteredPhoneNumber, userPIN);

            if (account != null)
            {
                return true;
            }

            return false;

        }

        public LoadAccount SetUser(string phoneNum, string pin)
        {
            return GetLoadAccount(phoneNum, pin);
        }

        public bool PhoneNumberExist(string phoneNum)
        {
            var loadAccounts = loadDataProcess.GetAccounts();

            foreach (var account in loadAccounts)
            {
                if (account.phoneNumber == phoneNum)
                {
                    return true;
                }
            }
            return false;
        }

        public bool UpdateBalance(int userInput, double amount, string phoneNum, string pin)
        {
            var loadAccount = GetLoadAccount(phoneNum, pin);

            if (userInput == 1 && amount > 0)
            {
                loadAccount.balance += amount;
                loadDataProcess.UpdateAccount(loadAccount);
                return true;
            }
            else if (userInput == 2 && amount <= loadAccount.balance)
            {
                loadAccount.balance -= amount;
                loadDataProcess.UpdateAccount(loadAccount);
                return true;
            }
            return false;
        }

        public bool CheckCashInAmount(double amount)
        {
            return amount > 50;
        }

        public bool CheckSendAmount(double amount, string phoneNum, string pin)
        {
            var loadAccount = GetLoadAccount(phoneNum, pin);
            return amount > 0 && amount <= loadAccount.balance;
        }

        public bool BuyingDataProcess(int action, string phoneNum, string pin)
        {
            var loadAccount = GetLoadAccount(phoneNum, pin);

            if (action == 1)
            {
                if (loadAccount.balance >= 30)
                {
                    loadAccount.balance -= 30;
                    loadAccount.data += 500;
                    loadDataProcess.UpdateAccount(loadAccount);
                    return true;
                }
            }
            else if (action == 2)
            {
                if (loadAccount.balance >= 49)
                {
                    loadAccount.balance -= 49;
                    loadAccount.data += 1000;
                    loadDataProcess.UpdateAccount(loadAccount);
                    return true;
                }
            }
            else if (action == 3)
            {
                if (loadAccount.balance >= 99)
                {
                    loadAccount.balance -= 99;
                    loadAccount.data += 3000;
                    loadDataProcess.UpdateAccount(loadAccount);
                    return true;
                }
            }
            else if (action == 4)
            {
                if (loadAccount.balance >= 149)
                {
                    loadAccount.balance -= 149;
                    loadAccount.data += 6000;
                    loadDataProcess.UpdateAccount(loadAccount);
                    return true;
                }
            }
            else if (action == 5)
            {
                if (loadAccount.balance >= 199)
                {
                    loadAccount.balance -= 199;
                    loadAccount.data += 10000;
                    loadDataProcess.UpdateAccount(loadAccount);
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
            var loadAccounts = loadDataProcess.GetAccounts();

            foreach (var account in loadAccounts)
            {
                if (account.pin == pin)
                {
                    return true;
                }
            }
            return false;
        }

        public void ChangeName(string phoneNumber, string pin, string newName)
        {
            var loadAccount = GetLoadAccount(phoneNumber, pin);
            loadAccount.name = newName;
            loadDataProcess.UpdateAccount(loadAccount);
        }

        public void ChangePIN(string phoneNumber, string pin, string newPIN)
        {
            var loadAccount = GetLoadAccount(phoneNumber, pin);
            loadAccount.pin = newPIN;
            loadDataProcess.UpdateAccount(loadAccount);
        }

        public void AddToHistory(LoadAccount user, string bought)
        {
            user.history.Add(bought);
            loadDataProcess.UpdateAccount(user);
        }

        private LoadAccount GetLoadAccount(string phoneNumber, string PIN)
        {
            var loadAccount = loadDataProcess.GetAccounts();
            LoadAccount foundAccount = null;

            foreach (var account in loadAccount)
            {
                if (account.phoneNumber == phoneNumber && account.pin == PIN)
                {
                    foundAccount = account;
                }
            }
            return foundAccount;
        }
    }
}
