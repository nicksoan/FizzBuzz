using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Models
{
    public class Buzz : IDivisimajig
    {
        public int Number { get; set; }
        public string Output { get; set; }

        public Buzz()
        {
            Number = 5;
            Output = "Buzz";
        }
    }
}
