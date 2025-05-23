using LoadCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadDataLogic
{
    public class TextFileDataService : ILoadDataProcess
    {
        string filePath = "account.txt";
        List<LoadAccount> loadAccounts = new List<LoadAccount>();

        public TextFileDataService()
        {
            GetDataFromFile();
        }

        private void GetDataFromFile()
        {
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split('|');

                var account = new LoadAccount(parts[0], parts[1], parts[2]);

                account.balance = Convert.ToDouble(parts[3]);
                account.data = Convert.ToDouble(parts[4]);
                account.history = new List<string>(parts[5].Split(','));

                loadAccounts.Add(account);
            }
        }

        private void WriteDataToFile()
        {
            var lines = new string[loadAccounts.Count];

            for (int i = 0; i < loadAccounts.Count; i++)
            {
                var history = string.Join(",", loadAccounts[i].history);
                lines[i] = $"{loadAccounts[i].phoneNumber}|{loadAccounts[i].name}|{loadAccounts[i].pin}|{loadAccounts[i].balance}|{loadAccounts[i].data}|{history}";
            }

            File.WriteAllLines(filePath, lines);
        }

        public List<LoadAccount> GetAllAccounts()
        {
            return loadAccounts;
        }

        private int FindAccountIndex(LoadAccount loadAccount)
        {
            for (int i = 0; i < loadAccounts.Count; i++)
            {
                if (loadAccounts[i].phoneNumber == loadAccount.phoneNumber)
                {
                    return i;
                }
            }
            return -1;
        }

        public void RegisterAccount(LoadAccount loadAccount)
        {
            var historyString = string.Join(",", loadAccount.history ?? new List<string>());
            var newLine = $"{loadAccount.phoneNumber}|{loadAccount.name}|{loadAccount.pin}|{loadAccount.balance}|{loadAccount.data}|{historyString}";
            File.AppendAllText(filePath, newLine + Environment.NewLine);
            loadAccounts.Add(loadAccount);
        }

        public void UpdateAccount(LoadAccount loadAccount)
        {
            int index = FindAccountIndex(loadAccount);

            loadAccounts[index].name = loadAccount.name;
            loadAccounts[index].balance = loadAccount.balance;
            loadAccounts[index].data = loadAccount.data;
            loadAccounts[index].pin = loadAccount.pin;
            loadAccounts[index].history = loadAccount.history;

            WriteDataToFile();
        }
    }
}
