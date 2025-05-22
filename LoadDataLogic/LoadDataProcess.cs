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

        public List<LoadAccount> GetAccounts()
        {
            return accounts;
        }

        private int FindAccountIndex(LoadAccount loadAccount)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].phoneNumber == loadAccount.phoneNumber)
                {
                    return i;
                }
            }
            return -1;
        }

        public void UpdateAccount(LoadAccount loadAccount)
        {
            int index = FindAccountIndex(loadAccount);

            accounts[index].name = loadAccount.name;
            accounts[index].balance = loadAccount.balance;
            accounts[index].data = loadAccount.data;
            accounts[index].pin = loadAccount.pin;
            accounts[index].history = loadAccount.history;
        }


    }
}
