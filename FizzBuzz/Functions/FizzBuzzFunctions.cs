using FizzBuzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Functions
{
    public class FizzBuzzFunctions
    {
        public List<string> GenerateFizzBuzz(int startNumber, int runLength, IEnumerable<IDivisimajig> divisimajigs)
        {
            List<string> results = new List<string>();

            for (int i = startNumber; i <= runLength; i++)
            {
                string output = divisimajigs
                    .Where(d => i % d.Number == 0)
                    .Aggregate("", (acc, d) => acc + d.Output);

                if (string.IsNullOrEmpty(output))
                {
                    output = i.ToString();
                }

                results.Add($"{output} ({i})");
            }

            return results;
        }

        public IEnumerable<IDivisimajig> GetDivisimajigs()
        {
            Factories.DivisimajigFactory divisimajigFactory = new Factories.DivisimajigFactory();

            return divisimajigFactory.Divisimajigs;
        }


    }
}
