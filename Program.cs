using System;
using System.Linq;
using System.Collections.Generic;
using AlgorithmsCSharp.FindTwins;

namespace AlgorithmsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            Twins.FindTwinNumbers(random);
        }
    }
}
