using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Models
{
    public class Fizz : IDivisimajig
    {
        public int Number { get; set; }
        public string Output { get; set; }

        public Fizz()
        {
            Number = 3;
            Output = "Fizz";
        }
    }
}
