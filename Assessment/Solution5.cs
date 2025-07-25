namespace Assessment;
public static class Solution5
{
	public static int SolvePuzzle5(bool[,] input)
	{
		var rows = input.GetLength(0);
		var cols = input.GetLength(1);
		var visitedCells = new bool[rows, cols];
		var result = 0;

		for (int i = 0; i < rows; i++)
			for (int j = 0; j < cols; j++)
			{
				if (!input[i, j] || visitedCells[i, j])
					continue;

				var newArea = ExploreArea(i, j, rows, cols, input, ref visitedCells);

				if (newArea > result)
					result = newArea;
			}

		return result;
	}

	private static int ExploreArea(int i, int j, int rows, int cols, bool[,] input, ref bool[,] visitedCells)
	{
		// If the input is a very large grid, we can optimize the recursion by using a stack or queue to avoid deep recursion.
		var result = 1;
		visitedCells[i, j] = true;

		for (int x = i - 1; x <= i + 1; x++)
			for (int y = j - 1; y <= j + 1; y++)
			{
				if (x < 0 || x >= rows || y < 0 || y >= cols || x == i && y == j)
					continue;

				if (input[x, y] && !visitedCells[x, y])
					result += ExploreArea(x, y, rows, cols, input, ref visitedCells);
			}

		return result;
	}
}
