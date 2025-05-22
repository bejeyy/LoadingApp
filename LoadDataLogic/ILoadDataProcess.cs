using LoadCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadDataLogic
{
    public interface ILoadDataProcess
    {
        public List<LoadAccount> GetAccounts();
        public void RegisterAccount();
        public void UpdateAccount(LoadAccount loadAccount);
    }
}
