namespace algorithms.console
{
    public static class Helper
    {
        public static int[] GenerateIntArray(int min = 1, int max = 1000, int size = 100) 
        {
            var result = new int[size];
            var random = new Random();
            var i = 0;

            while (result[i] == 0 && i < size)
            {
                var number = random.Next(min, max);
                if (result.Any(x => x == number))
                    continue;

                result[i] = number;

                i++;
            }

            return result;
        }

        public static int[] GenerateOrderedIntArray(int min = 1, int max = 1000, int size = 100)
        {
            var result = new int[size];
            var random = new Random();
            var i = 0;

            while (i <= size - 1 && result[i] == 0)
            {
                var number = random.Next(min, max);
                if (result.Any(x => x == number))
                    continue;

                result[i] = number;

                i++;
            }

            return result.OrderBy(x => x).ToArray();
        }
    }
}
