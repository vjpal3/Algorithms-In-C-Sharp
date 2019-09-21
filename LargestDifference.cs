using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp
{
    class LargestDifference
    {
        //Find the largest difference between arr[j] and arr[i] such that j > i
        public static int FindLargestDifference1()
        {
            int[] arr = new int[] { 10, 3, 6, 8, 9, 4, 3 };

            int max = 0;
            int result = 0;
            for(var i = arr.Length-1; i >= 0; i--)
            {
                if (arr[i] > max)
                    max = arr[i];

                var tempResult = max - arr[i];
                if (tempResult > result)
                    result = tempResult;
            }
            return result;
        }
    }
}
