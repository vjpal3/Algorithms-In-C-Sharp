using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp.FindTwins
{
	public static class Twins
	{
		public static void FindTwinNumbers(Random rand) {
			List<int> randomList = RandomExtensions.GenerateRandomList(rand, -100, 100, 1000);

			ShowList(randomList);
			
		}

		public static void ShowList(List<int> list) 
		{
			foreach(var item in list)
				Console.Write(item + "\t");

			Console.WriteLine();
		}
	}
}
