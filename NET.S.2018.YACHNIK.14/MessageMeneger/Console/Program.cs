using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manager;
using Observers;

namespace SendingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new MessageManager(10);
            var user = new User(manager);
            var admin = new Administrator(manager);
            Console.WriteLine();
            manager.SimulateNewMessage("Minsk", "Riga", "Letter");

            user.StopMessage();
            Console.WriteLine();
            manager.SimulateNewMessage("Warsawa", "Minsk", "SMS");
            Console.ReadKey();
        }
    }
}
