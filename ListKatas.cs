using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp
{
    class ListKatas
    {
        public static void Start()
        {
            List<Tuple<int, int>> output = FindTowSum(new List<int>() { 1, 2, 2, 3, 4 }, 4);
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }

        // Return all pairs in a list that add up to a given sum
        public static List<Tuple<int, int>> FindTowSum(List<int> list, int sum)
        {
            var store = new HashSet<int>();
            var output = new List<Tuple<int, int>>();

            foreach (var num in list)
            {
                var needed = sum - num;
                if (store.Contains(needed))
                {
                    output.Add(new Tuple<int, int>(num, needed));
                }
                else
                {
                    store.Add(num);
                }
            }

            return output;
        }

        
    }
}
