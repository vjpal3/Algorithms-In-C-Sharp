using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp.CalculateInterest
{
    class TransactionData
    {
        public decimal Deposit { get; set; }
        public decimal Withdrawal { get; set; }
        public int DepositFreq { get; set; }
        public int WithdrawalFreq { get; set; }
    }
}
