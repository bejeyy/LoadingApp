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
        ILoadDataProcess loadDataProcess;
        public LoadDataProcess()
        {
            loadDataProcess = new TextFileDataService();
            //loadDataProcess = new InMemoryDataService();
        }

        public void RegisterAccount(LoadAccount newUser)
        {
            loadDataProcess.RegisterAccount(newUser);
        }

        public List<LoadAccount> GetAccounts()
        {
            return loadDataProcess.GetAllAccounts();
        }

        public void UpdateAccount(LoadAccount loadAccount)
        {
            loadDataProcess.UpdateAccount(loadAccount);
        }
    }
}
