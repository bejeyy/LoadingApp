using LoadCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadDataLogic
{
    public class InMemoryDataService : ILoadDataProcess
    {

        List<LoadAccount> accounts = new List<LoadAccount>();
        public List<LoadAccount> GetAllAccounts()
        {
            return accounts;
        }

        public void RegisterAccount(LoadAccount loadAccount)
        {
            foreach (var user in accounts)
            {
                if (user.phoneNumber == loadAccount.phoneNumber)
                {
                    return;
                }
            }
            accounts.Add(loadAccount);
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
