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

        public static void FindAllTwinNumbers(Random rand)
        {
            List<int> randomList = RandomExtensions.GenerateRandomList(rand, -10, 10, 50);
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            ShowList(randomList);
            Console.WriteLine();
            List<int> pairs = new List<int>();

            foreach (var item in randomList)
            {
                if (numbers.ContainsKey(item))
                {
                    if (numbers.ContainsKey(item * -1))
                    {
                        pairs.Add(item);
                        numbers.Remove(item);
                        numbers.Remove(item * -1);
                    }

                }
                else
                    numbers.Add(item, 1);
            }

            if (pairs.Count > 0)
            {
                Console.WriteLine("Twin Pairs:");
                pairs.Sort();
                foreach (var item in pairs)
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();
            }
            else 
                   Console.WriteLine("No Twin pairs found");

        }
        public static void ShowList(List<int> list) 
        {
            list.Sort();
            foreach (var item in list)
                Console.Write(item + "\t");

            Console.WriteLine();
        }
    }
}
