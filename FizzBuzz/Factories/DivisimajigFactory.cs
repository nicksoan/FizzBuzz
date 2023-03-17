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
        public IEnumerable<IDivisimajig> Divisimajigs { get; set; }

        public DivisimajigFactory() : this(GetDefaultDivisimajigs()) { }

        public DivisimajigFactory(IEnumerable<IDivisimajig> divisimajigs)
        {
            Divisimajigs = divisimajigs;
        }

        private static List<IDivisimajig> GetDefaultDivisimajigs()
        {
            return new List<IDivisimajig>
            {
                new Bipp(),
                new Fizz(),
                new Buzz(),
                new Bozz()
            };
        }

        public static DivisimajigFactory Default()
        {
            return new DivisimajigFactory(GetDefaultDivisimajigs());
        }

    }
}
