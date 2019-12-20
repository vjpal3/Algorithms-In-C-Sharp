using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp
{
    class Capitalization
    {
        public static string CapitalizeWords(string phrase)
        {
            char[] array = phrase.ToCharArray();

            if(array.Length >= 1 && char.IsLower(array[0]))
            {
                array[0] = char.ToUpper(array[0]);
            }
            for (var i = 1; i < array.Length; i++)
            {
                if (array[i-1] == ' ' && char.IsLower(array[i])) {
                    array[i] = char.ToUpper(array[i]);
                }
            }
            
            return new string(array);
        }

        public static string TitleCaseWords(string phrase)
        {
            string titleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
            return titleCase;
        }
    }
}
