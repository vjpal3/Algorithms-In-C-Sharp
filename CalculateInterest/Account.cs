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
        public TransactionData data { get; set; }

        public Account(decimal balance)
        {
            currentBalance = balance;
            data = new TransactionData { Deposit = 10.0m, Withdrawal = 20m, DepositFreq = 2, WithdrawalFreq = 4 };
        }

        public decimal UpdateYearlyBalance(int years, float yearlyInterestRate)
        {
            for(var i = 0; i < years; i++)
            {
                currentBalance += currentBalance * (decimal) yearlyInterestRate / 100;
            }
            return currentBalance;
        }

        public decimal UpdateMonthlyBalance(int years, float monthlyInterestRate)
        {
            for (var i = 0; i < years * 12; i++)
            {
                RecurringWithdrawal(i);

                currentBalance += currentBalance * (decimal)monthlyInterestRate / 100;

                RecurringDeposit(i);
            }
            currentBalance = Decimal.Round(currentBalance, 2);          
            return currentBalance;
        }

        private void RecurringWithdrawal(int month)
        {
            if (month % (data.WithdrawalFreq-1) == 0)
                currentBalance -= data.Withdrawal;
        }

        private void RecurringDeposit(int month)
        {
            if (month % (data.DepositFreq-1) == 0)
                currentBalance += data.Deposit;
        }

        public string ShowBalance()
        {
            return string.Format("{0:C}", currentBalance);
        }
    }
}
