using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public enum Accounts
    {
        Base,
        Silver, 
        Gold, 
        Platinum
    }

    public enum Statuses
    {
        active,
        unactive
    }

    public abstract class Account
    {
        public string NumberAcc { get; private set; }
        public Person Person { get; private set; }
        public Statuses Status { get; private set; }

        public decimal Balance
        {
            get => Balance;

            set => Balance = IsValidBalance(Balance) ? value : throw new ArgumentException(nameof(Balance));
        }

        protected int BonucePoints
        {
            get => BonucePoints;

            set => BonucePoints = value >= 0 ? value : throw new ArgumentException(nameof(BonucePoints));
        }

        public void CloseAccount()
        {
            this.Status = Statuses.unactive;
        }

        public Account(string numberAcc, string firstName, string secondName, string email, decimal balance)
        {
            if(numberAcc == null)
            {
                throw new ArgumentNullException(nameof(numberAcc));
            }

            if (firstName == null)
            {
                throw new ArgumentNullException(nameof(firstName));
            }

            if (secondName == null)
            {
                throw new ArgumentNullException(nameof(secondName));
            }

            if(balance < 0)
            {
                throw new ArgumentException(nameof(balance));
            }

            this.Balance = balance;
            this.NumberAcc = String.Copy(numberAcc);
            this.Person.FirstName = String.Copy(firstName);
            this.Person.LastName = String.Copy(secondName);
            this.Person.Email = String.Copy(email);
            this.Status = Statuses.active;
        }

        public Account(string numberAcc, string firstName, string secondName, string email)
        {
            if (numberAcc == null)
            {
                throw new ArgumentNullException(nameof(numberAcc));
            }

            if (firstName == null)
            {
                throw new ArgumentNullException(nameof(firstName));
            }

            if (secondName == null)
            {
                throw new ArgumentNullException(nameof(secondName));
            }

            if(email == null)
            {
                throw new ArgumentNullException(nameof(email));
            }

            this.Balance = 0;
            this.NumberAcc = String.Copy(numberAcc);
            this.Person.FirstName = String.Copy(firstName);
            this.Person.LastName = String.Copy(secondName);
            this.Person.Email = String.Copy(email);
            this.Status = Statuses.active;
        }

        public void Deposite(decimal amount)
        {
            if(amount < 0)
            {
                throw new ArgumentException(nameof(amount));
            }

            Balance += amount;
            BonucePoints += CalculateBonucePoints(amount);
        }

        public void Whithdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException(nameof(amount));
            }

            Balance += amount;
            BonucePoints += CalculateBonucePoints(amount);
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }

            if(obj is Account)
            {
                Account acc = obj as Account;

                return this.NumberAcc == acc.NumberAcc;
            }
            else
            {
                return false;
            } 
        }

        protected abstract int CalculateBonucePoints(decimal amount);
        protected abstract bool IsValidBalance(decimal balance);
    }
}
