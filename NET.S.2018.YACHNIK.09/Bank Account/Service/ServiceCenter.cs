using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator;
using Repository;
using BankAccount;

namespace Service
{
    public class ServiceCenter
    {
        private AccountRepository repos;

        public ServiceCenter()
        {
            AccountRepository repos = new AccountRepository();
        }

        public ServiceCenter(AccountRepository Repos)
        {
            if(Repos == null)
            {
                throw new ArgumentNullException($"Reposytory is null", nameof(Repos));
            }

            List<Account> storage = Repos.repository;

            AccountRepository repos = new AccountRepository(storage);
        }

        public ServiceCenter(List<Account> Repos)
        {
            if (Repos == null)
            {
                throw new ArgumentNullException($"Reposytory is null", nameof(Repos));
            }

            List<Account> storage = Repos;

            AccountRepository repos = new AccountRepository(storage);
        }

        public Account CreateAccount(string firstName, string secondName, string email,decimal balance, IAccountNumberGenerator generator, ICreateAccount creator)
        {
            //здесь подумать как передать какой именно аккаунт
            if (firstName == null)
            {
                throw new ArgumentNullException(nameof(firstName));
            }

            if (secondName == null)
            {
                throw new ArgumentNullException(nameof(secondName));
            }

            if (email == null)
            {
                throw new ArgumentNullException(nameof(email));
            }

            string id = generator.GenerateAccountNumber();
            Account acc = creator.Create(id, firstName, secondName, email, balance);
            repos.Save(acc);
            return acc;
        }

        public void CloseAccount(string numberAcc)
        {
            Account acc = repos.GetById(numberAcc);
            acc.CloseAccount();
        }

        public void Deposite(string id, decimal amount)
        {
            Account acc = repos.GetById(id);
            acc.Deposite(amount);
        }

        public Account GetById(string id)
        {
            return repos.GetById(id);
        }

        public void Withdrow(string id, decimal amount)
        {
            Account acc = repos.GetById(id);
            acc.Whithdraw(amount);
        }
    }
}
