using Bogus;

namespace algorithms.console.Search.Linear
{
    public static class LinearSearch
    {
        public static void Do() 
        {
            var random = new Random();
            var items = Enumerable.Range(0, 1000000).Select(_ => random.Next(0, 1000)).ToArray();
            var item = 10;

            Console.WriteLine($"Executing {nameof(LinearSearch)} - Finding element {item} in collection with {items.Length} elements");
            var linearSearch = new LinearSearchImplementation(items, item);

            AlgorithmExecutor.Execute(linearSearch);
        }
    }
}
