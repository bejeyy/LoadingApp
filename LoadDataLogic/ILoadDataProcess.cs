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
        public List<LoadAccount> GetAllAccounts();
        public void RegisterAccount(LoadAccount loadAccount);
        public void UpdateAccount(LoadAccount loadAccount);
    }
}
