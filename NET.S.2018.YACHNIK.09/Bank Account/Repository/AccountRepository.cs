using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccount;

namespace Repository
{
    public class AccountRepository
    {
        public List<Account> repository;

        public AccountRepository(AccountRepository repos)
        {
            if(repos == null)
            {
                throw new ArgumentNullException($"{0} is null", nameof(repos));
            }

            repository = new List<Account>();
            repository = repos.repository;
        }

        public AccountRepository(List<Account> repos)
        {
            if (repos == null)
            {
                throw new ArgumentNullException($"{0} is null", nameof(repos));
            }

            repository = repos;
        }

        public AccountRepository()
        {
            repository = new List<Account>();
        }

        public void Save(Account acc)
        {
            if(acc == null)
            {
                throw new ArgumentNullException(nameof(acc));
            }

            this.repository.Add(acc);
        }

        public Account GetById(string id)
        {
            for(int i = 0; i < repository.Count; i++)
            {
                if(repository[i].NumberAcc == id)
                {
                    return repository[i];
                }
            }

            return null;
        }
    }
}
