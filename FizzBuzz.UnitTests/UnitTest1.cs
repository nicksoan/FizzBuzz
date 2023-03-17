using FizzBuzz.Functions;
using FizzBuzz.Models;

namespace FizzBuzz.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GenerateFizzBuzz_WithDefaultDivisimajigs_ReturnsExpectedResults()
        {
            // Arrange
            int startNumber = 1;
            int runLength = 15;
            FizzBuzzFunctions fizzBuzzFunctions = new FizzBuzzFunctions();
            IEnumerable<IDivisimajig> divisimajigs = fizzBuzzFunctions.GetDivisimajigs();

            List<string> expectedResults = new List<string>
        {
            "1 (1)",
            "2 (2)",
            "Fizz (3)",
            "4 (4)",
            "Buzz (5)",
            "Fizz (6)",
            "7 (7)",
            "8 (8)",
            "Fizz (9)",
            "Buzz (10)",
            "11 (11)",
            "Fizz (12)",
            "13 (13)",
            "14 (14)",
            "FizzBuzz (15)"
        };

            // Act
            List<string> actualResults = Program.GenerateFizzBuzz(startNumber, runLength, divisimajigs);

            // Assert
            Assert.AreEqual(expectedResults, actualResults);
        }
    }
}