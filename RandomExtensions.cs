using System;
using System.Collections.Generic;


namespace AlgorithmsCSharp
{
    public class RandomExtensions
    {
        public static List<int> GenerateRandomList (Random rand, int min, int max, int numberOfItems)
        {
            List<int> randomList = new List<int>();
            for(var i = 0; i < numberOfItems; i++)
            {
                randomList.Add(rand.Next(min, max + 1));
            }
            return randomList;
        }

        public static void Shuffle<T>(Random rand, List<T> list)
        {
            var n = list.Count;
            while (n > 1)
            {
                int k = rand.Next(n--);
                (list[k], list[n]) = (list[n], list[k]);
            }
        }

    }
}
