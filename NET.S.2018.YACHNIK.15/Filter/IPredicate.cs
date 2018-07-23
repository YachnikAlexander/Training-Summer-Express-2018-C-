using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter
{
    public interface IPredicate<T>
    {
        bool IsMatch(T item);
    }

    public class StringPredicate : IPredicate<string>
    {
        public bool IsMatch(string item) => item.Length >= 3;
    }

    public class IntegerPredicate : IPredicate<int>
    {
        public bool IsMatch(int item) => item % 2 == 0;
    }
}
