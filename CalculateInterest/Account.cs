using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp.CalculateInterest
{
    class Account
    {
        private decimal currentBalance;

        public Account(decimal balance)
        {
            currentBalance = balance;
        }


        public decimal UpdateYearlyBalance(int years, float yearlyInterestRate)
        {
            for(var i = 0; i < years; i++)
            {
                currentBalance += currentBalance * (decimal) yearlyInterestRate / 100;
            }
            return currentBalance;
        }

        public decimal UpdateMonthlyBalance(int years, float monthlyInterestRate, decimal deposit, int dFrequency, decimal withdrawal, int wFrequency )
        {
            for (var i = 0; i < years * 12; i++)
            {
                if (i % wFrequency == 0)
                    currentBalance -= withdrawal;

                currentBalance += currentBalance * (decimal) monthlyInterestRate / 100;

                if (i % dFrequency == 0)
                    currentBalance += deposit;               
            }
            return currentBalance;
        }

        public string ShowBalance()
        {
            return string.Format("{0:C}", currentBalance);
        }
    }
}
