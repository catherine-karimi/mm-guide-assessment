namespace Assessment;
public static class Solution2
{
    public static int SolvePuzzle2(int[][] input)
    {
        var result = 0;

        for (int i = 0; i < input.Length; i++)
        {
            var array = GetCorrespondingArray(input[i]);

            Array.Sort(array);

            var median = GetRoundedMedian(array);

            result += median;
        }

        return result;
    }

    private static int[] GetCorrespondingArray(int[] input)
    {
        var length = input.Length;
        var result = new int[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = 0;

            for (int j = i + 1; j < length; j++)
                if (input[j] < input[i])
                    result[i]++;
        }

        return result;
    }

    private static int GetRoundedMedian(int[] array)
    {
        var length = array.Length;

        if (length == 0)
            return 0;

        var mid = length / 2;

        if (length % 2 == 0)
            return (int)Math.Round((array[mid - 1] + array[mid]) / 2.0);
        else
            return array[length / 2];
    }
}
