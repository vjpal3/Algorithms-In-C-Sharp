using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp
{
    public class Difference
    {
        public static int FindDiffLargestEvenSmallestOdd(int[] numbers)
        {
            int largestEvenNumber = int.MinValue;
            int smallestOddNumber = int.MaxValue;

            for(var i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    if (numbers[i] > largestEvenNumber)
                        largestEvenNumber = numbers[i];
                }
                else if(numbers[i] % 2 == 1)
                {
                    if (numbers[i] < smallestOddNumber)
                        smallestOddNumber = numbers[i];
                }
            }

            return largestEvenNumber - smallestOddNumber;
        }
    }
}
