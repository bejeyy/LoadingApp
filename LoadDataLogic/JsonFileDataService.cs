using LoadCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LoadDataLogic
{
    public class JsonFileDataService : ILoadDataProcess
    {
        static List<LoadAccount> loadAccounts = new List<LoadAccount>();
        static string jsonFilePath = "accounts.json";

        public JsonFileDataService()
        {
            ReadJsonDataFromFile();
        }
        public List<LoadAccount> GetAllAccounts()
        {
            return loadAccounts;
        }

        private void ReadJsonDataFromFile()
        {
            string jsonText = File.ReadAllText(jsonFilePath);

            loadAccounts = JsonSerializer.Deserialize<List<LoadAccount>>(jsonText,
        new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new List<LoadAccount>();

            AvoidNullHistory();
        }

        private void WriteJsonDataToFile()
        {
            string jsonString = JsonSerializer.Serialize(loadAccounts, new JsonSerializerOptions
            { WriteIndented = true });

            File.WriteAllText(jsonFilePath, jsonString);
        }

        private void AvoidNullHistory()
        {
            foreach (var account in loadAccounts)
            {
                if (account.history == null)
                {
                    account.history = new List<string>();
                }
            }
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
            loadAccounts.Add(loadAccount);
            WriteJsonDataToFile();
        }

        public void UpdateAccount(LoadAccount loadAccount)
        {
            int index = FindAccountIndex(loadAccount);

            loadAccounts[index].name = loadAccount.name;
            loadAccounts[index].balance = loadAccount.balance;
            loadAccounts[index].data = loadAccount.data;
            loadAccounts[index].pin = loadAccount.pin;
            loadAccounts[index].history = loadAccount.history;

            WriteJsonDataToFile();
        }
    }
}
