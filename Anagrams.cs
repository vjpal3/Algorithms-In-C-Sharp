using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlgorithmsCSharp
{
    class Anagrams
    {
        public static bool AreAnagrams(List<string> strings)
        {
            var nonAlpha = new Regex("[^a-zA-Z]");
            var alphaStrings = new List<string>();

            foreach (var str in strings) 
                alphaStrings.Add(nonAlpha.Replace(str, "").ToLower());

            for (var i = 1; i < alphaStrings.Count; i++)
            {
                if (alphaStrings[i].Length != alphaStrings[0].Length)
                    return false;
            }


            Dictionary<string, int> firstStringCharsCount =
                getCharsCount(alphaStrings[0]);

            for (var i = 1; i < alphaStrings.Count; i++)
            {
                Dictionary<string, int> charsCount =
                    getCharsCount(alphaStrings[i]);

                foreach (var kvp in charsCount)
                {
                    int firstStrCount = 0;
                    if (!(firstStringCharsCount.TryGetValue(kvp.Key, out firstStrCount) && (kvp.Value == firstStrCount)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static Dictionary<string, int> getCharsCount(string str)
        {
            var charsCount = new Dictionary<string, int>();
            foreach (var character in str)
            {
                if (charsCount.ContainsKey(character.ToString())) 
                {
                    charsCount[character.ToString()] += 1;
                }
                else
                {
                    charsCount[character.ToString()] = 1;
                }
            }
            return charsCount;
        }
    }
}
