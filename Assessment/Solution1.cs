namespace Assessment
{
    public static class Solution1
    {
        const int _dials = 4;

        public static int SolvePuzzle1(int[,] input)
        {
            Validate(input);

            var result = 1;
            var rows = input.GetLength(0);

            for (int i = 0; i < rows - 1; i += 2)
            {
                var sum = 0;

                for (int j = 0; j < _dials; j++)
                {
                    var diff = Math.Abs(input[i, j] - input[i + 1, j]);

                    sum += diff <= 5 ? diff : 10 - diff;
                }

                result *= sum;
            }

            return result;
        }

        private static void Validate(int[,] input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input), "Input cannot be null.");

            if (input.GetLength(1) != _dials)
                throw new ArgumentException("Input must have exactly 4 columns.");

            var rows = input.GetLength(0);

            if (rows == 0)
                throw new ArgumentException("Input must have at least two rows.");

            if (rows % 2 != 0)
                throw new ArgumentException("Input must have an even number of rows.");
        }
    }
}
