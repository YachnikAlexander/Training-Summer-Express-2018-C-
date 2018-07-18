using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public class GenerateByRandom : IAccountNumberGenerator
    {
        public string GenerateAccountNumber()
        {
            Random rnd = new Random();
            return rnd.ToString();
        }
    }
}
