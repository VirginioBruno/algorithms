namespace algorithms.console
{
    public static class Helper
    {
        public static int[] GenerateIntArray(int min = 1, int max = 1000, int size = 100) 
        {
            var random = new Random();
            return Enumerable.Range(1, size).Select(_ => random.Next(min, max)).ToArray();
        }

        public static int[] GenerateOrderedIntArray(int min = 1, int max = 1000, int size = 100)
        {
            var result = GenerateIntArray(min, max, size);
            return [.. result.OrderBy(x => x)];
        }

        public static string ShowElements(int[] array) 
        {
            var stringArray = "";

            for(int i = 0; i < array.Length; i++) 
                stringArray += array[i] + (array.Length - 1 == i ? "" : ", ");

            return stringArray;
        }
    }
}
