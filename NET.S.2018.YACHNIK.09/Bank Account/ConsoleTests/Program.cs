using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using Generator;
using BankAccount;

namespace ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        { 
            ServiceCenter service = new ServiceCenter();
            Account acc1 = service.CreateAccount("sash", "yachik", "sa@mail.ru", 900000, new GenerateByRandom(), new CreateGoldAccount());
            Account acc2= service.CreateAccount("sasha", "yik", "sa@il.ru", 780000, new GenerateByRandom(), new CreatePlatinumAccount());
            Account acc3 = service.CreateAccount("sasha", "yacik", "sa@mil.ru", 9000, new GenerateByRandom(), new CreatePlatinumAccount());
            Account acc = service.CreateAccount("sasha", "yachnik", "sa@mail.u", 560000, new GenerateByRandom(), new CreateBaseAccount());

            Console.WriteLine(acc.Balance);
            Console.WriteLine(acc.NumberAcc);

            service.Deposite(acc.NumberAcc, 2000);
            Console.WriteLine(acc.Balance);

            service.Withdrow(acc.NumberAcc, 1000);
            Console.WriteLine(acc.Balance);

            Account newAcc = service.GetById(acc1.NumberAcc);
            Console.WriteLine(newAcc);

            acc.CloseAccount();
            Console.WriteLine(acc.Status);
        }
    }
}
