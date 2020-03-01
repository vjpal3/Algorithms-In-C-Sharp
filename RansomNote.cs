using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp
{
    class RansomNote
    {
        public static bool CanCreate(string note, string magazine)
        {
            Dictionary<string, int> magzineData = GetDictionaryData(magazine);
            var counter = 0;

            foreach (var word in note.Split(' '))
            {
                if(magzineData.TryGetValue(word, out int count))
                {
                    magzineData[word]--;
                    counter++;
                }
            }
            return counter >= note.Split(' ').Length ? true : false;
        }

        private static Dictionary<string, int> GetDictionaryData(string magazine)
        {
            string[] magazineWords = magazine.Split(' ');
            var magzineData = new Dictionary<string, int>();

            foreach (var word in magazineWords)
            {
                if (magzineData.ContainsKey(word))
                    magzineData[word] += 1;
                else
                    magzineData[word] = 1;
            }
            return magzineData;
        }
    }
}
