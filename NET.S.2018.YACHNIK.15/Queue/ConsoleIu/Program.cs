using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCollection;

namespace ConsoleIu
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enequeue(1);
            queue.Enequeue(2);
            queue.Enequeue(5);
            queue.Enequeue(7);
            queue.Enequeue(9);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("2 step");
            queue.Dequeue();

            Queue<int> queue1 = new Queue<int>(queue);

            foreach(var item in queue1)
            {
                Console.WriteLine(item);
            }

            queue1.Clear();
            Console.WriteLine("3 step");

            foreach (var item in queue1)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
