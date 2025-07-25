namespace Assessment;
public static class Solution4
{
	public static int SolvePuzzle4(Dictionary<int, int[]> input)
	{
		var result = 0;

		foreach (var kvp in input)
		{
			// If input data manipulation is not allowed, we can copy the array.
			var set = kvp.Value;

			Array.Sort(set, (a, b) => b.CompareTo(a));
			
			result = result * 10 + FindMaxDivisions(kvp.Key, set);
		}

		return result;
	}

	private static int FindMaxDivisions(int n, int[] set)
	{
		var maxDivistions = 0;
		var i = 0;

		while (i < set.Length)
		{
			if (set[i] >= n)
			{
				i++;
				continue;
			}

			var dividend = n;
			var divisionCounter = 0;
			var piles = 1;

			for (int j = i; j < set.Length; j++)
			{
				if (dividend % set[j] != 0)
					continue;

				if (piles == 1)
					i = j + 1;

				divisionCounter += piles;
				piles = piles * dividend / set[j];
				dividend = set[j];
			}

			if (maxDivistions < divisionCounter)
				maxDivistions = divisionCounter;
		}

		return maxDivistions;
	}
}
