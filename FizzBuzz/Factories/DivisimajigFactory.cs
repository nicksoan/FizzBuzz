using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Models;

namespace FizzBuzz.Factories
{
    public class DivisimajigFactory
    {
        public  IEnumerable<IDivisimajig> Divisimajigs { get; set; }

        public DivisimajigFactory()
        {
            List<IDivisimajig> divisimajigs = new List<IDivisimajig>();
            divisimajigs.Add(new Bipp());
            divisimajigs.Add(new Fizz());
            divisimajigs.Add(new Buzz());
            divisimajigs.Add(new Bozz());

            Divisimajigs = divisimajigs;
        }
    }
}
