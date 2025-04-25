using LoadCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadDataLogic
{
    public class LoadDataProcess
    {
        List<LoadAccount> accounts = new List<LoadAccount>();

        public bool AccountVerificationProcess(string enteredPhoneNumber, string userPIN)
        {
            foreach (var account in accounts)
            {
                if (account.phoneNumber == enteredPhoneNumber && account.pin == userPIN)
                {
                    return true;
                }
            }
            return false;
        }

        public bool RegisterAccount(string phoneNum, string userName, string userPin)
        {
            foreach (var user in accounts)
            {
                if (user.phoneNumber == phoneNum)
                {
                    return false;
                }
            }
            LoadAccount newUser = new LoadAccount(phoneNum, userName, userPin);
            accounts.Add(newUser);
            return true;
        }

        public LoadAccount GetUserAccount(string phoneNum)
        {
            foreach (var account in accounts)
            {
                if (account.phoneNumber == phoneNum)
                {
                    return account;
                }
            }
            return null;
        }

        public void AddHistory(LoadAccount loadAccount, string bought)
        {
            loadAccount.history.Add(bought);
        }

        public bool CheckPhoneNumber(string phoneNum)
        {
            foreach (var account in accounts)
            {
                if (account.phoneNumber == phoneNum)
                {
                    return true;
                }
            }
            return false;
        }

        public double GetAccountBalance(string phoneNumber)
        {
            foreach (var account in accounts)
            {
                if (account.phoneNumber == phoneNumber)
                {
                    return account.balance;
                }
            }
            return 0.0;
        }

        public double GetUserData(string phoneNumber)
        {
            foreach (var account in accounts)
            {
                if (account.phoneNumber == phoneNumber)
                {
                    return account.data;
                }
            }
            return 0.0;
        }

        public void UpdateBalance(string phoneNum, double newAmount)
        {
            foreach (var account in accounts)
            {
                if (account.phoneNumber == phoneNum)
                {
                    account.balance = newAmount;
                }
            }
        }

        public void UpdateData(string phoneNum, double newDataAmount)
        {
            foreach (var account in accounts)
            {
                if (account.phoneNumber == phoneNum)
                {
                    account.data = newDataAmount;
                }
            }
        }

        public bool ChangeName(string phoneNum, string newName)
        {
            foreach (var account in accounts)
            {
                if (account.phoneNumber == phoneNum)
                {
                    account.name = newName;
                    return true;
                }
            }
            return false;
        }

        public bool ChangePin(string phoneNum, string newPIN)
        {
            foreach (var account in accounts)
            {
                if (account.phoneNumber == phoneNum)
                {
                    account.pin = newPIN;
                    return true;
                }
            }
            return false;
        }

        public bool CurrentPinChecker(string PIN)
        {
            foreach (var account in accounts)
            {
                if (account.pin == PIN)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
