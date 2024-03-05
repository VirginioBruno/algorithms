namespace algorithms.console.Search.Binary
{
    public class BinarySearchImplementation : BaseSearchImplementation, IAlgorithmImplementation
    {
        public BinarySearchImplementation(int[] items, int item) : base(items, item) { }

        public int Execute()
        {
            var l = 0;
            var r = Items.Length - 1;

            while (l < r) 
            {
                var mid = l + (r - l) / 2;

                if (Items[mid] == Item)
                    return mid;

                if (Items[mid] > Item) 
                    r = mid - 1;
                else 
                    l = mid + 1;
            }

            return -1;
        }
    }
}
