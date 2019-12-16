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
            var strings = new List<string>() { "abcd", "acdb", "dabc" };
            Console.WriteLine(Anagrams.AreAnagrams(strings));
            var strings1 = new List<string>() { "debit carb", "bad credit" };
            Console.WriteLine(Anagrams.AreAnagrams(strings1));

            Console.WriteLine("Press Enetr to exit");
            Console.ReadLine();
        }
    }
}
