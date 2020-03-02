using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp
{
    class TwinNumbers
    {
        public static void FindTwins()
        {

            int[] arr = { 4, 8, 9, -4, 3, 1, -1, -8, -9, 5, 4 };            
            //int[] arr = { 4, 8, 9, 5, 6 };

            var counts = new Dictionary<int, int>();
            var uniqueNumbers = new HashSet<int>();
            
            foreach (var item in arr)
            {
                if(counts.ContainsKey(Math.Abs(item)))
                {
                    uniqueNumbers.Add(Math.Abs(item));
                }
                else
                {
                    counts[Math.Abs(item)] = 1;
                }

            }

            if (uniqueNumbers.Count == 0)
            {
                Console.WriteLine("No Twin found!");
                return;
            }
                

            foreach( var item in uniqueNumbers)
            {
                Console.WriteLine($"-{item} {item}");
            }
        }
        
    }
}
