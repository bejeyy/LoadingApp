using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Load_BusinessDataLogic
{
    public class LoadProcess
    {
        public static double balance = 0.0;
        public static int userData = 0;
        static int pin = 1111;

        public static bool PinVerification(int userPin)
        {
            return userPin == pin;
        }

        public static bool UpdateCurrency(int userInput, double amount)
        {
            if (userInput == 1)
            {
                balance += amount;
                return true;
            }
            else if (userInput == 2 && amount <= balance)
            {
                balance -= amount;
                return true;
            }
            return false;
        }

        public static bool CheckAmount(double amount)
        {
            return amount <= balance;
        }
        public static bool BuyingDataProcess(int action)
        {
            if (action == 1)
            {
                if (balance >= 30)
                {
                    balance -= 30;
                    userData += 500;
                    return true;
                }
            }
            else if (action == 2)
            {
                if (balance >= 49)
                {
                    balance -= 49;
                    userData += 1000;
                    return true;
                }
            }
            else if (action == 3)
            {
                if (balance >= 99)
                {
                    balance -= 99;
                    userData += 3000;
                    return true;
                }
            }
            else if (action == 4)
            {
                if (balance >= 149)
                {
                    balance -= 149;
                    userData += 6000;
                    return true;
                }
            }
            else if (action == 5)
            {
                if (balance >= 199)
                {
                    balance -= 199;
                    userData += 10000;
                    return true;
                }
            }
            return false;
        }
        public static bool NumberConfirmation(string num)
        {
            if (num.Length == 11)
            {
                int.TryParse(num, out int number);
                return true;
            }
            return false;
        }
    }
}
