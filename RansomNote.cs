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
            Dictionary<string, int> noteData = GetDictionaryData(note);

            foreach (var pair in noteData)
            {
                if (magzineData.TryGetValue(pair.Key, out int count))
                {
                    if (count < pair.Value)
                        return false;
                }
                else
                    return false;

            }
            return true;
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
