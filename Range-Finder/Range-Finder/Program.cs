using System;
namespace Range_Finder {
	class program {
		static void Main() {
			string[,] testMarks = new string[4, 6]  {
				{ "Alex", "80", "85", "83", "79", "92" },
				{ "Bob", "87", "88", "90", "84", "87" },
				{ "Charlie", "95", "95", "100", "95", "95" },
				{ "Danni", "92", "93", "92", "96", "98" }, };
			Console.WriteLine(get_range(testMarks));
			Console.ReadKey();
		}
		static int get_range(string[,] testMarks) {
			int highestNumber = 0, lowestNumber = 0;
			foreach (var item in testMarks) {
				if (int.TryParse(item, out int t)) {
					if (t > highestNumber) highestNumber = t;
					if (t < lowestNumber || lowestNumber == 0) lowestNumber = t;
				}
			}
			return highestNumber - lowestNumber;
		}
	}
}