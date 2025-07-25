using Assessment;

namespace AssessmentTest;

public class SolutionTests
{
	[Fact]
	public void Test1()
	{
		var input = new int[,]
		{
			{4, 5, 2, 8 },
			{2, 4, 9, 1 },
			{3, 1, 6, 1 },
			{4, 2, 0, 9 },
			{5, 9, 1, 0 },
			{8, 8, 9, 1 }
		};

		var result = Solution1.MultiplySumationOfMinimumTicks(input);
		Assert.Equal(504, result);
	}

	[Fact]
	public void Test2()
	{
		var input = new int[][]
		{
			[5,2,6,1],
			[3, 7, 2, 4, 4],
			[55,277,166,123,88,3]
		};
		var result = Solution2.SolvePuzzle2(input);
		Assert.Equal(3, result);
	}

	[Fact]
	public void Test3()
	{
		var input = new List<Dictionary<char, char>>
		{
			new Dictionary<char, char> { {'*', '<'}, {'<', '*'} },
			new Dictionary<char, char> { {'+', '~'}, {'\'', '+'}, {'-', '\''} },
			new Dictionary<char, char> { {'+', '~'}, {'\'', '+'}, {'/', '='}, {'~', '\''} }
		};
		var result = Solution3.SolvePuzzle3(input);
		Assert.Equal(1, result);
	}

	[Fact]
	public void Test4()
	{
		var input = new Dictionary<int, int[]>
		{
			{ 12, new[] { 3, 6, 5 } },
			{ 18, new[] { 9, 6, 3 } }
		};
		var result = Solution4.SolvePuzzle4(input);
		Assert.Equal(34, result);
	}

	[Fact]
	public void Test5()
	{
		var input = new bool[4, 4]
		{
			{ true, true, false, false },
			{ false, true, true, false },
			{ false, false, true, false },
			{ true, false, false, false }
		};

		var result = Solution5.SolvePuzzle5(input);
		Assert.Equal(5, result);
	}
}
