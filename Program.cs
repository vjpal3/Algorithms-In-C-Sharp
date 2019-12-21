using System;
using System.Collections.Generic;
using AlgorithmsCSharp.CalculateInterest;


namespace AlgorithmsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Largest Difference
            //Console.WriteLine("Max Difference: " + LargestDifference.FindLargestDifference1());

            // Run CalculateInterest Code
            //var account = new Account(1000);
            //account.UpdateMonthlyBalance(1, 10f);
            //Console.WriteLine("Current Balance: " + account.ShowBalance()); 

            //Run FindTwins code 
            //var random = new Random();
            //Twins.FindAllTwinNumbers(random);

            //Run code for checking Anagrams
            //var strings = new List<string>() { "abcd", "acdb", "dabc" };
            //Console.WriteLine(Anagrams.AreAnagrams(strings));
            //var strings1 = new List<string>() { "debit carb", "bad credit" };
            //Console.WriteLine(Anagrams.AreAnagrams(strings1));


            //Console.WriteLine($"Vowel Count: { GetVowelCount("I am going to the beachside today, it's a beautiful day!")}");

            // Uppercase words in these strings.
            //const string str1 = "something in the way";
            //const string str2 = "dot net PERLS";
            //const string str3 = "String_two;three";
            //const string str4 = " sam";
            //const string str5 = " ";

            //Console.WriteLine(Capitalization.CapitalizeWords(str1));
            //Console.WriteLine(Capitalization.CapitalizeWords(str2));
            //Console.WriteLine(Capitalization.CapitalizeWords(str3));
            //Console.WriteLine(Capitalization.CapitalizeWords(str4));
            //Console.WriteLine(Capitalization.CapitalizeWords(str5));

            //Console.WriteLine(Capitalization.TitleCaseWords("how Beautiful is the Day!!"));

            Console.WriteLine(CaesarCipher.GetCaesarCipher("I Love JavaScript!", -100)); 


            Console.WriteLine("Press Enetr to exit");
            Console.ReadLine();

        }

        private static int GetVowelCount(string str)
        {
            // linear time complexity and constant space complexity because every character needs to be checked and temporary primitives are negligible.
            str = str.ToLower();
            //var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            string vowels = "aeiou";
            var count = 0;
            foreach (var character in str)
            {
                if (vowels.Contains(character.ToString()))
                    count++;
            }
            return count;
        }
    }
}
