using System.Diagnostics;

namespace algorithms.console
{
    public static class AlgorithmExecutor
    {
        public static void Execute(IAlgorithmImplementation algorithm) 
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            var result = algorithm.Execute();

            stopWatch.Stop();

            Console.WriteLine($"{(result >= 0 ? $"Element found at {result}" : "Element not found")}. Elapsed: {stopWatch.Elapsed}");
        }
    }
}
