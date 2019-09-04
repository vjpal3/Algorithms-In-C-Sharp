using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp.FindTwins
{
    public static class Twins
    {
        public static bool FindTwinNumbers(Random rand) {
            List<int> randomList = RandomExtensions.GenerateRandomList(rand, -1000, 10000, 10000);
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            //ShowList(randomList);

            foreach (var item in randomList)
            {               
                if(numbers.ContainsKey(item))
                {                                      
                    if (numbers.ContainsKey(item * -1))
                    {                       
                        Console.WriteLine("Found first Pair that sums to zero: " + item + " & " + (item * -1));
                        return true;
                    }
                } 
                else                
                    numbers.Add(item, 1);                             
            }
            Console.WriteLine("No Pair found that sums to zero");
            return false;          
        }
        public static void ShowList(List<int> list) 
        {
            foreach(var item in list)
                Console.Write(item + "\t");

            Console.WriteLine();
        }
    }
}
