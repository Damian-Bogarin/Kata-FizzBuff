using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static string[] SolveFizzBuzz(int[] numbers)
        {
            string [] result = new string[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                string partialResult = "";
                if (numbers[i] % 3 == 0)
                {
                    partialResult += "Fizz";
                }
                if (numbers[i] % 5 == 0)
                {
                    partialResult += "Buzz";
                }
                if(partialResult.Length == 0)
                {
                    partialResult = numbers[i].ToString();
                }
                result[i] = partialResult;
            }
            return result;
        }
    }
}
