using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public interface ICreateAccount
    {
        Account Create(string numberAcc, string firstName, string secondName, string email, decimal balance = 0);
    }

    public class CreateBaseAccount : ICreateAccount
    {
        public Account Create(string numberAcc, string firstName, string secondName, string email, decimal balance = 0)
        {
            BaseAccount acc = new BaseAccount(numberAcc, firstName, secondName, email, balance);
            return acc;
        }
    }

    public class CreateSilverAccount : ICreateAccount
    {
        public Account Create(string numberAcc, string firstName, string secondName, string email, decimal balance = 0)
        {
            SilverAccount acc = new SilverAccount(numberAcc, firstName, secondName, email, balance);
            return acc;
        }
    }

    public class CreateGoldAccount : ICreateAccount
    {
        public Account Create(string numberAcc, string firstName, string secondName, string email, decimal balance = 0)
        {
            GoldAccount acc = new GoldAccount(numberAcc, firstName, secondName, email, balance);
            return acc;
        }
    }

    public class CreatePlatinumAccount : ICreateAccount
    {
        public Account Create(string numberAcc, string firstName, string secondName, string email, decimal balance = 0)
        {
            PlatinumAccount acc = new PlatinumAccount(numberAcc, firstName, secondName, email, balance);
            return acc;
        }
    }
}
