using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SilverAccount : Account
    {
        public SilverAccount(string numberAcc, string firstName, string secondName, string email, decimal balance) :
            base(numberAcc, firstName, secondName,email, balance)
        {

        }

        public SilverAccount(string numberAcc, string firstName, string secondName, string email) :
            base(numberAcc, firstName, secondName, email)
        {

        }

        protected override bool IsValidBalance(decimal balance)
        {
            return balance > 0;
        }

        protected override int CalculateBonucePoints(decimal amount)
        {
            return (int)Math.Round(amount + Balance / 800);
        }
    }
}
