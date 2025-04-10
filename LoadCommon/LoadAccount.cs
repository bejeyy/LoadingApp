using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadCommon
{
    public class LoadAccount
    {
        public string phoneNumber { get; set; }
        public string name { get; set; }
        public string pin { get; set; }
        public double balance { get; set; }
        public double data { get; set; }
        public List<string> history { get; set; }

        public LoadAccount(string userPhoneNumber, string userName, string userPIN)
        {
            phoneNumber = userPhoneNumber;
            name = userName;
            pin = userPIN;
            balance = 0;
            data = 0;
            history = new List<string>();

        }
    }
}
