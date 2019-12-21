using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp
{
    class CaesarCipher
    {
        public static string GetCaesarCipher(string str, int key)
        {
            StringBuilder builder = new StringBuilder();
            char[] charArray = str.ToCharArray();
            foreach (var character in charArray)
            {
                int code;
                if (char.IsLower(character))
                    code = ((int)character - (int)'a' + key) % 26 + (int)'a';

                else if (char.IsUpper(character))
                
                    code = ((int)character - (int)'A' + key) % 26 + (int)'A';

                else
                    code = (int)character;

                builder.Append((char)code);
            }
            return builder.ToString();
        }
    }
}
