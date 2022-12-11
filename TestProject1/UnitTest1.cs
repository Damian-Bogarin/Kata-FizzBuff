using System;
using Xunit;
using FizzBuzz;


namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestFizz()
        {
            int[] input = new int[] { 3 };
            string[] result = FizzBuzz.FizzBuzz.SolveFizzBuzz(input);
            string expected = "Fizz";
            Assert.Equal(expected, result[0]);
        }

        [Fact]
        public void TestBuzz()
        {
            int[] input = new int[] { 5 };
            string[] result = FizzBuzz.FizzBuzz.SolveFizzBuzz(input);
            string expected = "Buzz";
            Assert.Equal(expected, result[0]);
        }

        [Fact]
        public void TestFizzBuzz()
        {
            int[] input = new int[] { 15 };
            string[] result = FizzBuzz.FizzBuzz.SolveFizzBuzz(input);
            string expected = "FizzBuzz";
            Assert.Equal(expected, result[0]);
        }

        [Fact]
        public void TestMultipleFizzBuzz()
        {
            int[] input = new int[] { 1, 2, 3, 5, 8, 15, 7 };
            string[] result = FizzBuzz.FizzBuzz.SolveFizzBuzz(input);
            string[] expected = new string[] {"1", "2", "Fizz", "Buzz", "8", "FizzBuzz", "7"};
            Assert.Equal(expected, result);
        }
    }
}
