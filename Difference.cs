using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp
{
    public class Difference
    {
        public static int? FindDiffLargestEvenSmallestOdd(int?[] numbers)
        {
            //int largestEvenNumber = int.MinValue;
            //int smallestOddNumber = int.MaxValue;

            //for(var i = 0; i < numbers.Length; i++)
            //{
            //    if(numbers[i] % 2 == 0)
            //    {
            //        if (numbers[i] > largestEvenNumber)
            //            largestEvenNumber = numbers[i];
            //    }
            //    else if(numbers[i] % 2 == 1)
            //    {
            //        if (numbers[i] < smallestOddNumber)
            //            smallestOddNumber = numbers[i];
            //    }
            //}

            //return largestEvenNumber - smallestOddNumber;

            int? largestEvenNumber = null;
            int? smallestOddNumber = null;

            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    if (!largestEvenNumber.HasValue || num > largestEvenNumber)
                    {
                        largestEvenNumber = num;
                    }
                }
                else if (num % 2 != 0)
                {
                    if (!smallestOddNumber.HasValue || num < smallestOddNumber)
                    {
                        smallestOddNumber = num;
                    }
                }
            }

            if(largestEvenNumber == null)
            {
                throw new ArgumentNullException("Array does not contain any even number");
            }
            else
            {
                Console.WriteLine($"Largest Even number: {largestEvenNumber}");
            }

            if (smallestOddNumber == null)
            {
                throw new ArgumentNullException("Array does not contain any odd number");
            }
            else
            {
                Console.WriteLine($"Smallest Odd number: {smallestOddNumber}");
            }

            if (largestEvenNumber != null && smallestOddNumber != null)
            {
                Console.Write("Difference: ");
                return largestEvenNumber - smallestOddNumber;
            }

            return null;
        }
    }
}
