namespace algorithms.console.Search.Binary
{
    internal class BinarySearch
    {
        public static void Do()
        {
            var random = new Random();
            var items = Helper.GenerateOrderedIntArray(1, 1000, 1000);
            var item = 10;

            var exists = items.Any(x => x == item);
            Console.WriteLine($"Executing {nameof(BinarySearchImplementation)} - Finding element {item} in collection with {items.Length} elements - Exists? {exists}");
            var search = new BinarySearchImplementation(items, item);

            AlgorithmExecutor.Execute(search);
        }

        public static void DoRecursive()
        {
            var random = new Random();
            var items = Helper.GenerateOrderedIntArray(1, 1000);
            var item = 10;

            Console.WriteLine($"Executing {nameof(BinarySearchRecursiveImplementation)} - Finding element {item} in collection with {items.Length} elements");
            var search = new BinarySearchRecursiveImplementation(items, item);

            AlgorithmExecutor.Execute(search);
        }
    }
}
