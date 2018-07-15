using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccaunt
{
    public class Account
    {
        #region Private Fields
        private int costOfBalance;
        private int costOfReplenishment;
        private double bonusPoints;
        private bool status;

        private static int quantityOfAccouns = 0;
        private static string[] setOfGradation = new string[] { "Base", "Silver", "Gold", "Platinum" };
        #endregion

        #region public Properties
        /// <summary>
        /// get Number of account
        /// </summary>
        public int Number { get; private set; }

        /// <summary>
        /// get FirstName of owner
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// get Second Name of owner
        /// </summary>
        public string SecondName { get; set; }

        /// <summary>
        /// get Ammount of account
        /// </summary>
        public double Ammount { get; private set; }

        /// <summary>
        /// get Gradation of account
        /// </summary>
        public string Gradation { get; private set; }
        #endregion

        #region Public Methods
        /// <summary>
        /// Cnstr for initializing bank account
        /// </summary>
        /// <param name="firstName">first name of owner</param>
        /// <param name="secondName">second name of owner</param>
        /// <param name="amount">amount of money</param>
        /// <exception cref="ArgumentNullException">throw if firstName is null</exception>
        /// <exception cref="ArgumentNullException">throw if secondName is null</exception>
        /// <exception cref="ArgumentException">throw if amount less than 0</exception>
        public Account(string firstName, string secondName, double amount)
        {
            if(firstName == null)
            {
                throw new ArgumentNullException(nameof(firstName));
            }

            if (secondName == null)
            {
                throw new ArgumentNullException(nameof(secondName));
            }

            if(amount < 0)
            {
                throw new ArgumentException(nameof(amount));
            }

            this.FirstName = String.Copy(firstName);
            this.SecondName = String.Copy(secondName);
            this.Ammount = amount;
            this.Number = quantityOfAccouns;
            this.Gradation = "Base";
            this.status = true;

            SetCostsAndBonusPoints();
            quantityOfAccouns++;

            Greeting();
        }

        /// <summary>
        /// Cnstr for initializing bank account
        /// </summary>
        /// <param name="firstName">first name of owner</param>
        /// <param name="secondName">second name of owner</param>
        /// <param name="amount">amount of money</param>
        /// <param name="gradation">Gradation of Account</param>
        /// <exception cref="ArgumentNullException">throw if firstName is null</exception>
        /// <exception cref="ArgumentNullException">throw if secondName is null</exception>
        /// <exception cref="ArgumentException">throw if amount less than 0</exception>
        /// <exception cref="ArgumentNullException">throw if gradation is null</exception>
        public Account(string firstName, string secondName, double amount, string gradation)
        {
            if (firstName == null)
            {
                throw new ArgumentNullException(nameof(firstName));
            }

            if (secondName == null)
            {
                throw new ArgumentNullException(nameof(secondName));
            }

            if(gradation == null)
            {
                throw new ArgumentNullException(nameof(gradation));
            }

            if (amount < 0)
            {
                throw new ArgumentException(nameof(amount));
            }

            this.FirstName = String.Copy(firstName);
            this.SecondName = String.Copy(secondName);
            this.Ammount = amount;
            this.Number = quantityOfAccouns;
            this.Gradation = String.Copy(gradation);
            this.status = true;

            SetCostsAndBonusPoints();
            quantityOfAccouns++;

            Greeting();
        }
        #endregion

        #region Private Methods
        private void AddFunds(double money)
        {
            this.Ammount += money;
            this.bonusPoints += this.costOfReplenishment;

            Greeting();
        }

        private void Debit(double money)
        {
            this.Ammount -= money;
            this.bonusPoints -= this.costOfBalance;

            Greeting();
        }

        private void Closed()
        {
            this.status = false;
            Greeting();
        }

        private void GetAmountOnConsole()
        {
            Console.WriteLine(this.Ammount);
            Greeting();
        }

        private void GetNumberOnConsole()
        {
            Console.WriteLine(this.Number);
            Greeting();
        }
        private void Greeting()
        {
            Console.WriteLine("Do u wanna perform any operations on account?");
            Console.WriteLine("U can choose one of them");
            Console.WriteLine("0: add Funds, 1:debit the account, 2:Create new account, 3: Close account, " +
                "      4:view Amouunt of money, 5:view Number of money");
            string op = Console.ReadLine();
            int operation;
            bool flag = Int32.TryParse(op, out operation);

            if (flag && this.status)
            {
                switch (operation)
                {
                    case 0:
                        Console.WriteLine("Enter the sum");
                        int money;
                        bool fMoney = Int32.TryParse(Console.ReadLine(), out money);
                        if (fMoney)
                        {
                            this.AddFunds(money);
                        }
                        break;

                    case 1:
                        Console.WriteLine("Enter the sum");
                        fMoney = Int32.TryParse(Console.ReadLine(), out money);
                        if (fMoney)
                        {
                            this.Debit(money);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Creating new Account, Wait a minut");
                        break;
                    case 3:
                        Console.WriteLine("Closing Account");
                        this.Closed();
                        Console.WriteLine("Account is closed");
                        break;
                    case 4:
                        GetAmountOnConsole();
                        break;
                    case 5:
                        GetNumberOnConsole();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Your Account is closed");
            }
            Console.ReadKey();
        }

        private void SetCostsAndBonusPoints()
        {
            int coef = Array.IndexOf(setOfGradation, this.Gradation) + 1;
            this.costOfBalance = (int)((coef) / 1000);
            this.costOfReplenishment = (int)((coef)/ 10000);
            this.bonusPoints = (coef-1)*2;
        }

        #endregion
    }
}
