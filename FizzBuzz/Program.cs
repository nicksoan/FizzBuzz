using System;
using System.Collections.Generic;
using System.Linq;
using FizzBuzz.Functions;
using FizzBuzz.Models;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            int startNumber = 1;
            int runLength = 100;
            FizzBuzzFunctions fizzBuzzFunctions = new FizzBuzzFunctions();
            IEnumerable<IDivisimajig> checkModel = fizzBuzzFunctions.GetDivisimajigs();
            List<string> results = fizzBuzzFunctions.GenerateFizzBuzz(startNumber, runLength, checkModel);

            foreach (string result in results)
            {
                Console.WriteLine(result);
            }

            //Run(startNo,runLength, checkModel);
        }



        private static void Run(int startNo, int runLength, IEnumerable<IDivisimajig> checkModel)
        {
            //some change
            for (int i = startNo; i <= runLength; i++)
            {
                List<OutputModel> outputModel = new List<OutputModel>();
                string output = "";
                string outputNos = "";
                foreach (var check in checkModel)
                {
                    if (i % check.Number == 0)
                    {
                        output += check.Output;
                    }
                }
                if (output == "")
                {
                    output = i.ToString();
                }
                outputNos = i.ToString();

                Console.WriteLine($"{output} ({outputNos})");
            }
        }

    }
}
