using System;
using AlgorithmsCSharp.CalculateInterest;


namespace AlgorithmsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account(100);
            //account.UpdateYearlyBalance(5, 1.47f);
            account.UpdateMonthlyBalance(1, 10f, 20, 2, 10, 4);

            Console.WriteLine("Current Balance: " + account.ShowBalance()); 
            
            //Run FindTwins code 
            //var random = new Random();
            //Twins.FindAllTwinNumbers(random);
        }
    }
}
